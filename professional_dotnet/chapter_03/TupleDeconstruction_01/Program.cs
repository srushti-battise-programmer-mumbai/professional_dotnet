// Program for Tuple Deconstruction in C# using Visual Studio
// Programmer: Srushti Battise

namespace TupleDeconstruction_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Tuple Deconstruction in C# using Visual Studio\n");
            // Create a tuple with three values.
            var product = (101, "Laptop", 75000);

            // Deconstruct the tuple into separate variables.
            var (id, name, price) = product;

            Console.WriteLine("Product Id:" + id);
            Console.WriteLine("Product Name:" + name);
            Console.WriteLine("Product Price:" + price);
        }
    }
}
