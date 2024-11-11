// Program for Anonymous Method As Function in C# using Visual Studio
// Programmer: Srushti Battise

namespace AnonymousMethodAsFunction_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Anonymous Method As Function in C# using Visual Studio\n");
            Func<int, int> square = delegate (int x) { return x * x; };
            Console.WriteLine("Square:" + square(4));
        }
    }
}
