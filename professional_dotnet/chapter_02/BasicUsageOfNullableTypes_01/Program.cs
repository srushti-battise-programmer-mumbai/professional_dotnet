// Program to  Basic Usage Of Nullable Types in C# with Visual Studio

// Programmer:Srushti Battise

namespace BasicUsageOfNullableTypes_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to  Basic Usage Of Nullable Types in C# with Visual Studio\n");
            // Declaring a nullable integer.
            // The '?' after 'int' means that 'myNullableInt' can hold an integer value or be null.
            int? myNullableInt = null;
            // Checking if 'myNullableInt' has a value.
            if (myNullableInt.HasValue)
            {
                Console.WriteLine($"Value: {myNullableInt.Value}");
            }
            else
            {
                Console.WriteLine("MyNullableInt is Null");
            }
            // Assigning a value to 'myNullableInt'.
            myNullableInt = 10;
            // Now 'myNullableInt' has a value, so this line will execute.
            if (myNullableInt.HasValue)
            {
                // Output: 10
                Console.WriteLine($"Value: {myNullableInt}");
            }
        }
    }
}