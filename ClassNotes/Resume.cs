using System;
using System.Collections.Generic;

public class Resume
{
    public string Name { get; set; }
    public List<Job> Jobs { get; set; } = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in Jobs)
        {
            job.Display();
        }
    }
}
