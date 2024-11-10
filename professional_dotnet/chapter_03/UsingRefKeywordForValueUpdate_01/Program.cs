// Program for Using Ref Keyword For Value Update in C# using Visual Studio
// Programmer: Srushti Battise

namespace UsingRefKeywordForValueUpdate_01
{
public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Program for Using Ref Keyword For Value Update in C# using Visual Studio\n");

            // Declare and initialize a variable.
            int number = 10;

            // Pass the variable to the method using 'ref'.
            // 'ref' allows the method to modify the original variable.
            // Output: Before: 10
            Console.WriteLine("Before: " + number);
            AddFive(ref number);
            // Output: After: 15
            Console.WriteLine("After: " + number);
        }
        // Method that takes an argument by reference.
        // Using 'ref' ensures the original value gets modified.
        public static void AddFive(ref int number_temporary)
        {
            // Modify the original value
            number_temporary += 5;
        }
    }
}
