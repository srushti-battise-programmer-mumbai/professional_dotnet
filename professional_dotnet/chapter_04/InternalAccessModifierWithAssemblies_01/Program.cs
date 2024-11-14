// Program to demonstrate Internal Access Modifier With Assemblies in C# using Visual Studio.
// Programmer: Srushti Battise

namespace InternalAccessModifierWithAssemblies_01
{
    internal class Calculator
    {
        internal int Add(int a, int b)
        {
            return a + b;
        }
    }
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Internal Access Modifier With Assemblies in C# using Visual Studio.\n");
            Calculator calculator = new Calculator();
            Console.WriteLine("Sum:" + calculator.Add(5, 10));
        }
    }
}
