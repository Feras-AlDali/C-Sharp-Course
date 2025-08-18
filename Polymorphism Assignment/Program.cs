using System;

namespace ConsoleApp
{
    // Define the interface named IQuittable
    interface IQuittable
    {
        // Declare a method signature for Quit with no return type
        void Quit();
    }

    // Create an Employee class that implements the IQuittable interface
    class Employee : IQuittable
    {
        // Properties for Employee (optional, but shows extensibility)
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Implement the Quit method from the IQuittable interface
        public void Quit()
        {
            // Display a message when an employee "quits"
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }

    // Main program class
    class Program
    {
        // Entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate an Employee object
            Employee emp = new Employee
            {
                FirstName = "John",
                LastName = "Doe"
            };

            // Use polymorphism: assign the Employee object to a variable of type IQuittable
            IQuittable quittableEmp = emp;

            // Call the Quit method using the interface reference
            quittableEmp.Quit();

          
        }
    }
}
