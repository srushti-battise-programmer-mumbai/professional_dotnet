// Program for  Overloading Functions With different parameters in C# using Visual Studio
// Programmer: Srushti Battise

namespace OverloadingFunctionsWithDifferentParameters_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Program for  Overloading Functions With different parameters in C# using Visual Studio\n");
            // Calling overloaded functions with different parameters.
            Console.WriteLine("Sum of Interger:" + AddNumbers(5, 10));
            Console.WriteLine("Sum of Double:" + AddNumbers(5.5, 10.3));
        }
        // Function to add two integers.
        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        public static double AddNumbers(double a, double b)
        {
            return a + b;
        }
    }
}
