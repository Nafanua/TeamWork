using System;
using System.Collections.Generic;
using System.Threading;
using IMarket.DAL;
using IMarket.Models.Models;
using IMarket.Models.Models.Enums;

namespace TestRandomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Randomizer.Start();
        }

        public static class Randomizer
        {
            public static void Start()
            {
                var threadBuy = new Thread(Buy);
                var threadSell = new Thread(Sell);
                threadBuy.Start();
                threadSell.Start();

                //ConsoleKeyInfo key;

                //do
                //{
                //    key = Console.ReadKey();

                //    if (key.Key != ConsoleKey.Escape) continue;
                //    threadBuy.Interrupt();
                //    threadSell.Interrupt();
                //} while (key.Key != ConsoleKey.Escape);

                

            }

            private static void Buy()
            {
                var rnd = new Random();

                while (true)
                {
                    var item = GenerateProduct();

                    if (item != null && item.Weight * item.Quantity < Storage.MaximumStorageCapacity - Storage.GetStorageCapacity())
                    {
                        Storage.AddToStorage(item);
                    }
                    else
                    {
                        Storage.AddToNoPlaceInStock(item);
                    }
                    Thread.Sleep(rnd.Next(15000));
                }
            }

            private static void Sell()
            {
                var rnd = new Random();
                while (true)
                {
                    var item = GenerateProduct();
                    var allByNameItems = Storage.GetByName(item.Name);
                //    var quantity = allByNameItems.
                    if (!Storage.Sell(item))
                    {
                        Storage.AddToItemNotFound(item);
                    }
                    Thread.Sleep(rnd.Next(30000));
                }
            }

            private static ItemBase GenerateProduct()
            {
                var rnd = new Random();
                var color = ((Color)rnd.Next(3));
                ItemBase item = default;

                switch (rnd.Next(1, 5))
                {
                    case 1:
                        var clothesType = (ConcreteType)rnd.Next(4, 7);
                        item = new ClothesModel(clothesType)
                        {
                            ConcreteType = clothesType,
                            Color = color,
                            DeliveryTime = DateTime.Now,
                            Name = $"{color} {clothesType}",
                            Size = rnd.Next(36, 58).ToString(),
                            Quantity = rnd.Next(5, 20),
                            Type = GeneralType.Clothes
                        };
                        break;
                    case 2:
                        var ballType = (ConcreteType)rnd.Next(0, 4);
                        item = new BallModel(ballType)
                        {
                            ConcreteType = ballType,
                            Color = color,
                            DeliveryTime = DateTime.Now,
                            Name = $"{color} {ballType}",
                            Diameter = rnd.Next(18, 28),
                            Quantity = rnd.Next(5, 20),
                            Type = GeneralType.Ball
                        };
                        break;
                    case 3:
                        var sportsAccessoriesType = (ConcreteType)rnd.Next(7, 11);
                        item = new SportsAccessoriesModel(sportsAccessoriesType)
                        {
                            ConcreteType = sportsAccessoriesType,
                            Color = color,
                            DeliveryTime = DateTime.Now,
                            Name = $"{color} {sportsAccessoriesType}",
                            Quantity = rnd.Next(5, 20),
                            Type = GeneralType.SportAccessories
                        };
                        break;
                    case 4:
                        var winterSportsType = (ConcreteType)rnd.Next(10, 13);
                        item = new WinterSportsModel(winterSportsType)
                        {
                            ConcreteType = winterSportsType,
                            Color = color,
                            DeliveryTime = DateTime.Now,
                            Name = $"{color} {winterSportsType}",
                            Lenght = (double)rnd.Next(10, 15) / 10,
                            Quantity = rnd.Next(5, 20),
                            Type = GeneralType.WinterSport
                        };
                        break;
                }
                return item;
            }
        }


    }
}
