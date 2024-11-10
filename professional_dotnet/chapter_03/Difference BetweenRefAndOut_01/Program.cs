﻿// Program for Using In Keyword For Read Only Parameters in C# using Visual Studio

// Programmer: Srushti Battise

namespace Difference_BetweenRefAndOut_01
{
    public class Program
    {
      public static void Main(string[] args)
        {
            Console.WriteLine(" Program for Using In Keyword For Read Only Parameters in C# using Visual Studio\n");

            int number1 = 5;
            int number2;
            // Both 'ref' and 'out' are used to pass arguments by reference, but they behave differently.
            ModifyRef(ref number1);
            // Output: Using ref: 10
            Console.WriteLine("Using ref:" + number1);
            // Output: Using out: 50
            ModifyOut(out number2);
            Console.WriteLine("Using Out:" + number2);
        }
        public static void ModifyRef(ref int num)
        {
            // 'ref' requires the variable to be initialized before passing.
            num *= 2;
        }
        public static void ModifyOut(out int num)
        {
            // 'out' does not require initialization before passing.
            // Must assign value before returning.
            num = 50;
        }
    }
}
