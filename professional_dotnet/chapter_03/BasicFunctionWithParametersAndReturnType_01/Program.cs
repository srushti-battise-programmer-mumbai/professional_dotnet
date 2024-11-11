// Program for Basic Function With Parameters And Return Type in C# using Visual Studio
// Programmer: Srushti Battise

namespace BasicFunctionWithParametersAndReturnType_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Basic Function With Parameters And Return Type in C# using Visual Studio\n");
            // Calling the AddNumbers function and storing the result.
            int result = AddNumbers(5, 10);

            // Display the result.
            Console.WriteLine("Sum:" + result);
        }
        /// <summary>
        /// Adds two integers and returns the same.
        /// </summary>
        /// <param name="a">The first integer value.</param>
        /// <param name="b">The second integer value.</param>
        /// <return>returns the sum of a and b.</return>
         
     public static int AddNumbers(int a, int b)
        {
            // Adding a and b and returning the result.
return a + b;
        }
    }
}
