using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square s1 = new Square(5, "blue");
        shapes.Add(s1);

        Circle s2 = new Circle(4.5, "yellow");
        shapes.Add(s2);

        Rectangle s3 = new Rectangle(4.25, 3.75, "purple");
        shapes.Add(s3);

        foreach (Shape s in shapes) {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape's area is {area}.");
        }

    }
}