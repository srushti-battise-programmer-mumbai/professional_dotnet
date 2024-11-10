// Program for Ref Requires Variable Initialization in C# using Visual Studio

// Programmer: Srushti Battise

namespace RefRequiresVariableInitialization_01
{
    public class Program
    {
      public static void Main(string[] args)
        {

            Console.WriteLine("Program for Ref Requires Variable Initialization in C# using Visual Studio\n");

            int number;
            // Uncommenting the line below will cause a compile error because the 'ref' variable must be initialized.
            // AddTen(ref number); // Error: Use of unassigned local variable 'number'

            // Properly initialize the variable.
            number = 20;
            AddTen(ref number);
            // Output:Value after AddTen:30
            Console.WriteLine("Value after AddTen:" + number);
        }
        public static void AddTen(ref int num)
        {
            num += 10;
        }
           
    }
}
