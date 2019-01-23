using System;
using System.Collections.Generic;
using IMarket.Models.Models.Enums;

namespace IMarket.Models.Models
{
    public class ViewModelListItem
    {
        public string Name { get; set; }

        public Color Color { get; set; }

        public DateTime DeliveryTime { get; set; }

        public ItemType Type { get; set; }

        public int Count { get; set; }
    }
}