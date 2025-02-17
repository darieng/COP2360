// Octopus.cs
using System;

public class Octopus
{
    // Fields
    public readonly string Name;
    public int Age { get; set; } = 2; // Automatic property with initializer
    public static readonly int Legs = 8; // Static readonly field
    public const string Species = "Octopus vulgaris"; // Constant

    // Constructor Overloading
    public Octopus(string name) => Name = name;

    public Octopus(string name, int age) : this(name)
    {
        Age = age;
    }

    // Expression-bodied Method
    public void Swim() => Console.WriteLine($"{Name} is swimming with {Legs} legs!");

    // Local Method Example
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age} years");
        Console.WriteLine($"Species: {Species}");

        // Local method defined inside ShowInfo
        void DisplayHabitat()
        {
            Console.WriteLine($"{Name} lives in the ocean.");
        }
        DisplayHabitat();
    }
}

class Program
{
    static void Main()
    {
        // Object Initializers
        Octopus o1 = new Octopus("Inky") { Age = 5 };
        Octopus o2 = new Octopus("Bluey", 3);

        // Call methods
        o1.Swim();
        o1.ShowInfo();

        o2.Swim();
        o2.ShowInfo();
    }
}
