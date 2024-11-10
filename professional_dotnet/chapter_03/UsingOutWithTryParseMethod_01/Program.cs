// Program to demonstrate Using Out With TryParseMethod in C# using Visual Studio
// Programmer: Srushti Battise

namespace UsingOutWithTryParseMethod_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Using Out With TryParseMethod in C# using Visual Studio\n");
            string input = "123";
            int result;
            // TryParse method uses 'out' to return parsed integer or default zero.
            if (int.TryParse(input, out result))
            {
                // Output: Parsed Number: 123
                Console.WriteLine("Parsed result:" + result);
            }
            else
            {
                Console.WriteLine("Failed to parse.");
            }
        }
    }
}
