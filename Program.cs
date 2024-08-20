using System;

namespace BasicIOApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output a welcome message to the console
            Console.WriteLine("Welcome to the Basic Input/Output Console Application!");

            // Prompt the user to enter their name
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            // Output a personalized greeting
            Console.WriteLine($"Hello, {name}! Nice to meet you.");

            // Prompt the user to enter their age
            Console.Write("Please enter your age: ");
            string ageInput = Console.ReadLine();
            int age;

            // Try to parse the input to an integer and handle any potential errors
            if (int.TryParse(ageInput, out age))
            {
                Console.WriteLine($"You are {age} years old.");
            }
            else
            {
                Console.WriteLine("Invalid input for age. Please enter a valid number.");
            }

            // Pause the application to keep the console open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
