using Labb_3___Polymorphism___Zandra_Ekström_SUT26.Models;

namespace Labb_3___Polymorphism___Zandra_Ekström_SUT26
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create objects
            Circle circle = new Circle(5);
            Square square = new Square(4);
            Rectangle rectangle = new Rectangle(6, 3);

            // Calculate areas
            Console.WriteLine($"Circle area: {circle.Area():F2}");
            Console.WriteLine($"Square area: {square.Area():F2}");
            Console.WriteLine($"Rectangle area: {rectangle.Area():F2}");

            Console.WriteLine();

            // Polymorphism
            Geometry[] shapes = { circle, square, rectangle };

            foreach (Geometry shape in shapes)
            {
                Console.WriteLine($"Area: {shape.Area():F2}");
            }

            Console.ReadKey();
        }
    }
}
