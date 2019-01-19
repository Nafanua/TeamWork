using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IMarket.Models.Models;

namespace IMarket.Models
{
    public class StockViewModel
    {
        public IEnumerable<ItemBase> Items { get; set; }

        public IEnumerable<ItemBase> ItemsOutOfStock { get; set; }

        public IEnumerable<ItemBase> ItemsNotFound { get; set; }

        public int ItemsCount { get; set; }
    }
}