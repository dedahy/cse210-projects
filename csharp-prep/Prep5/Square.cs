public class Square : Shape
{
    private double _side;

    public Square(string colors, double side) : base (colors)
    {
        _side = side;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return _side * _side;
    }
}