using IMarket.Models.Models.Enums;
using System;

namespace IMarket.Models.Models
{
    public abstract class ItemBase
    {
        public string Name { get; set; }

        public DateTime DeliveryTime { get; set; }

        public DateTime SellingTime { get; set; }

        public GeneralType Type { get; set; }

        public double Weight { get; private set; }

        public Color Color { get; set; }

        public string Description { get; set; }

        public ConcreteType ConcreteType { get; set; }

        public ItemBase(ConcreteType concreteType)
        {
            WeightInit(concreteType);
        }

        private void WeightInit(ConcreteType concreteType)
        {
            Weight = WeightBalance.Weight[concreteType];
        }
    }
}