using System;
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
            new Randomizer().Start();
        }

        class Creator
        {

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
                        Storage.AddToItemOutOfStock(item);
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
                var color = ((Color)rnd.Next(3)).ToString();
                ItemBase item = default;

                switch (rnd.Next(1, 5))
                {
                    case 1:
                        var closeType = (ClothesType)rnd.Next(3);
                        item = new ClothesModel
                        {
                            ClothesType = closeType,
                            Color = color,
                            DeliveryTime = DateTime.Now,
                            Name = $"{color} {closeType}",
                            Size = rnd.Next(36, 58).ToString(),
                            Weight = (double)rnd.Next(1, 10) / 10,
                            Quantity = rnd.Next(5, 20),
                            Type = ItemType.Clothes
                        };
                        break;
                    case 2:
                        var ballType = (BallType)rnd.Next(4);
                        item = new BallModel
                        {
                            BallType = ballType,
                            Color = color,
                            DeliveryTime = DateTime.Now,
                            Name = $"{color} {ballType}",
                            Diameter = rnd.Next(18, 28),
                            Weight = (double)rnd.Next(1, 10) / 10,
                            Quantity = rnd.Next(5, 20),
                            Type = ItemType.Ball
                        };
                        break;
                    case 3:
                        var sportsAccessoriesType = (SportsAccessoriesType)rnd.Next(3);
                        item = new SportsAccessoriesModel
                        {
                            SportsAccessoriesType = sportsAccessoriesType,
                            Color = color,
                            DeliveryTime = DateTime.Now,
                            Name = $"{color} {sportsAccessoriesType}",
                            Weight = (double)rnd.Next(1, 10) / 10,
                            Quantity = rnd.Next(5, 20),
                            Type = ItemType.SportAccessories
                        };
                        break;
                    case 4:
                        var winterSportsType = (WinterSportsType)rnd.Next(3);
                        item = new WinterSportsModel
                        {
                            WinterSportsType = winterSportsType,
                            Color = color,
                            DeliveryTime = DateTime.Now,
                            Name = $"{color} {winterSportsType}",
                            Lenght = (double)rnd.Next(10, 15) / 10,
                            Weight = (double)rnd.Next(1, 20) / 10,
                            Quantity = rnd.Next(5, 20),
                            Type = ItemType.WinterSport
                        };
                        break;
                }
                return item;
            }
        }


    }
}
