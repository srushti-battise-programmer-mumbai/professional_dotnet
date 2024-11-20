// Program to demonstrate Swap Numbers Without Third Variable in C# with Visual Studio
// Programmer:Srushti Battise

namespace SwapNumbersWithoutThirdVariable_01
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Conditional Statements in C# with Visual Studio\r\n");
            int firstNumber = 12;
            int secondNumber = 7;

            Console.WriteLine($"Before swapping first number: {firstNumber} second number: {secondNumber}");

            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

            Console.WriteLine($"After swapping first number: {firstNumber} second number: {secondNumber}");
        }
    }
}
