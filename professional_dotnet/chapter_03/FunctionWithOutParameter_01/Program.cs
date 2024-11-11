// Program for  Function With Out Parameter in C# using Visual Studio
// Programmer: Srushti Battise

namespace FunctionWithOutParameter_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for  Function With Out Parameter in C# using Visual Studio\n");
            int result;
            CalculateArea(5, 10, out result);
            Console.WriteLine("Area of the Rectangle:" + result);
        }
        // Function to calculate area and use out parameter to return the result.
        public static void CalculateArea(int length, int width, out int area)
        {
            area = length * width;
        }
    }
}
