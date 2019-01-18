
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
            new Clothes{ClothesType = ClothesType.TShirt, Color = "White", DeliveryTime = new  DateTime(2018, 11, 07),
                Material = "Cotton", Name = "White TShirt",Size = "46 - 56", Weight = 0.5},
            new Clothes{ClothesType = ClothesType.TShirt, Color = "Black", DeliveryTime = new  DateTime(2018, 11, 07),
                Material = "Cotton", Name = "Black TShirt",Size = "48 - 56", Weight = 0.5},
            new Clothes{ClothesType = ClothesType.TShirt, Color = "Blue", DeliveryTime = new  DateTime(2018, 11, 07),
                Material = "Cotton", Name = "Blue TShirt",Size = "48 - 56", Weight = 0.5},
            new Clothes{ClothesType = ClothesType.Pants, Color = "White", DeliveryTime = new  DateTime(2018, 11, 07),
                Material = "Cotton", Name = "White Pants",Size = "46 - 56", Weight = 0.7},
            new Clothes{ClothesType = ClothesType.Pants, Color = "Black", DeliveryTime = new  DateTime(2018, 11, 07),
                Material = "Cotton", Name = "Black Pants",Size = "48 - 56", Weight = 0.7},
            new Clothes{ClothesType = ClothesType.Pants, Color = "Blue", DeliveryTime = new  DateTime(2018, 11, 07),
                Material = "Cotton", Name = "Blue Pants",Size = "48 - 56", Weight = 0.7},
            new Clothes{ClothesType = ClothesType.Shoes, Color = "White", DeliveryTime = new  DateTime(2018, 11, 07),
                Material = "Skin", Name = "White Shoes",Size = "37 - 45", Weight = 1.2},
            new Clothes{ClothesType = ClothesType.Shoes, Color = "Red", DeliveryTime = new  DateTime(2018, 11, 07),
                Material = "Skin", Name = "Red Shoes",Size = "39 - 46", Weight = 1.2},
            new Clothes{ClothesType = ClothesType.Shoes, Color = "Black", DeliveryTime = new  DateTime(2018, 11, 07),
                Material = "Skin", Name = "Black Shoes",Size = "39 - 46", Weight = 1.2},
            // Ball
            new Ball{BallType = BallType.SoccerBall, Color = "Red", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Red Ball",Diameter = 22, Weight = 0.8},
            new Ball{BallType = BallType.SoccerBall, Color = "White", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "White Ball",Diameter = 22, Weight = 0.8},
            new Ball{BallType = BallType.VolleyballBall, Color = "White", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "White Ball",Diameter = 19, Weight = 0.7},
            new Ball{BallType = BallType.VolleyballBall, Color = "Grey", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Grey Ball",Diameter = 19, Weight = 0.7},
            new Ball{BallType = BallType.BasketballBall, Color = "Orange", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Orange Ball",Diameter = 27, Weight = 1.3},
            new Ball{BallType = BallType.BasketballBall, Color = "Yellow&Purple", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Yellow&Purple Ball",Diameter = 27, Weight = 1.3},
            new Ball{BallType = BallType.BaseballBall, Color = "Grey", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Grey Ball",Diameter = 8, Weight = 0.2},
            new Ball{BallType = BallType.BaseballBall, Color = "White", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "White Ball",Diameter = 8, Weight = 0.2},
            // SportsAccessories
            new SportsAccessories{SportsAccessoriesType = SportsAccessoriesType.Stopwatch, Color = "Blue", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Blue Stopwatch", Weight = 0.5},
            new SportsAccessories{SportsAccessoriesType = SportsAccessoriesType.Stopwatch, Color = "Green", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Green Stopwatch", Weight = 0.5},
            new SportsAccessories{SportsAccessoriesType = SportsAccessoriesType.BallPump, Color = "Green", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Green Pump", Weight = 0.6},
            new SportsAccessories{SportsAccessoriesType = SportsAccessoriesType.BallPump, Color = "Blue", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Blue Pump", Weight = 0.6},
            new SportsAccessories{SportsAccessoriesType = SportsAccessoriesType.Whistle, Color = "Yellow", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Yellow Whistle", Weight = 0.1},
            new SportsAccessories{SportsAccessoriesType = SportsAccessoriesType.Whistle, Color = "White", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "White Whistle", Weight = 0.1},
            // WinterSports
            // Лыжи
            new WinterSports{WinterSportsType = WinterSportsType.Skiing, Color = "Red", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Red Skiing",Lenght = 1.5, Weight = 1.5},
            new WinterSports{WinterSportsType = WinterSportsType.Skiing, Color = "Blue", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Blue Skiing",Lenght = 1.5, Weight = 1.5},
            // Санки
            new WinterSports{WinterSportsType = WinterSportsType.Sled, Color = "Green", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Green Sled",Lenght = 0.8, Weight = 2.5},
            new WinterSports{WinterSportsType = WinterSportsType.Sled, Color = "Blue", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Blue Sled",Lenght = 0.8, Weight = 2.5},
            // Клюшки
            new WinterSports{WinterSportsType = WinterSportsType.Sticks, Color = "Yellow", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Yellow Sticks",Lenght = 1.9, Weight = 1.7},
            new WinterSports{WinterSportsType = WinterSportsType.Sticks, Color = "Red", DeliveryTime = new  DateTime(2018, 11, 07),
                Name = "Red Sticks",Lenght = 1.9, Weight = 1.7},
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
