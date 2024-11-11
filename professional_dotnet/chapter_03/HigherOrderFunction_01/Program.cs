// Program for Higher Order Function in C# using Visual Studio
// Programmer: Srushti Battise

namespace HigherOrderFunction_01
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Program for Higher Order Function in C# using Visual Studio\n");
            // Passing a function as an argument
            ExecuteFunction(SayHello!);
        }
        public static void SayHello()
        {
            Console.WriteLine("Hello from SayHello Function!");
        }
        public static void ExecuteFunction(Action action)
        {
            action();
        }
    }
}
