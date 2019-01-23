using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IMarket.Models.Models;

namespace IMarket.Models
{
    public class StockViewModel
    {
        public IEnumerable<IGrouping<string, ItemBase>> Items { get; set; }

        public int ItemsCount { get; set; }

        public double ItemsWeight { get; set; }

        public double MaxWeight { get; set; }
    }
}