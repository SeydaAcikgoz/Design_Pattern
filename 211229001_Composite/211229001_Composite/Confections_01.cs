﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Composite
{
    public class Confections_01 : ProductObject_01
    {
        public Confections_01(int code, string ProductName, string category, int Stock, double Price) : base(code, ProductName, category, Stock, Price)
        {
        }
    }
}
