using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Polymorphism___Zandra_Ekström_SUT26.Models
{
    public class Circle : Geometry
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 4;
        }


        // Override replaces the parentclass method geometry Area().
        // Every shape needs a different version since
        // the area is calculated differently for different shapes.
     
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
