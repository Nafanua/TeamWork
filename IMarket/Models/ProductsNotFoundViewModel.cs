using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IMarket.Models.Models;

namespace IMarket.Models
{
    public class ProductsNotFoundViewModel
    {
        public IEnumerable<ItemBase> ItemsNotFound { get; set; }
    }
}