using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator Program");

        Calculator calculator = new Calculator();
        int result = calculator.AddNumbers(5, 7);

        Console.WriteLine("The sum is: " + result);
    }
}
