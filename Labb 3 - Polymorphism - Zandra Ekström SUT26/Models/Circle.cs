using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Polymorphism___Zandra_Ekström_SUT26.Models
{
    public class Circle : Geometry
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
