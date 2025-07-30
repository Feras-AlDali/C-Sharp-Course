using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt and read weight
        Console.Write("Please enter the package weight: ");
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // Check if weight is too heavy
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Prompt and read dimensions
        Console.Write("Please enter the package width: ");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Please enter the package height: ");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Please enter the package length: ");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Check if total dimensions exceed limit
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate the shipping quote
        decimal quote = (width * height * length * weight) / 100;

        // Display quote with 2 decimal places
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:0.00}");
        Console.WriteLine("Thank you!");
    }
}
