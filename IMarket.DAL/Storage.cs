using IMarket.Models.Models.Enums;
using System;
using IMarket.Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace IMarket.DAL
{
    public static class Storage
    {
        public const double MaximumStorageCapacity = 1000;
        private static readonly List<ItemBase> Stock = new List<ItemBase>() {
                                                                             // Clothes
        new ClothesModel{ClothesType = ClothesType.TShirt, Color = "White", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "White TShirt",Size = "46 - 56", Weight = 0.5, Type = ItemType.Clothes
    },
            new ClothesModel{ClothesType = ClothesType.TShirt, Color = "Black", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Black TShirt",Size = "48 - 56", Weight = 0.5, Type = ItemType.Clothes
},
            new ClothesModel{ClothesType = ClothesType.TShirt, Color = "Blue", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Blue TShirt",Size = "48 - 56", Weight = 0.5, Type = ItemType.Clothes},
            new ClothesModel{ClothesType = ClothesType.Pants, Color = "White", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "White Pants",Size = "46 - 56", Weight = 0.7, Type = ItemType.Clothes},
            new ClothesModel{ClothesType = ClothesType.Pants, Color = "Black", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Black Pants",Size = "48 - 56", Weight = 0.7, Type = ItemType.Clothes},
            new ClothesModel{ClothesType = ClothesType.Pants, Color = "Blue", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Blue Pants",Size = "48 - 56", Weight = 0.7, Type = ItemType.Clothes},
            new ClothesModel{ClothesType = ClothesType.Shoes, Color = "White", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "White Shoes",Size = "37 - 45", Weight = 1.2, Type = ItemType.Clothes},
            new ClothesModel{ClothesType = ClothesType.Shoes, Color = "Red", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Red Shoes",Size = "39 - 46", Weight = 1.2, Type = ItemType.Clothes},
            new ClothesModel{ClothesType = ClothesType.Shoes, Color = "Black", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Black Shoes",Size = "39 - 46", Weight = 1.2, Type = ItemType.Clothes},
            // Ball
            new BallModel{BallType = BallType.SoccerBall, Color = "Red", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Red Ball",Diameter = 22, Weight = 0.8, Type = ItemType.Ball},
            new BallModel{BallType = BallType.SoccerBall, Color = "White", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "White Ball",Diameter = 22, Weight = 0.8, Type = ItemType.Ball},
            new BallModel{BallType = BallType.VolleyballBall, Color = "White", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "White Ball",Diameter = 19, Weight = 0.7, Type = ItemType.Ball},
            new BallModel{BallType = BallType.VolleyballBall, Color = "Grey", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Grey Ball",Diameter = 19, Weight = 0.7, Type = ItemType.Ball},
            new BallModel{BallType = BallType.BasketballBall, Color = "Orange", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Orange Ball",Diameter = 27, Weight = 1.3, Type = ItemType.Ball},
            new BallModel{BallType = BallType.BasketballBall, Color = "Yellow&Purple", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Yellow&Purple Ball",Diameter = 27, Weight = 1.3, Type = ItemType.Ball},
            new BallModel{BallType = BallType.BaseballBall, Color = "Grey", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Grey Ball",Diameter = 8, Weight = 0.2, Type = ItemType.Ball},
            new BallModel{BallType = BallType.BaseballBall, Color = "White", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "White Ball",Diameter = 8, Weight = 0.2, Type = ItemType.Ball},
            // SportsAccessories
            new SportsAccessoriesModel{SportsAccessoriesType = SportsAccessoriesType.Stopwatch, Color = "Blue", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Blue Stopwatch", Weight = 0.5, Type = ItemType.SportAccessories},
            new SportsAccessoriesModel{SportsAccessoriesType = SportsAccessoriesType.Stopwatch, Color = "Green", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Green Stopwatch", Weight = 0.5, Type = ItemType.SportAccessories},
            new SportsAccessoriesModel{SportsAccessoriesType = SportsAccessoriesType.BallPump, Color = "Green", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Green Pump", Weight = 0.6, Type = ItemType.SportAccessories},
            new SportsAccessoriesModel{SportsAccessoriesType = SportsAccessoriesType.BallPump, Color = "Blue", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Blue Pump", Weight = 0.6, Type = ItemType.SportAccessories},
            new SportsAccessoriesModel{SportsAccessoriesType = SportsAccessoriesType.Whistle, Color = "Yellow", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Yellow Whistle", Weight = 0.1, Type = ItemType.SportAccessories},
            new SportsAccessoriesModel{SportsAccessoriesType = SportsAccessoriesType.Whistle, Color = "White", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "White Whistle", Weight = 0.1, Type = ItemType.SportAccessories},
            // WinterSports
            // Лыжи
            new WinterSportsModel{WinterSportsType = WinterSportsType.Skiing, Color = "Red", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Red Skiing",Lenght = 1.5, Weight = 1.5, Type = ItemType.WinterSport},
            new WinterSportsModel{WinterSportsType = WinterSportsType.Skiing, Color = "Blue", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Blue Skiing",Lenght = 1.5, Weight = 1.5, Type = ItemType.WinterSport},
            // Санки
            new WinterSportsModel{WinterSportsType = WinterSportsType.Sled, Color = "Green", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Green Sled",Lenght = 0.8, Weight = 2.5, Type = ItemType.WinterSport},
            new WinterSportsModel{WinterSportsType = WinterSportsType.Sled, Color = "Blue", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Blue Sled",Lenght = 0.8, Weight = 2.5, Type = ItemType.WinterSport},
            // Клюшки
            new WinterSportsModel{WinterSportsType = WinterSportsType.Sticks, Color = "Yellow", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Yellow Sticks",Lenght = 1.9, Weight = 1.7, Type = ItemType.WinterSport},
            new WinterSportsModel{WinterSportsType = WinterSportsType.Sticks, Color = "Red", DeliveryTime = new DateTime(2018, 11, 07),
                Name = "Red Sticks",Lenght = 1.9, Weight = 1.7, Type = ItemType.WinterSport},
        };

        private static readonly List<ItemBase> ItemNotFound = new List<ItemBase>
        {
            new ClothesModel{ClothesType = ClothesType.TShirt, Color = "White", DeliveryTime = new  DateTime(2018, 11, 08),
                 Name = "White TShirt",Size = "46 - 56", Weight = 0.5, Type = ItemType.Clothes},
            new ClothesModel{ClothesType = ClothesType.Pants, Color = "Blue", DeliveryTime = new  DateTime(2018, 11, 07),
                 Name = "Blue Pants",Size = "48 - 56", Weight = 0.7, Type = ItemType.Clothes},
            new SportsAccessoriesModel{SportsAccessoriesType = SportsAccessoriesType.Stopwatch, Color = "Blue", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Blue Stopwatch", Weight = 0.5, Type = ItemType.SportAccessories}
        };

        private static readonly List<ItemBase> ItemOutOfStock = new List<ItemBase>
        {
            new WinterSportsModel{WinterSportsType = WinterSportsType.Sled, Color = "Green", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Green Sled",Lenght = 0.8, Weight = 2.5, Type = ItemType.WinterSport},
            new WinterSportsModel{WinterSportsType = WinterSportsType.Sticks, Color = "Yellow", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Yellow Sticks",Lenght = 1.9, Weight = 1.7, Type = ItemType.WinterSport}
        };

        public static double GetStorageCapacity()
        {
            return Stock.Sum(i => i.Weight);
        }

        public static bool AddToStorage(ItemBase item)
        {
            if (GetStorageCapacity() >= MaximumStorageCapacity)
            {
                return false;
            }

            Stock.Add(item);

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
            return ItemOutOfStock.GetRange(0, ItemOutOfStock.Count);
        }

        public static IEnumerable<ItemBase> GetAllItemNotFound()
        {
            return ItemNotFound.GetRange(0, ItemNotFound.Count);
        }
        
        public static void AddToItemNotFound(ItemBase item)
        {
            ItemNotFound.Add(item);
        }

        public static void AddToItemOutOfStock(ItemBase item)
        {
            ItemOutOfStock.Add(item);
        }

        public static bool Sell(ItemBase item)
        {
            if (Stock.Contains(item))
            {
                Stock.Remove(item);

                return true;
            }

            return false;
        }

        public static ItemBase GetItemByIndex(int index)
        {
            return Stock[index];
        }
    }
}
