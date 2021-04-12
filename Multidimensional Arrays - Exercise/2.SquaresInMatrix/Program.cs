using System;
using System.Linq;

namespace _2.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            char[,] matrix = new char[rows, cols];
            FillMatrix(matrix);
            int count = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    char currentElements = matrix[row, col];
                    if (currentElements == matrix[row, col + 1]
                        && currentElements == matrix[row + 1,col + 1]
                        && currentElements == matrix[row + 1, col])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }

        private static void PrintMatrix(char[, ] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.Write(numbers[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(char[, ] numbers)
        {

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = currentRow[col];
        
                }
            }
        }

    }
}
