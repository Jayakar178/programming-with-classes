using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Address addr = new Address("123 Main St", "Rexburg", "ID", "USA");

        Event lecture = new Lecture("C# Seminar", "Learn C# from a pro", "Aug 10", "10:00 AM", addr, "Dr. Smith", 100);
        Event reception = new Reception("Networking Night", "Meet and greet", "Aug 11", "6:00 PM", addr, "rsvp@example.com");
        Event outdoor = new OutdoorGathering("Summer Picnic", "Fun in the sun", "Aug 12", "12:00 PM", addr, "Sunny, 75°F");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (var e in events)
        {
            Console.WriteLine("STANDARD:");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine("\nFULL:");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine("\nSHORT:");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine("\n----------------------\n");
        }
    }
}
