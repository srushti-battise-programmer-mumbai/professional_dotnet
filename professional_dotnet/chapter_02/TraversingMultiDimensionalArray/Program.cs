// Program to demonstrate Traversing Multi Dimensional Array in C# with Visual Studio
// Programmer:Srushti Battise

namespace TraversingMultiDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Traversing Multi Dimensional Array in C# with Visual Studio\r\n");
            int[,] matrix =
            {
                { 2, 7, 9 },
                { 3, 5, 6 },
                { 0, 1, 2 },
            };

            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);

            for (int rowCounter = 0; rowCounter < rowCount; rowCounter++)
            {
                for (int columnCounter = 0; columnCounter < columnCount; columnCounter++)
                {
                    Console.Write($"{matrix[rowCounter, columnCounter]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
