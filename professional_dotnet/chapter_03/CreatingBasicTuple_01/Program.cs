// Program to Creating Basic Tuple in C# using Visual Studio
// Programmer: Srushti Battise

namespace CreatingBasicTuple_01
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Program to Creating Basic Tuple in C# using Visual Studio\n");
            // Creating a Tuple to hold two values, both an integer and a string.
            Tuple<int,string> person = new Tuple <int,string> ( 21," Srushti");

            // Accessing Tuple elements by Item1 and Item2 properties.
            // Output: ID: 21
            Console.WriteLine("ID:" +person.Item1);

            // Output: Name: Alice
            Console.WriteLine("Name:" +person.Item2);
        }
    }
}
