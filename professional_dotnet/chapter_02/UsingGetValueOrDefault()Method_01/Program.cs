// Program to Using GetValueOrDefault() Method in C# with Visual Studio
// Programmer:Srushti Battise

namespace UsingGetValueOrDefault__Method_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to Using GetValueOrDefault() in C# with Visual Studio\n");

            // Declaring a nullable float variable.
            float? myNullableFloat = null;

            // Using the 'GetValueOrDefault()' method returns the value of 'myNullableFloat'
            // or a default value (0.0f in the case of float) if it is null.
            float defaultValue = myNullableFloat.GetValueOrDefault();

            // Output: 0.0
            Console.WriteLine($"Default Value: {defaultValue}");

            // Assigning a value to 'myNullableFloat'.
            myNullableFloat = 9.81f;

            // Now, 'GetValueOrDefault()' will return the actual value.
            float actualValue = myNullableFloat.GetValueOrDefault();

            // Output: 9.81
            Console.WriteLine($"Actual Value: {actualValue}");

        }
    }
}
