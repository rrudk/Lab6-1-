using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1_
{
    public class Square : Shape
    {
        public double A { get; set; }

        public Square(double a)
        {
            A = a;
        }

        public override double GetArea()
        {
            return A * A;
        }
    }
}
