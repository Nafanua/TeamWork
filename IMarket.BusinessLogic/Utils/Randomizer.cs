using System;
using System.Threading;
using IMarket.DAL;
using IMarket.Models.Models;
using IMarket.Models.Models.Enums;


namespace IMarket.BusinessLogic.Utils
{
    public static class Randomizer
    {
        static Random Rnd = new Random(DateTime.Now.Millisecond);

        public static void Start()
        {
            var threadBuy = new Thread(Buy);
            var threadSell = new Thread(Sell);
            threadBuy.Start();
            threadSell.Start();
        }

        private static void Buy()
        {
            Thread.Sleep(5000);

           // var rnd = new Random();

            while (true)
            {
                var item = GenerateProduct();

                for (var i = 1; i < Rnd.Next(10,30); i++)
                {
                    if (item != null && item.Weight < Storage.MaximumStorageCapacity - Storage.GetStorageCapacity())
                    {
                        Storage.AddToStorage(item);
                    }
                    else
                    {
                        Storage.AddToNoPlaceInStock(item);
                    }
                }
                Thread.Sleep(Rnd.Next(15000));
            }
        }

        private static void Sell()
        {
            Thread.Sleep(5000);
          //  var rnd = new Random(DateTime.Now.Millisecond);
            while (true)
            {
                var item = GenerateProduct();

                for (var i = 0; i < Rnd.Next(1, 30); i++)
                {
                    if (!Storage.Sell(item.Name))
                    {
                        Storage.AddToItemNotFound(item);
                    }
                }

                Thread.Sleep(Rnd.Next(15000));
            }
        }

        private static ItemBase GenerateProduct()
        {
        //    var rnd = new Random();
            var color = ((Color)Rnd.Next(7));
            ItemBase item = default;

            
            switch (Rnd.Next(1, 5))
            {
                case 1:
                    var clothesType = (ConcreteType)Rnd.Next(4,7);
                    item = new ClothesModel(clothesType)
                    {
                        ConcreteType = clothesType,
                        Color = color,
                        DeliveryTime = DateTime.Now,
                        Name = $"{color} {clothesType}",
                        Size = Rnd.Next(36, 58).ToString(),
                  //      Quantity = rnd.Next(5, 20),
                        Type = GeneralType.Clothes
                    };
                    break;
                case 2:
                    var ballType = (ConcreteType)Rnd.Next(0,4);
                    item = new BallModel(ballType)
                    {
                        ConcreteType = ballType,
                        Color = color,
                        DeliveryTime = DateTime.Now,
                        Name = $"{color} {ballType}",
                        Diameter = Rnd.Next(18, 28),
                    //    Quantity = rnd.Next(5, 20),
                        Type = GeneralType.Ball
                    };
                    break;
                case 3:
                    var sportsAccessoriesType = (ConcreteType)Rnd.Next(7,11);
                    item = new SportsAccessoriesModel(sportsAccessoriesType)
                    {
                        ConcreteType = sportsAccessoriesType,
                        Color = color,
                        DeliveryTime = DateTime.Now,
                        Name = $"{color} {sportsAccessoriesType}",
                    //    Quantity = rnd.Next(5, 20),
                        Type = GeneralType.SportAccessories
                    };
                    break;
                case 4:
                    var winterSportsType = (ConcreteType)Rnd.Next(10,13);
                    item = new WinterSportsModel(winterSportsType)
                    {
                        ConcreteType = winterSportsType,
                        Color = color,
                        DeliveryTime = DateTime.Now,
                        Name = $"{color} {winterSportsType}",
                        Lenght = (double)Rnd.Next(10, 15) / 10,
                     //   Quantity = rnd.Next(5, 20),
                        Type = GeneralType.WinterSport
                    };
                    break;
            }
            return item;
        }
    }
}
