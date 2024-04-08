using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        //Square s = new Square("black", 2);
        //Rectangle r = new Rectangle("Red", 2, 4);
//
        //Console.WriteLine(s.GetArea());
        //Console.WriteLine(r.GetArea());

        Square s = new Square("black", 2);
        Rectangle r = new Rectangle("Red", 2, 4);
        Circle c = new Circle("Yellow", 3);


        shapes.Add(s);
        shapes.Add(r);
        shapes.Add(c);

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}