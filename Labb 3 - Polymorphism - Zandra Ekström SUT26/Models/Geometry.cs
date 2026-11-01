using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Polymorphism___Zandra_Ekström_SUT26.Models
{

    // Abstract so that we can´t create a geometry object.
    // A geometry isn´t a shape but an idea or category.
    // Parentclass for circle, rectangle and square.
    public abstract class Geometry
    {

        // Geometry doesn’t know how to calculate the area,
        // but it determines that all shapes need an area.
        // So all the child classes create their own version with override.

        public abstract double Area();
        
                
    }
}
