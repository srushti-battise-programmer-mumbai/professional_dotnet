// Program to demonstrate Multiple Interface Implementation in C# using Visual Studio.
// Programmer: Srushti Battise

namespace MultipleInterfaceImplementation_01
{
    // Defining the first interface
    public interface IPrint
    {
        void Print();
    }
    // Defining a second interface
    public interface IScan
    {
        void Scan();
    }
    public class MultiFunctionPrinter : IPrint, IScan
    {
        public void Print()
        {
            Console.WriteLine("Printing Document.");
        }
        public void Scan()
        {
            Console.WriteLine("Scanning Document.");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Multiple Interface Implementation in C# using Visual Studio.\n");
            MultiFunctionPrinter mfp = new MultiFunctionPrinter();
            mfp.Print();
            mfp.Scan();
        }
    }
}
