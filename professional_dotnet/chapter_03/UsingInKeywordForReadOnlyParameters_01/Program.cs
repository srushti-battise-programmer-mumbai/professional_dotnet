// Program for Using In Keyword For Read Only Parameters in C# using Visual Studio

// Programmer: Srushti Battise

namespace UsingInKeywordForReadOnlyParameters_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Using In Keyword For Read Only Parameters in C# using Visual Studio\n");
            // Initialize a value.
            int number = 100;

            // Pass the value to the method using 'in'.
            // 'in' ensures the method cannot modify the original value.
            ShowValue(in number);
        }
        // Pass the value to the method using 'in'.
        // 'in' ensures the method cannot modify the original value.
        public static void ShowValue(in int value)
        {
            // Output: Value is: 100
            Console.WriteLine("Value: " + value);

            // Uncommenting the line below will cause a compile error as 'in' prevents modification.
            // value = 200;
        }
    }
}
