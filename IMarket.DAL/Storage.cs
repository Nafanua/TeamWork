using IMarket.Models.Models.Enums;
using System;
using IMarket.Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace IMarket.DAL
{
    public static class Storage
    {
        public const double MaximumStorageCapacity = 350;
        private static object locker = new object();

        private static readonly List<ItemBase> Stock = new List<ItemBase>() {
            // Clothes
            new ClothesModel(ConcreteType.TShirt){ConcreteType = ConcreteType.TShirt, Color = Color.White, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "White TShirt",Size = "46 - 56", Quantity = 10, Type = GeneralType.Clothes},
            new ClothesModel(ConcreteType.TShirt){ConcreteType = ConcreteType.TShirt, Color = Color.Black, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Black TShirt",Size = "48 - 56", Quantity = 10, Type = GeneralType.Clothes},
            new ClothesModel(ConcreteType.TShirt){ConcreteType = ConcreteType.TShirt, Color = Color.Cyan, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Blue TShirt",Size = "48 - 56", Quantity = 10, Type = GeneralType.Clothes},
            new ClothesModel(ConcreteType.Pants){ConcreteType = ConcreteType.Pants, Color = Color.White, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "White Pants",Size = "46 - 56", Quantity = 10, Type = GeneralType.Clothes},
            new ClothesModel(ConcreteType.Pants){ConcreteType = ConcreteType.Pants, Color = Color.Black, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Black Pants",Size = "48 - 56", Quantity = 10, Type = GeneralType.Clothes},
            new ClothesModel(ConcreteType.Pants){ConcreteType = ConcreteType.Pants, Color = Color.Blue, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Blue Pants",Size = "48 - 56", Quantity = 10, Type = GeneralType.Clothes},
            new ClothesModel(ConcreteType.Shoes){ConcreteType = ConcreteType.Shoes, Color = Color.White, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "White Shoes",Size = "37 - 45", Quantity = 10, Type = GeneralType.Clothes},
            new ClothesModel(ConcreteType.Shoes){ConcreteType = ConcreteType.Shoes, Color = Color.Red, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Red Shoes",Size = "39 - 46", Quantity = 10, Type = GeneralType.Clothes},
            new ClothesModel(ConcreteType.Shoes){ConcreteType = ConcreteType.Shoes, Color = Color.Black, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Black Shoes",Size = "39 - 46", Quantity = 10, Type = GeneralType.Clothes},
            // Ball
            new BallModel(ConcreteType.SoccerBall){ConcreteType = ConcreteType.SoccerBall, Color = Color.Red, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Red Ball",Diameter = 22, Quantity = 10, Type = GeneralType.Ball},
            new BallModel(ConcreteType.SoccerBall){ConcreteType = ConcreteType.SoccerBall, Color = Color.White, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "White Ball",Diameter = 22, Quantity = 10, Type = GeneralType.Ball},
            new BallModel(ConcreteType.VolleyballBall){ConcreteType = ConcreteType.VolleyballBall, Color = Color.White, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "White Ball",Diameter = 19, Quantity = 10, Type = GeneralType.Ball},
            new BallModel(ConcreteType.VolleyballBall){ConcreteType = ConcreteType.VolleyballBall, Color = Color.Black, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Grey Ball",Diameter = 19, Quantity = 10, Type = GeneralType.Ball},
            new BallModel(ConcreteType.BasketballBall){ConcreteType = ConcreteType.BasketballBall, Color = Color.Blue, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Orange Ball",Diameter = 27, Quantity = 10, Type = GeneralType.Ball},
            new BallModel(ConcreteType.BasketballBall){ConcreteType = ConcreteType.BasketballBall, Color = Color.Cyan, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Yellow&Purple Ball",Diameter = 27, Quantity = 10, Type = GeneralType.Ball},
            new BallModel(ConcreteType.BaseballBall){ConcreteType = ConcreteType.BaseballBall, Color = Color.Black, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Grey Ball",Diameter = 8, Quantity = 10, Type = GeneralType.Ball},
            new BallModel(ConcreteType.BaseballBall){ConcreteType = ConcreteType.BaseballBall, Color = Color.White, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "White Ball",Diameter = 8, Quantity = 10, Type = GeneralType.Ball},
            // SportsAccessories
            new SportsAccessoriesModel(ConcreteType.Stopwatch){ConcreteType = ConcreteType.Stopwatch, Color = Color.Blue, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Blue Stopwatch", Quantity = 10, Type = GeneralType.SportAccessories},
            new SportsAccessoriesModel(ConcreteType.Stopwatch){ConcreteType = ConcreteType.Stopwatch, Color = Color.Green, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Green Stopwatch", Quantity = 10, Type = GeneralType.SportAccessories},
            new SportsAccessoriesModel(ConcreteType.BallPump){ConcreteType = ConcreteType.BallPump, Color = Color.Green, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Green Pump", Quantity = 10, Type = GeneralType.SportAccessories},
            new SportsAccessoriesModel(ConcreteType.BallPump){ConcreteType = ConcreteType.BallPump, Color = Color.Blue, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Blue Pump", Quantity = 10, Type = GeneralType.SportAccessories},
            new SportsAccessoriesModel(ConcreteType.Whistle){ConcreteType = ConcreteType.Whistle, Color = Color.Cyan, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Yellow Whistle", Quantity = 10, Type = GeneralType.SportAccessories},
            new SportsAccessoriesModel(ConcreteType.Whistle){ConcreteType = ConcreteType.Whistle, Color = Color.White, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "White Whistle", Quantity = 10, Type = GeneralType.SportAccessories},
            // WinterSports
            // Лыжи
            new WinterSportsModel(ConcreteType.Skiing){ConcreteType = ConcreteType.Skiing, Color = Color.Red, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Red Skiing",Lenght = 1.5, Quantity = 10, Type = GeneralType.WinterSport},
            new WinterSportsModel(ConcreteType.Skiing){ConcreteType = ConcreteType.Skiing, Color = Color.Blue, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Blue Skiing",Lenght = 1.5, Quantity = 10, Type = GeneralType.WinterSport},
            // Санки
            new WinterSportsModel(ConcreteType.Sled){ConcreteType = ConcreteType.Sled, Color = Color.Green, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Green Sled",Lenght = 0.8, Quantity = 10, Type = GeneralType.WinterSport},
            new WinterSportsModel(ConcreteType.Sled){ConcreteType = ConcreteType.Sled, Color = Color.Blue, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Blue Sled",Lenght = 0.8, Quantity = 10, Type = GeneralType.WinterSport},
            // Клюшки
            new WinterSportsModel(ConcreteType.Sticks){ConcreteType = ConcreteType.Sticks, Color = Color.Black, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Yellow Sticks",Lenght = 1.9, Quantity = 10, Type = GeneralType.WinterSport},
            new WinterSportsModel(ConcreteType.Sticks){ConcreteType = ConcreteType.Sticks, Color = Color.Red, DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Red Sticks",Lenght = 1.9, Quantity = 10, Type = GeneralType.WinterSport},
        };

        private static readonly List<ItemBase> ItemNotFound = new List<ItemBase>
        {
            new ClothesModel(ConcreteType.TShirt){ConcreteType = ConcreteType.TShirt, Color = Color.White, DeliveryTime = new  DateTime(2018, 11, 08),
                 Name = "ItemNotFound",Size = "46 - 56", Quantity = 1, Type = GeneralType.Clothes}
        };

        private static readonly List<ItemBase> ItemNoPlaceInStock = new List<ItemBase>
        {
            new WinterSportsModel(ConcreteType.Sled){ConcreteType = ConcreteType.Sled, Color = Color.White, DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "ItemNoPlaceInStock",Lenght = 0.8, Quantity = 2, Type = GeneralType.WinterSport}
        };

        public static double GetStorageCapacity()
        {
            return Stock.Sum(i => (i.Weight * i.Quantity));
        }

        public static bool AddToStorage(ItemBase item)
        {
            if (GetStorageCapacity() >= MaximumStorageCapacity)
            {
                return false;
            }

            lock (locker)
            {
                Stock.Add(item);
            }

            return true;
        }

        public static IEnumerable<ItemBase> GetAll()
        {
            return Stock.GetRange(0, Stock.Count);
        }

        public static IEnumerable<ItemBase> GetByName(string name)
        {
            return Stock.Where(i => i.Name.Equals(name));
        }

        public static IEnumerable<ItemBase> GetMany(Func<ItemBase, bool> filter)
        {
            return Stock.Where(filter);
        }

        public static int GetCountOfItemsInStock()
        {
            return Stock.Count;
        }

        public static IEnumerable<ItemBase> GetAllItemsOutOfStock()
        {
            return ItemNoPlaceInStock.GetRange(0, ItemNoPlaceInStock.Count);
        }

        public static IEnumerable<ItemBase> GetAllItemNotFound()
        {
            return ItemNotFound.GetRange(0, ItemNotFound.Count);
        }

        public static void AddToItemNotFound(ItemBase item)
        {
            ItemNotFound.Add(item);
        }

        public static void AddToNoPlaceInStock(ItemBase item)
        {
            ItemNoPlaceInStock.Add(item);
        }

        public static bool Sell(ItemBase item)
        {
            lock (locker)
            {
                if (Stock.Contains(item))
                {
                    Stock.Remove(item);

                    return true;
                }
            }

            return false;
        }

        public static bool Sell(int index, int quantity)
        {
            lock (locker)
            {
                if (Stock[index].Quantity > quantity)
                {
                    Stock[index].Quantity -= quantity;
                    return true;
                }
            }
            return false;
        }

        public static ItemBase GetItemByIndex(int index)
        {
            return Stock[index];
        }
    }
}
