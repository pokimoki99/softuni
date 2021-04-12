﻿using System;
using System.Linq;

namespace PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPresents = int.Parse(Console.ReadLine());
            int neighbourfoodSize = int.Parse(Console.ReadLine());
            char[,] hood = new char[neighbourfoodSize, neighbourfoodSize];
            int santaRow = -1;
            int santaCol = -1;
            int nicePresents = 0;
            for (int i = 0; i < neighbourfoodSize; i++)
            {
                var line = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int j = 0; j < line.Length; j++)
                {
                    hood[i, j] = line[j];
                    if (hood[i,j] == 'S')
                    {
                        santaRow = i;
                        santaCol = j;
                    }
                    if (hood[i,j] == 'V')
                    {
                        nicePresents++;
                    }
                }
            }
            string command = Console.ReadLine();
            while (command != "Christmas morning")
            {
                if (countOfPresents <= 0)
                {
                    Console.WriteLine("Santa ran out of presents!");
                    break;
                }

                hood[santaRow, santaCol] = '-';
                switch (command)
                {
                    case "up":
                        santaRow--;
                        break;
                    case "down":
                        santaRow++;
                        break;
                    case "left":
                        santaCol--;
                        break;
                    case "right":
                        santaCol++;
                        break;
                }
                if (hood[santaRow, santaCol] == 'V')
                {
                    countOfPresents--;
                }
                else if (hood[santaRow, santaCol] == 'C')
                {
                    if (hood[santaRow - 1, santaCol] != '-')
                    {
                        countOfPresents--;
                        hood[santaRow, santaCol - 1] = '-';
                    }
                    if (hood[santaRow, santaCol+1] != '-')
                    {
                        countOfPresents--;
                        hood[santaRow, santaCol + 1] = '-';
                    }
                    if (hood[santaRow + 1, santaCol] != '-')
                    {
                        countOfPresents--;
                        hood[santaRow + 1, santaCol] = '-';
                    }
                    if (hood[santaRow, santaCol -1] != '-')
                    {
                        countOfPresents--;
                        hood[santaRow, santaCol - 1] = '-';
                    }
                }
                

                command = Console.ReadLine();
            }
            hood[santaRow, santaCol] = 'S';
            int niceKidsWithoutPresents = 0;
            for (int row = 0; row < neighbourfoodSize; row++)
            {
                for (int col = 0; col < neighbourfoodSize; col++)
                {
                    Console.Write(hood[row, col] + " ");
                    if (hood[row,col] == 'V')
                    {
                        niceKidsWithoutPresents++;
                    }
                }
                Console.WriteLine();
            }
            if (niceKidsWithoutPresents == 0)
            {
                Console.WriteLine($"Good job,Santa! {nicePresents} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {niceKidsWithoutPresents} nice kid/s.");
            }

        }
    }
}
