using IMarket.Models.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMarket.Models.Models
{
    public class WinterSportsModel :ItemBase
    {
        public double Lenght { get; set; }

        public WinterSportsModel(ConcreteType concreteType)
            : base(concreteType)
        {
        }
    }
}
