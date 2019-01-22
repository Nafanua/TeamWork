using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IMarket.Models.Models;

namespace IMarket.Models
{
    public class ProductsNoPlaceInStockViewModel
    {
        public IEnumerable<ItemBase> ItemsOutOfStock { get; set; }
    }
}