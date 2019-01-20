using System;
using IMarket.Models.Models.Enums;

namespace IMarket.Models.Models
{
    public abstract class ItemBase
    {
        public string Name { get; set; }

        public DateTime DeliveryTime { get; set; }

        public DateTime SellingTime { get; set; }

        public ItemType Type { get; set; }

        public double Weight { get; set; }

        public int Quantity { get; set; }

        public string Color { get; set; }

        public string Description { get; set; }
    }
}