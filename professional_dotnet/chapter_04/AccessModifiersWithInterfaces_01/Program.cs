// Program to demonstrate  Access Modifiers With Interfaces In Inheritance in C# using Visual Studio.
// Programmer: Srushti Battise

namespace AccessModifiersWithInterfaces_01
{
    public interface IMath
    {
        // Public by default in interface
        int Add(int a, int b);
    }
    public class IMathOperations : IMath
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Access Modifiers In Nested Classes_01 InInheritance in C# using Visual Studio.\n");
            IMath math = new IMathOperations();
            Console.WriteLine("Sum:" +math.Add(2,3));
        }
    }
}
