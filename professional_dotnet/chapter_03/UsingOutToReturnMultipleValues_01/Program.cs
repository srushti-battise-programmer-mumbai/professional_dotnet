// Program for Using Out To Return Multiple Values in C# using Visual Studio

// Programmer: Srushti Battise

namespace UsingOutToReturnMultipleValues_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Using Out To Return Multiple Values in C# using Visual Studio\n");
            // Variables that will receive multiple outputs from the method.
            int sum, product;
            // Calling the method with 'out' parameters.
            Calculate (3, 5, out sum, out product);
            // Output: Sum: 8
            Console.WriteLine("Sum: " + sum);
            // Output: Product: 15
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Product: " + product);
        }
        // Method to calculate sum and product using 'out' parameters.
        public static void Calculate(int a, int b, out int sum ,out int product)
        {
            // Assign value to 'sum'
            sum = a + b;
            // Assign value to 'product'
            product = a * b;
        }




    }
}
