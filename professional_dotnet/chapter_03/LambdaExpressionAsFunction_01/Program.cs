// Program for Lambda Expression As Function in C# using Visual Studio
// Programmer: Srushti Battise

namespace LambdaExpressionAsFunction_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Lambda Expression As Function in C# using Visual Studio\n");
            Func<int, int, int> multiply = (x, y) => x * y;
            Console.WriteLine("Product:" + multiply(1, 2));
        }
    }
}
