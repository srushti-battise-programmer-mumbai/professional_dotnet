// Program to demonstrate Method Overloading in C# using Visual Studio
// Programmer: Srushti Battise

namespace MethodOverloading_01
{
    using System;

    public class Calculator
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Overloaded method to add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(5, 3));       // Output: 8
            Console.WriteLine(calc.Add(5, 3, 2));    // Output: 10
        }
    }
}