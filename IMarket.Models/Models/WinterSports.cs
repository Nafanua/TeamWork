﻿using IMarket.Models.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMarket.Models.Models
{
    class WinterSports:ItemBase
    {
        public WinterSportsType WinterSportsType { get; set; }

        public double Lenght { get; set; }
    }
}