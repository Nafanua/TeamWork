using System;
using IMarket.Models.Models.Enums;

namespace IMarket.Models.Models
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