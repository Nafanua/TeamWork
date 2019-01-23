using IMarket.Models.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMarket.Models.Models
{
    public class BallModel :ItemBase
    {
        public int Diameter { get; set; }
        public BallModel(ConcreteType concreteType)
            :base(concreteType)
        {
        }
    }
}
