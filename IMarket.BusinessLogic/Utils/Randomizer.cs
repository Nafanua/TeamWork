using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IMarket.DAL;
using IMarket.Models.Models;
using IMarket.Models.Models.Enums;


namespace IMarket.BusinessLogic.Utils
{
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
                var color = ((Color)rnd.Next(3)).ToString();
                ItemBase item = default;

                switch (rnd.Next(5))
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
                            Type = ItemType.WinterSport
                        };
                        break;
                }

                if (item.Weight < Storage.MaximumStorageCapacity - Storage.GetStorageCapacity())
                {
                    Storage.AddToStorage(item);
                }
                Thread.Sleep(rnd.Next(15000));
            }
        }

        private static void Sell()
        {
            var rnd = new Random();
            while (true)
            {
                var item = Storage.GetItemByIndex(rnd.Next(Storage.GetCountOfItemsInStock()));
                Storage.Sell(item);
                Thread.Sleep(rnd.Next(15000));
            }
        }
    }
}
