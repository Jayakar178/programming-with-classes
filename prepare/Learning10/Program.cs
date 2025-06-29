using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>
        {
            new Dog(),
            new Cat(),
            new Cow()
        };

        foreach (Animal a in animals)
        {
            a.MakeSound(); // Polymorphism at work
        }
    }
}
