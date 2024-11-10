// Program to demonstrate Using Out With TryParseMethod in C# using Visual Studio
// Programmer: Srushti Battise

namespace AdvancedRefReturnValue_01
{
    public class Program
    {
        public static ref int GetElement(ref int[] numbers, int index)
        {
            return ref numbers[index];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Using Out With TryParseMethod in C# using Visual Studio\n");
            int[] numbers = { 1, 2, 3 };
            ref int element = ref GetElement(ref numbers, 1);

            // Modifying the element directly affects the original array.
            element = 20;

            // Output: 1, 20, 3
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
