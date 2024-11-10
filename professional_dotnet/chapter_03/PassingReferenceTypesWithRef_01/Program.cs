// Program for Passing Reference Types With Ref in C# using Visual Studio

// Programmer: Srushti Battise

using System;

namespace PassingReferenceTypesWithRef_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Passing Reference Types With Ref in C# using Visual Studio\n");
            string text = "Hello";

            // Pass a reference type by 'ref'.
            AppendText(ref text);

            // Output: Hello World!
            Console.WriteLine(text);

        }
        public static void AppendText(ref string str)
        {
            // Modify the original string by appending text
            str += " World!";
        }

    }
}
