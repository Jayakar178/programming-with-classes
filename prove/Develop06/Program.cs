// Jayakar Peddeli - W06 Develop: Scripture Memorizer
// This program uses proper encapsulation with three custom classes: Scripture, Reference, and Word.
// Each class handles its own responsibilities, and all data members are private with _camelCase naming.

// Creative enhancements:
// - Includes a library of scripture passages (from Proverbs and Sirach)
// - Randomly selects a verse when the program starts
// - Hides only words that are still visible, improving the memorization experience
// - Supports both single and multi-verse references

using System;
using System.Collections.Generic;

class Program

{
    static void Main(string[] args)
    {


        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart, and do not lean on your own understanding. In all your ways acknowledge him, and he will make straight your paths."
            ),
            new Scripture(
                new Reference("Proverbs", 9, 10),
                "The fear of the Lord is the beginning of wisdom, and the knowledge of the Holy One is insight."
            ),
            new Scripture(
                new Reference("Sirach", 2, 1, 2),
                "My child, when you come to serve the Lord, prepare yourself for testing. Set your heart right and be steadfast, and do not be impetuous in time of calamity."
            ),
            new Scripture(
                new Reference("Sirach", 4, 28),
                "Do not hesitate to speak in a time of trouble, for it is not right to hide your wisdom."
            ),
            new Scripture(
                new Reference("Sirach", 1, 27),
                "The fear of the Lord is wisdom and discipline, and what is acceptable to him is faith and meekness."
            )
        };


        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];


        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine().Trim().ToLower();
            if (input == "quit" || scripture.IsCompletelyHidden())
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.WriteLine("\nThanks for using the Scripture Memorizer!");
    }
}
