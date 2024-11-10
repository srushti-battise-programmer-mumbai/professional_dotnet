// Program for Tuple In Collection in C# using Visual Studio
// Programmer: Srushti Battise

namespace TupleInLINQQuery_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Tuple In Collection in C# using Visual Studio\n");

            // Array of numbers
            int[] numbers = { 1, 2, 3, 4, 5 };
            // Using LINQ query to select tuples with square values
            var results = numbers.Select(n => (Number: 1, Square: n * n));
            foreach (var result in results)
            {
                Console.WriteLine($"Number:{result.Number},Square:{result.Square}");

            }
        }
    }
}
