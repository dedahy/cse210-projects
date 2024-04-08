public abstract class Shape
{
    private string _colors;

    public Shape(string color)
    {
        _colors = color;
    }

    public string GetColor()
    {
        return _colors;
    }

    public void SetColor(string color)
    {
        _colors = color;
    }
    public abstract double GetArea();
}