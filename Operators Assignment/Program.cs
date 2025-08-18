using System;

namespace ConsoleApp
{
    // Define the Employee class
    class Employee
    {
        // Employee Id property
        public int Id { get; set; }

        // First name property
        public string FirstName { get; set; }

        // Last name property
        public string LastName { get; set; }

        // Overload the '==' operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check for nulls to avoid NullReferenceException
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare the Ids of the two Employee objects
            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator (must be done in pairs with '==')
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Use the overloaded '==' operator and invert the result
            return !(emp1 == emp2);
        }

        // It's good practice to also override Equals() when overloading ==
        public override bool Equals(object obj)
        {
            if (obj is Employee emp)
                return this.Id == emp.Id;
            return false;
        }

        // Also override GetHashCode when overriding Equals
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    // Main program class
    class Program
    {
        // Entry point of the console application
        static void Main(string[] args)
        {
            // Create the first Employee object and assign values
            Employee emp1 = new Employee
            {
                Id = 101,
                FirstName = "Feras",
                LastName = "AlDali"
            };

            // Create the second Employee object and assign values
            Employee emp2 = new Employee
            {
                Id = 105, // Same Id as emp1 to test equality
                FirstName = "Bob",
                LastName = "Smith"
            };

            // Compare the two Employee objects using the overloaded '=='
            bool areEqual = emp1 == emp2;

            // Display the result of the comparison
            Console.WriteLine("Are the two employees equal (by Id)? " + areEqual);

            // Also demonstrate the use of '!=' operator
            bool areNotEqual = emp1 != emp2;
            Console.WriteLine("Are the two employees NOT equal (by Id)? " + areNotEqual);

          
        }
    }
}
