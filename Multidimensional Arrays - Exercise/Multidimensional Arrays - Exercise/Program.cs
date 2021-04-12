﻿using System;
using System.Linq;

namespace Multidimensional_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int number = rowData[col];
                    matrix[row, col] = rowData[col];
                }

            }
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            int counter = n - 1;

            for (int row = 0; row < n; row++)
            {
                primaryDiagonal += matrix[row, row];
                secondaryDiagonal += matrix[row, counter];
                counter--;
            }
            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}
