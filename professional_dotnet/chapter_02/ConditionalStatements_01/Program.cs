// Program to demonstrate Conditional Statements in C# with Visual Studio
// Programmer:Srushti Battise

namespace ConditionalStatements_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Conditional Statements in C# with Visual Studio\r\n");
            // Nullable character variable declared.
            char? myNullableChar = 'A';

            // Conditional (ternary) operator to check if 'myNullableChar' has a value.
            // If true, the character is returned; otherwise, a default character is returned.
            char result = myNullableChar.HasValue ? myNullableChar.Value : 'Z';

            Console.WriteLine($"Result: {result}"); // Output: Result: A

            // Setting the nullable character to null.
            myNullableChar = null;

            // Now, the conditional will use the default value 'Z' because 'myNullableChar' is null.
            result = myNullableChar.HasValue ? myNullableChar.Value : 'Z';

            Console.WriteLine($"Result: {result}"); // Output: Result: Z

        }
    }
}
