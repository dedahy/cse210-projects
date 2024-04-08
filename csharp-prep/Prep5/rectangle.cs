public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string colors, double length, double width) : base (colors)
    {
        _length = length;
        _width = width;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return _length * _width;
    }
}