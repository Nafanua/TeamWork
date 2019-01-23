using System.Collections.Generic;
using IMarket.Models.Models;

namespace IMarket.Models
{
    public class StockViewModel
    {
        public IEnumerable<ViewModelListItem> Items { get; set; }

        public int ItemsCount { get; set; }

        public double ItemsWeight { get; set; }

        public double MaxWeight { get; set; }
    }
}