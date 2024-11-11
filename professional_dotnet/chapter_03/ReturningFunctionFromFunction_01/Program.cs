// Program for Returning Function From Function in C# using Visual Studio
// Programmer: Srushti Battise

namespace ReturningFunctionFromFunction_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Program for Returning Function From Function in C# using Visual Studio\n");
            Func<int, int> doubler = GetMultiplierFunction(2);
            Console.WriteLine("Doubled:" + doubler(5));
        }
        public static Func<int, int> GetMultiplierFunction(int multiplier)
        {
            return x => x * multiplier;
        }
    }
}
