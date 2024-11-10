// Program for Tuple Returning Multiple Values From Method in C# using Visual Studio
// Programmer: Srushti Battise

namespace TupleReturningMultipleValuesFromMethod_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Tuple Returning Multiple Values From Method in C# using Visual Studio\n");
            // Call the method that returns area and perimeter
            var result = CalculateRectangle(5, 10);

            // Output: Area: 50
            Console.WriteLine("Area:" + result.Area);

            // Output: Perimeter: 30
            Console.WriteLine("Perimeter:" + result.Perimeter);
        }
        // Method returning multiple values as a tuple
        public static (int Area, int Perimeter) CalculateRectangle(int length, int width)
        {
            return (length * width, 2 * (length + width));
        }
    }
}
