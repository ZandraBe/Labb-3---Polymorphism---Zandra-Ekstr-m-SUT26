using Labb_3___Polymorphism___Zandra_Ekström_SUT26.Models;

namespace Labb_3___Polymorphism___Zandra_Ekström_SUT26
{
    class Program
    {
        static void Main(string[] args)
        {
            // Each variable is a geometry and the object is a circle, square or rectangle.
            // This means that the program can treat all the objects the same.

            Geometry circle = new Circle();
            Geometry square = new Square();
            Geometry rectangle = new Rectangle();
                    
                  
            Geometry[] shapes = { circle, square, rectangle };


            // The varibles states that this is som kind of geometry.
            // C# looks at the object and see that its a circle, square or rectangle
            // and runs the correct override. This is called late binding.

            foreach (Geometry shape in shapes)
            {

                // Gettype sees that the object is a circle, square or rectangle
                // and the variable Geometry dosen´t change the object.
                //I am using Math.Round instead of F2 because F2 always show 2 decimals,
                //but Math.Round rounds off to maximum 2 decimals.
                Console.WriteLine($"Area of {shape.GetType().Name}: {Math.Round(shape.Area(), 2)}");
            }


            Console.ReadKey();
        }
    }
}
