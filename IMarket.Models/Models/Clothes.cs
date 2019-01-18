using IMarket.Models.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMarket.Models.Models
{
    public class Clothes :ItemBase
    {
        public ClothesType ClothesType { get; set; }

        public string Size { get; set; }

        public string Material { get; set; }
    }
}
