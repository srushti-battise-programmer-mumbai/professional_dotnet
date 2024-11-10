// Program to demonstrate In Out Ref Combined in C# using Visual Studio
// Programmer: Srushti Battise

namespace InOutRefCombined_01
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine(" Program to demonstrate In Out Ref Combined in C# using Visual Studio\n");
            int a = 10,b;
            Multiply(ref a, in a, out b);

            // Output: a = 20, b = 100
            Console.WriteLine($"a = {a},b = {b}");
        }
        public static void Multiply(ref int refParam,in int inParam,out int outParam)
        {
            // Output: a = 20, b = 100
            refParam *= 2;

            // Cannot modify 'inParam' as it is read-only
            // Assign value to 'outParam'
            outParam = refParam * inParam;
        }
    }
}
