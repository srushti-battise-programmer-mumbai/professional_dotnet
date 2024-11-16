// Program to demonstrate Explicit Interface Implementation in C# using Visual Studio.
// Programmer: Srushti Battise

namespace ExplicitInterfaceImplementation_01
{
    public interface IReadable
    {
        void Read();
    }
    public interface IWriteable
    {
        void Write();
    }
    public class Document : IReadable, IWriteable
    {
        // Explicit interface implementation
        void IReadable.Read()
        {
            Console.WriteLine("Reading Document....");
        }
        void IWriteable.Write()
        {
            Console.WriteLine("Writing Document....");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Explicit Interface Implementation in C# using Visual Studio.\r\n");
            Document doc = new Document();
            ((IReadable)doc).Read();
            ((IWriteable)doc).Write();

        }
    }
}
