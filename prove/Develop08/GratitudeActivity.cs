using System;
using System.Collections.Generic;

public class GratitudeActivity : MindfulnessActivity
{
    public GratitudeActivity() 
        : base("Gratitude Activity", "Take a moment to write down three things you're grateful for.") 
    { }

    public void Run()
    {
        StartMessage();

        List<string> responses = new List<string>();
        Console.WriteLine("\nWrite down three things you're grateful for:");

        for (int i = 1; i <= 3; i++)
        {
            Console.Write($"  {i}. ");
          string? input = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(input))
        {
            responses.Add(input);
        }
else
{
    responses.Add("(empty)");
}

        }

        Console.WriteLine("\nThank you for reflecting!");
        Console.WriteLine("You entered:");
        foreach (var item in responses)
        {
            Console.WriteLine($"- {item}");
        }

        EndMessage();
    }
}
