﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class Araba : IYakitTuketimi
    {
        public string Model { get; set; }
        public abstract double YakitTuketimiHesapla();
    }
}
