using IMarket.Models.Models;
using System.Collections.Generic;

namespace IMarket.DAL
{
    public static class Storage
    {
        public static IEnumerable<ItemBase> Stock = new List<ItemBase>();
    }
}
