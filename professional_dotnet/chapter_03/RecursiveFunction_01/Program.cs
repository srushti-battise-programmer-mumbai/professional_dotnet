// Program for  Recursive Function in C# using Visual Studio
// Programmer: Srushti Battise

namespace RecursiveFunction_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for  Recursive Function in C# using Visual Studio\n");
            int number = 5;
            Console.WriteLine("Factorial of " + number + ":" + factorial(number));
        }
        // Recursive function to calculate factorial.
        public static int factorial(int number)
        {
            if
                (number == 1) //Base class
                return 1;
            else
                return number * factorial(number - 1);// Recursive call
        }
    }
}

