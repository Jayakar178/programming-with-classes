public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public Rectangle(string color, double width, double height) : base(color)
    {
        _width = width;
        _height = height;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a {_color} rectangle with width {_width} and height {_height}.");
    }
}
