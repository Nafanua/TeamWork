using IMarket.Models.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMarket.Models.Models
{
    class Ball:ItemBase
    {
        public BallType BallType { get; set; }

        public int Diameter { get; set; }
    }
}
