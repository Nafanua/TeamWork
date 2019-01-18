using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IMarket.Models.Enums;

namespace IMarket.Models
{
    public class ItemBase
    {
        public string Name { get; set; }

        public DateTime DeliveryTime { get; set; }

        public DateTime SellingTime { get; set; }

        public int Weight { get; set; }

        public ItemType Type { get; set; }
    }
}