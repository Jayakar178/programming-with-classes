public class Shape
{
    protected string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }

    public string GetColor()
    {
        return _color;
    }
}
