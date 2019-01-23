using IMarket.Models.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMarket.Models.Models
{
    public static class WeightBalance
    {
        static public readonly Dictionary<ConcreteType, double> Weight = new Dictionary<ConcreteType, double>() {
            { ConcreteType.SoccerBall, 0.7 },
            { ConcreteType.VolleyballBall, 0.5 },
            { ConcreteType.BasketballBall, 1.2 },
            { ConcreteType.BaseballBall, 0.3 },
            { ConcreteType.TShirt, 0.1},
            { ConcreteType.Pants, 0.4},
            { ConcreteType.Shoes, 0.8},
            { ConcreteType.Stopwatch, 0.1},
            { ConcreteType.BallPump, 0.3},
            { ConcreteType.Whistle, 0.7},
            { ConcreteType.Skiing, 1.7},
            { ConcreteType.Sled, 2.5},
            { ConcreteType.Sticks, 1.2}
            };
    }
}
