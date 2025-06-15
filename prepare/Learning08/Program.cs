class Program
{
    static void Main(string[] args)
    {
        Shape myCircle = new Circle("blue", 5.0);
        Shape myRectangle = new Rectangle("red", 4.0, 6.0);

        myCircle.Draw();
        myRectangle.Draw();
    }
}
