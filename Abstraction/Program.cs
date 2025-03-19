using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Shape
    {
        // Abstract method (no implementation)
        public abstract double CalculateArea();

        // Concrete method (has implementation)
        public void DisplayShapeType()
        {
            Console.WriteLine($"This is a {this.GetType().Name}.");
        }
    }

    // Derived class representing a Circle
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Implementation of the abstract method
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class representing a Rectangle
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Implementation of the abstract method
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Cannot create an instance of an abstract class directly:
            // Shape myShape = new Shape(); // This would cause a compile-time error.

            Circle myCircle = new Circle(5);
            Rectangle myRectangle = new Rectangle(4, 6);

            myCircle.DisplayShapeType();
            Console.WriteLine($"Circle Area: {myCircle.CalculateArea()}");

            myRectangle.DisplayShapeType();
            Console.WriteLine($"Rectangle Area: {myRectangle.CalculateArea()}");

            //Abstraction example using an array of shapes.
            Shape[] shapes = new Shape[2];
            shapes[0] = myCircle;
            shapes[1] = myRectangle;

            foreach (Shape s in shapes)
            {
                s.DisplayShapeType();
                Console.WriteLine($"Area: {s.CalculateArea()}");
            }
        }
    }
}
