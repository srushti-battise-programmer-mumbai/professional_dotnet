﻿// Program to demonstrate Basic two dimensional array for storing matrix in C# with Visual Studio
// Programmer: Srushti Battise

/*
    This example demonstrates a 2D array, often used to represent matrices or grids.
    twoDimensionalArray.GetLength(0) returns the number of rows, while twoDimensionalArray.GetLength(1) returns the number of columns.
    This is useful in many real-world applications like image processing, matrix operations, and tabular data representation.
*/

namespace Basic2DArrayForStoringMatrix_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Basic two dimensional array for storing matrix in C# with Visual Studio\n");

            // Declaring a 2D array (a matrix with 2 rows and 3 columns)
            int[,] twoDimensionalArray = new int[2, 3] { { 5, 7, 9 }, { 9, 4, 1 } };

            int rowCount = twoDimensionalArray.GetLength(0);
            int columnCount = twoDimensionalArray.GetLength(1);

            // Printing the elements of the matrix
            // Outer loop iterates over rows
            for (int rowCounter = 0; rowCounter < rowCount; rowCounter++)
            {
                // Inner loop iterates over columns
                for (int columnCounter = 0; columnCounter < columnCount; columnCounter++)
                {
                    Console.Write($"{twoDimensionalArray[rowCounter, columnCounter]} "); // Printing each element
                }
                Console.WriteLine(); // New line for each row
            }
        }
    }
}