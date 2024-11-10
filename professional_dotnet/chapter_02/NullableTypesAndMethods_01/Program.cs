// Program to demonstrate Nullable Types And Methods in C# with Visual Studio
// Programmer:Srushti Battise


namespace NullableTypesAndMethods_01
{
    using System;

    public class Program
    {
        // Method that takes a nullable integer as a parameter.
        public static void CheckAge(int? age)
        {
            // Using a conditional check to see if 'age' has a value.
            if (age.HasValue)
            {
                // Output the age if it is not null.
                Console.WriteLine($"Age is: {age.Value}");
            }
            else
            {
                // If 'age' is null, print a message.
                Console.WriteLine("Age is not specified.");
            }
        }

        public static void Main(string[] args)
        {
            // Calling 'CheckAge' with a nullable integer.
            CheckAge(null);  // Output: Age is not specified.

            // Calling 'CheckAge' with a valid age.
            CheckAge(25);    // Output: Age is: 25
        }
    }
}
