// Program to   Using Null_Coalescing Operator(??) in C# with Visual Studio

// Programmer:Srushti Battise

namespace UsingNull_CoalescingOperator_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to   Using Null_Coalescing Operator(??) in C# with Visual Studio\n");

            // Nullable double declared and initialized with null.
            double? myNullableDouble=null;

            // Using the null-coalescing operator (??) to provide a default value.
            // If 'myNullableDouble' is null, 3.14 will be assigned to 'result'.
            double result = myNullableDouble ?? 3.14;

            Console.WriteLine($"Result: {result}");
        }
    }
}
