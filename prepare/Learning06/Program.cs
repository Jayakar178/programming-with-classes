using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction myFraction = new Fraction(3, 4);
        Console.WriteLine("Numerator: " + myFraction.GetNumerator());
        Console.WriteLine("Denominator: " + myFraction.GetDenominator());

        myFraction.SetDenominator(0);  // This should be ignored
        Console.WriteLine("After trying to set denominator to 0:");
        Console.WriteLine("Denominator: " + myFraction.GetDenominator());
    }
}
