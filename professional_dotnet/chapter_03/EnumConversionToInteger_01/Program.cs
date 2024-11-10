// Program for Enum Conversion To Integer in C# using Visual Studio

// Programmer: Srushti Battise

namespace EnumConversionToInteger_01
{
    public class Program
    {
      public static void Main(string[] args)
        {
            Console.WriteLine("Program for Enum Conversion To Integer in C# using Visual Studio\n");
            // Assigning an enum value to 'OrderStatus'.
            OrderStatus status = OrderStatus.dispatched;
            // Converting the enum value to its underlying integer.
            int statusCode = (int)status;
            // Displaying the integer value of the enum.
            // Output: Order status code: 2
            Console.WriteLine("Order status code :" + statusCode);

        }
    }
}
public enum OrderStatus
{
    pending,//0
    processing,//1
    dispatched,//2
    delivered//3
}