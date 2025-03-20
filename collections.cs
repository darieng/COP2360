using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Declare the dictionary globally so it can be accessed in all cases.
    static Dictionary<string, List<string>> myDictionary = new Dictionary<string, List<string>>();

    static void Main()
    {
        bool exit = false;

        // Main loop for the system to operate with.
        while (!exit)
        {
            Console.WriteLine("\n--- Dictionary Menu ---");
            Console.WriteLine("1. Populate Dictionary");
            Console.WriteLine("2. Display Dictionary Contents");
            Console.WriteLine("3. Remove a Key");
            Console.WriteLine("4. Add a New Key and Value");
            Console.WriteLine("5. Add a Value to an Existing Key");
            Console.WriteLine("6. Sort and Display Keys");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice (1-7): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PopulateDictionary();
                    break;
                case "2":
                    DisplayDictionary();
                    break;
                case "3":
                    RemoveKey();
                    break;
                case "4":
                    AddNewKeyValue();
                    break;
                case "5":
                    AddValueToExistingKey();
                    break;
                case "6":
                    SortAndDisplayKeys();
                    break;
                case "7":
                    exit = true;
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select from 1 to 7.");
                    break;
            }
        }
    }

    // a. Populate the Dictionary with sample data
    static void PopulateDictionary()
    {
        myDictionary.Clear();  // Start fresh each time
        myDictionary.Add("Fruit", new List<string> { "Apple", "Banana", "Mango", "Orange", "Kiwi" });
        myDictionary.Add("Vegetable", new List<string> { "Carrot", "Broccoli", "Cabbage", "Eggplant" });
        myDictionary.Add("Beverage", new List<string> { "Water", "Juice", "Soda", "Coffee" });

        Console.WriteLine("Dictionary populated successfully with sample data.");
    }

    // b. Display the dictionary using foreach enumeration
    static void DisplayDictionary()
    {
        if (myDictionary.Count == 0)
        {
            Console.WriteLine("The dictionary is empty.");
            return;
        }

        Console.WriteLine("\n--- Dictionary Contents ---");
        foreach (KeyValuePair<string, List<string>> kvp in myDictionary)
        {
            Console.Write($"{kvp.Key}: ");
            Console.WriteLine(string.Join(", ", kvp.Value));
        }
    }

    // c. Remove a specified key
    static void RemoveKey()
    {
        Console.Write("Enter the key that you would want to remove: ");
        string key = Console.ReadLine();

        if (myDictionary.ContainsKey(key))
        {
            myDictionary.Remove(key);
            Console.WriteLine($"Key '{key}' removal has been successfully.");
        }
        else
        {
            Console.WriteLine($"Key '{key}' This does not exist.");
        }
    }

    // d. Add a new key and value
    static void AddNewKeyValue()
    {
        Console.Write("Enter new key: ");
        string key = Console.ReadLine();

        if (myDictionary.ContainsKey(key))
        {
            Console.WriteLine($"Key '{key}' This already exists. Please use option 5 to add value to it.");
            return;
        }

        Console.Write("Enter the value that needs to be added: ");
        string value = Console.ReadLine();

        myDictionary[key] = new List<string> { value };
        Console.WriteLine($"New key-value pair added: {key} => {value}");
    }

    // e. Add a value to an existing key
    static void AddValueToExistingKey()
    {
        Console.Write("Enter existing key: ");
        string key = Console.ReadLine();

        if (myDictionary.ContainsKey(key))
        {
            Console.Write("Enter the value to add: ");
            string value = Console.ReadLine();
            myDictionary[key].Add(value);
            Console.WriteLine($"Value '{value}' added to key '{key}'.");
        }
        else
        {
            Console.WriteLine($"Key '{key}' does not exist.");
        }
    }

    // f. Sort and display dictionary keys
    static void SortAndDisplayKeys()
    {
        if (myDictionary.Count == 0)
        {
            Console.WriteLine("Dictionary is empty.");
            return;
        }

        Console.WriteLine("\n--- Sorted Dictionary Keys ---");
        var sortedKeys = myDictionary.Keys.OrderBy(k => k).ToList();
        foreach (var key in sortedKeys) 
        {
            Console.WriteLine(key);
        }
    }
}

