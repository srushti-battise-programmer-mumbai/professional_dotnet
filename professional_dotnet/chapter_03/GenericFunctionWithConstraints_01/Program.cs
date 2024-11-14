// Program to demonstrate Generic Function With Constraints in C# using Visual Studio
// Programmer: Srushti Battise

namespace GenericFunctionWithConstraints_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Generic Function With Constraints in C# using Visual Studio\n");

            // DisplayArray<int>(new int[] { 1, 2, 3 });

            // String is a reference type.
            DisplayArray<string>(new string[] { "apple", "banana", "cherry" });
        }

        public static void DisplayArray<T>(T[] array) where T : class
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
