using System;

namespace ConsoleApp
{
    // Define a class named MyClass
    class MyClass
    {
        // This method takes two integers and performs a math operation
        public void DoMath(int firstNumber, int secondNumber)
        {
            // Multiply the first number by 2 and print the result
            int result = firstNumber * 2;
            Console.WriteLine("The result of the math operation (firstNumber * 2): " + result);

            // Display the second number
            Console.WriteLine("The second number is: " + secondNumber);
        }
    }

    // Main class where the program starts
    class Program
    {
        // Main method is the entry point of the application
        static void Main(string[] args)
        {
            // Instantiate the class MyClass
            MyClass myObject = new MyClass();

            // Call the method using positional arguments (in order)
            myObject.DoMath(3, 6); // 5 is firstNumber, 10 is secondNumber

            // Call the method again using named arguments
            myObject.DoMath(firstNumber: 9, secondNumber: 12);

            // Wait for the user to press a key before closing (optional for readability)
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
