// Program to demonstrate Traversing Multi Dimensional Array in C# using Visual Studio
// Programmer: Srushti Battise

namespace TraversingMultiDimensionalArray_01
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Program to demonstrate Use of Multi-dimensional Array in C# with Visual Studio\n");

                int row_counter;
                int column_counter;

                // Creating a multi dimensional array
                int[,] numbers_array =
                {
                { 2, 3, 5 },
                { 1, 4, 7 },
                { 1, 4, 7 }
            };

                // Looping on rows
                for (row_counter = 0; row_counter < numbers_array.GetLength(0); row_counter++)
                {
                    Console.WriteLine($"Row {row_counter}:");

                    // Looping on rows
                    for (column_counter = 0; column_counter < numbers_array.GetLength(0); column_counter++)
                    {
                        Console.WriteLine($"{numbers_array[row_counter, column_counter]} ");
                    }
                }
            }
        }
}

