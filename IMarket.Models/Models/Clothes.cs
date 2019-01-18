using IMarket.Models.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMarket.Models.Models
{
    class Clothes:ItemBase
    {
        public ClothesType ClothesType { get; set; }

        public int Size { get; set; }

        public string Material { get; set; }
    }
}
