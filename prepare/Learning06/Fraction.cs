using System;

public class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction(int top, int bottom)
    {
        numerator = top;
        SetDenominator(bottom);
    }

    public void SetDenominator(int value)
    {
        if (value != 0)
        {
            denominator = value;
        }
    }

    public int GetNumerator()
    {
        return numerator;
    }

    public int GetDenominator()
    {
        return denominator;
    }
}
