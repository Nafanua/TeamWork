using System;
using System.Collections.Generic;
using IMarket.Models.Models.Enums;

namespace IMarket.Models.Models
{
    public class ViewModelListItem
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public string DeliveryTime { get; set; }

        public string Type { get; set; }

        public int Count { get; set; }
    }
}