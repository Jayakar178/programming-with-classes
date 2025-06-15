public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a {_color} circle with radius {_radius}.");
    }
}
