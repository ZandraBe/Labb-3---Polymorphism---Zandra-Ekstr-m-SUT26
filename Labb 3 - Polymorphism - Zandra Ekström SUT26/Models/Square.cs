using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Polymorphism___Zandra_Ekström_SUT26.Models
{
    public class Square : Geometry
    {
        public double Side { get; set; }

        public Square()
        {
            Side = 8;
        }


        // To calculate the area of a square: side * side.
        public override double Area()
        {
            return Side * Side;
        }
    }
}
