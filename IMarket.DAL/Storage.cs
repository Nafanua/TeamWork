using System;
using IMarket.Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace IMarket.DAL
{
    public static class Storage
    {
        private const double MaximumStorageCapacity = 1000;

        private static readonly List<ItemBase> Stock = new List<ItemBase>();

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
    }
}
