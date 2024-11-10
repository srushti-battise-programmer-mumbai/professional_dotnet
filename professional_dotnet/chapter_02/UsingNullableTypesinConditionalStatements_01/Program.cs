// Program to demonstrate Using Nullable Types in Conditional Statements in C# with Visual Studio
// Programmer:Srushti Battise

namespace UsingNullableTypesinConditionalStatements_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Using Nullable Types in Conditional Statements in C# with Visual Studio\n");

            // Nullable character variable declared.
            char? myNullableChar = 'A';

            // Conditional (ternary) operator to check if 'myNullableChar' has a value.
            // If true, the character is returned; otherwise, a default character is returned.
            char? displayChar = myNullableChar.HasValue ? myNullableChar.Value : 'Z';

            // Output: A
            Console.WriteLine($"Display Character:{displayChar}");

            // Setting the nullable character to null.
            myNullableChar = null;

            // Now, the conditional will use the default value 'Z' because 'myNullableChar' is null.
            displayChar = myNullableChar.HasValue ? myNullableChar.Value : 'Z';

            // Output: Z
            Console.WriteLine($"Display Character:{displayChar}");

        }
    }
}
