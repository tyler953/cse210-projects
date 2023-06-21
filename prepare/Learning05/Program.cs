using System;

namespace Learning05
{
    class Program
    {
        static void Main()
        {
            Square square = new Square("Red", 5.0);
            Rectangle rectangle = new Rectangle("Blue", 6.0, 3.0);
            Circle circle = new Circle("Green", 3.6);

            List<Shape> shapes = new List<Shape>();
            shapes.Add(square);
            shapes.Add(rectangle);
            shapes.Add(circle);

            foreach (Shape item in shapes)
            {
                Console.WriteLine(item.GetColor());
                Console.WriteLine(item.GetArea());
            }
        }
    }
}