// Program to demonstrate Summing All Elements In 2D Array in C# with Visual Studio
// Programmer: Srushti Battise

namespace SummingAllElementsIn2DArray_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Summing All Elements In 2D Array in C# with Visual Studio\r\n");
            int[,] twoDimensionalArray = new int [3,3] { { 7,9,1},{ 0,2,5},{ 5,8,4} };
            int sum = 0;
            int rowCount = twoDimensionalArray.GetLength(0);
            int columnCount = twoDimensionalArray.GetLength(1);
            for(int rowCounter = 0; rowCounter < rowCount; rowCounter++)
            {
                for(int columnCounter = 0; columnCounter < columnCount; columnCounter++)
                {
                    sum += twoDimensionalArray[rowCounter, columnCounter];
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
