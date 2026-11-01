using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Polymorphism___Zandra_Ekström_SUT26.Models
{
    public class Rectangle : Geometry
    {

        // Needs two properties because the width and height can be different in a rectangle. 
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
            Width = 4;
            Height = 5.92;
        }


        // To calculate the area of a rectangle: width * height.
        public override double Area()
        {
            return Width * Height;
        }
    }
}
