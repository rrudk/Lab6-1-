﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1_
{
    public class Circle : Shape
    {
        public double R { get; set; }

        public Circle(double r)
        {
            R = r;
        }

        public override double GetArea()
        {
            return Math.PI * R * R;
        }
    }
}
