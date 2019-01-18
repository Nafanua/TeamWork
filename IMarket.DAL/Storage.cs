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
        private static readonly List<ItemBase> Stock = new List<ItemBase> {
            // Clothes
            new ClothesModel{ClothesType = ClothesType.TShirt, Color = "White", DeliveryTime = new  DateTime(2018, 11, 07),
                Material = "Cotton", Name = "White TShirt", Price = 80, Size = "46 - 56", Weight = 0.5, Type = ItemType.Clothes},
            new ClothesModel{ClothesType = ClothesType.TShirt, Color = "Black", DeliveryTime = new  DateTime(2018, 11, 07),
                Material = "Cotton", Name = "Black TShirt", Price = 80, Size = "48 - 56", Weight = 0.5, Type = ItemType.Clothes},
            new ClothesModel{ClothesType = ClothesType.TShirt, Color = "Blue", DeliveryTime = new  DateTime(2018, 11, 07),
                Material = "Cotton", Name = "Blue TShirt", Price = 80, Size = "48 - 56", Weight = 0.5, Type = ItemType.Clothes},
            new ClothesModel{ClothesType = ClothesType.Pants, Color = "White", DeliveryTime = new  DateTime(2018, 11, 07),
                Material = "Cotton", Name = "White Pants", Price = 180, Size = "46 - 56", Weight = 0.7, Type = ItemType.Clothes},
            new ClothesModel{ClothesType = ClothesType.Pants, Color = "Black", DeliveryTime = new  DateTime(2018, 11, 07),
                Material = "Cotton", Name = "Black Pants", Price = 180, Size = "48 - 56", Weight = 0.7, Type = ItemType.Clothes},
            new ClothesModel{ClothesType = ClothesType.Pants, Color = "Blue", DeliveryTime = new  DateTime(2018, 11, 07),
                Material = "Cotton", Name = "Blue Pants", Price = 180, Size = "48 - 56", Weight = 0.7, Type = ItemType.Clothes},
            new ClothesModel{ClothesType = ClothesType.Shoes, Color = "White", DeliveryTime = new  DateTime(2018, 11, 07),
                Material = "Skin", Name = "White Shoes", Price = 230, Size = "37 - 45", Weight = 1.2, Type = ItemType.Clothes},
            new ClothesModel{ClothesType = ClothesType.Shoes, Color = "Red", DeliveryTime = new  DateTime(2018, 11, 07),
                Material = "Skin", Name = "Red Shoes", Price = 230, Size = "39 - 46", Weight = 1.2, Type = ItemType.Clothes},
            new ClothesModel{ClothesType = ClothesType.Shoes, Color = "Black", DeliveryTime = new  DateTime(2018, 11, 07),
                Material = "Skin", Name = "Black Shoes", Price = 230, Size = "39 - 46", Weight = 1.2, Type = ItemType.Clothes},
            // Ball
            new BallModel{BallType = BallType.SoccerBall, Price = 330, Color = "Red", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Red Ball",Diameter = 22, Weight = 0.8, Type = ItemType.Ball},
            new BallModel{BallType = BallType.SoccerBall, Price = 330, Color = "White", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "White Ball",Diameter = 22, Weight = 0.8, Type = ItemType.Ball},
            new BallModel{BallType = BallType.VolleyballBall, Price = 330, Color = "White", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "White Ball",Diameter = 19, Weight = 0.7, Type = ItemType.Ball},
            new BallModel{BallType = BallType.VolleyballBall, Price = 300, Color = "Grey", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Grey Ball",Diameter = 19, Weight = 0.7, Type = ItemType.Ball},
            new BallModel{BallType = BallType.BasketballBall, Price = 320, Color = "Orange", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Orange Ball",Diameter = 27, Weight = 1.3, Type = ItemType.Ball},
            new BallModel{BallType = BallType.BasketballBall, Price = 380, Color = "Yellow&Purple", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Yellow&Purple Ball",Diameter = 27, Weight = 1.3, Type = ItemType.Ball},
            new BallModel{BallType = BallType.BaseballBall, Price = 180, Color = "Grey", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Grey Ball",Diameter = 8, Weight = 0.2, Type = ItemType.Ball},
            new BallModel{BallType = BallType.BaseballBall, Price = 180, Color = "White", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "White Ball",Diameter = 8, Weight = 0.2, Type = ItemType.Ball},
            // SportsAccessories
            new SportsAccessoriesModel{SportsAccessoriesType = SportsAccessoriesType.Stopwatch, Price = 530, Color = "Blue", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Blue Stopwatch", Weight = 0.5, Type = ItemType.SportAccessories},
            new SportsAccessoriesModel{SportsAccessoriesType = SportsAccessoriesType.Stopwatch, Price = 530, Color = "Green", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Green Stopwatch", Weight = 0.5, Type = ItemType.SportAccessories},
            new SportsAccessoriesModel{SportsAccessoriesType = SportsAccessoriesType.BallPump, Price = 230, Color = "Green", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Green Pump", Weight = 0.6, Type = ItemType.SportAccessories},
            new SportsAccessoriesModel{SportsAccessoriesType = SportsAccessoriesType.BallPump, Price = 230, Color = "Blue", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Blue Pump", Weight = 0.6, Type = ItemType.SportAccessories},
            new SportsAccessoriesModel{SportsAccessoriesType = SportsAccessoriesType.Whistle, Price = 70, Color = "Yellow", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Yellow Whistle", Weight = 0.1, Type = ItemType.SportAccessories},
            new SportsAccessoriesModel{SportsAccessoriesType = SportsAccessoriesType.Whistle, Price = 70, Color = "White", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "White Whistle", Weight = 0.1, Type = ItemType.SportAccessories},
            // WinterSports
            // Лыжи
            new WinterSportsModel{WinterSportsType = WinterSportsType.Skiing, Price = 590, Color = "Red", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Red Skiing",Lenght = 1.5, Weight = 1.5, Type = ItemType.WinterSport},
            new WinterSportsModel{WinterSportsType = WinterSportsType.Skiing, Price = 640, Color = "Blue", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Blue Skiing",Lenght = 1.5, Weight = 1.5, Type = ItemType.WinterSport},
            // Санки
            new WinterSportsModel{WinterSportsType = WinterSportsType.Sled, Price = 420, Color = "Green", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Green Sled",Lenght = 0.8, Weight = 2.5, Type = ItemType.WinterSport},
            new WinterSportsModel{WinterSportsType = WinterSportsType.Sled, Price = 700, Color = "Blue", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Blue Sled",Lenght = 0.8, Weight = 2.5, Type = ItemType.WinterSport},
            // Клюшки
            new WinterSportsModel{WinterSportsType = WinterSportsType.Sticks, Price = 310, Color = "Yellow", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Yellow Sticks",Lenght = 1.9, Weight = 1.7, Type = ItemType.WinterSport},
            new WinterSportsModel{WinterSportsType = WinterSportsType.Sticks, Price = 270, Color = "Red", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Red Sticks",Lenght = 1.9, Weight = 1.7, Type = ItemType.WinterSport},
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
    }
}
