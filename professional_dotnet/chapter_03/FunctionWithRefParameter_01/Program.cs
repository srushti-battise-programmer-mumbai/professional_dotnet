// Program for  Function With Ref Parameter in C# using Visual Studio
// Programmer: Srushti Battise

namespace FunctionWithRefParameter_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for  Function With Ref Parameter in C# using Visual Studio\n");

            int Number = 10;
            // Passing number by reference to the SquareNumber function.
            SquareNumber(ref Number);
            Console.WriteLine("Squared Number:" + Number);
        }
        public static void SquareNumber(ref int value)
        {
            // Multiply value by itself.
            value *= value;
        }
    }
}
