using System;
using System.Collections.Generic;
using System.Linq;

namespace Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char[][] matrix = new char[number][];
            var command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int coals = 0;
            List<int> coordinates = new List<int>();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var data = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                matrix[row] = new char[matrix.GetLength(0)];
                for (int column = 0; column < matrix.GetLength(0); column++)
                {
                    if (data[column] == '>')
                    {
                        coals++;
                    }
                    if (data[column] == '#')
                    {
                        coordinates.Add(row);
                        coordinates.Add(column);
                    }
                    matrix[row][column] = data[column];
                }
            }
            MinerDirection(matrix, command, coordinates, coals);
        }
        static void MinerDirection(char[][] matrix, string[] command, List<int> coordinates, int coals)
        {
            int row = coordinates[0];
            int col = coordinates[1];
            for (int i = 0; i < command.Length; i++)
            {
                var direction = command[i];
                if (coals == 0)
                {
                    Console.WriteLine($"Player One has won the game! ({row}, {col})");
                    return;
                }
                if (direction == "up")
                {
                    if (row - 1 >= 0)
                    {
                        if (matrix[row - 1][col] == '>')
                        {
                            matrix[row - 1][col] = '*';
                            coals--;
                        }
                        else if (matrix[row - 1][col] == '<')
                        {
                            Console.WriteLine($"Game over! ({row - 1}, {col})");
                            return;
                        }
                        row--;
                    }
                }
                else if (direction == "down")
                {
                    if (row + 1 < matrix.GetLength(0))
                    {
                        if (matrix[row + 1][col] == '>')//c
                        {
                            matrix[row + 1][col] = '*';
                            coals--;
                        }
                        else if (matrix[row + 1][col] == '<')//e
                        {
                            Console.WriteLine($"Game over! ({row + 1}, {col + 1})");
                            return;
                        }
                        row++;
                    }

                }
                else if (direction == "left")
                {
                    if (col - 1 >= 0)
                    {
                        if (matrix[row][col - 1] == '>')//c
                        {
                            matrix[row][col - 1] = '*';
                            coals--;
                        }
                        else if (matrix[row][col - 1] == '<')//e
                        {
                            Console.WriteLine($"Game over! ({row}, {col - 1})");
                            return;
                        }
                        col--;
                    }
                }
                else if (direction == "right")
                {
                    if (col + 1 < matrix.GetLength(0))
                    {
                        if (matrix[row][col + 1] == '>')//c
                        {
                            matrix[row][col + 1] = '*';
                            coals--;
                        }
                        else if (matrix[row][col + 1] == '<')
                        {
                            Console.WriteLine($"Game over! ({row}, {col + 1})");
                            return;
                        }
                        col++;
                    }
                }
                if (coals == 0)
                {
                    Console.WriteLine($"You collected all coals! ({row}, {col})");
                    return;
                }
            }
            Console.WriteLine($"{coals} coals left. ({row}, {col})"); int fieldSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[fieldSize, fieldSize];

            string[] coordinates = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);

            int playerOneShips = 0;
            int playerTwoShips = 0;
            int shipsDestroyed = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (currentRow[col] == '<')
                    {
                        playerOneShips++;
                    }
                    else if (currentRow[col] == '>')
                    {
                        playerTwoShips++;
                    }
                }
            }

            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] currentCoordinates = coordinates[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentRow = currentCoordinates[0];
                int currentCol = currentCoordinates[1];

                if (!IndexExists(currentRow, currentCol, matrix))
                {
                    continue;
                }

                if (matrix[currentRow, currentCol] == '*')
                {
                    continue;
                }
                else if (matrix[currentRow, currentCol] == '<')
                {
                    matrix[currentRow, currentCol] = 'X';
                    playerOneShips--;
                    shipsDestroyed++;
                }
                else if (matrix[currentRow, currentCol] == '>')
                {
                    matrix[currentRow, currentCol] = 'X';
                    playerTwoShips--;
                    shipsDestroyed++;
                }
                else if (matrix[currentRow, currentCol] == '#')
                {
                    if (IndexExists(currentRow - 1, currentCol - 1, matrix))
                    {
                        if (matrix[currentRow - 1, currentCol - 1] == '<')
                        {
                            matrix[currentRow - 1, currentCol - 1] = 'X';
                            playerOneShips--;
                            shipsDestroyed++;
                        }
                        else if (matrix[currentRow - 1, currentCol - 1] == '>')
                        {
                            matrix[currentRow - 1, currentCol - 1] = 'X';
                            playerTwoShips--;
                            shipsDestroyed++;
                        }
                    }

                    if (IndexExists(currentRow - 1, currentCol, matrix))
                    {
                        if (matrix[currentRow - 1, currentCol] == '<')
                        {
                            matrix[currentRow - 1, currentCol] = 'X';
                            playerOneShips--;
                            shipsDestroyed++;
                        }
                        else if (matrix[currentRow - 1, currentCol] == '>')
                        {
                            matrix[currentRow - 1, currentCol] = 'X';
                            playerTwoShips--;
                            shipsDestroyed++;
                        }
                    }

                    if (IndexExists(currentRow - 1, currentCol + 1, matrix))
                    {
                        if (matrix[currentRow - 1, currentCol + 1] == '<')
                        {
                            matrix[currentRow - 1, currentCol + 1] = 'X';
                            playerOneShips--;
                            shipsDestroyed++;
                        }
                        else if (matrix[currentRow - 1, currentCol + 1] == '>')
                        {
                            matrix[currentRow - 1, currentCol + 1] = 'X';
                            playerTwoShips--;
                            shipsDestroyed++;
                        }
                    }

                    if (IndexExists(currentRow, currentCol - 1, matrix))
                    {
                        if (matrix[currentRow, currentCol - 1] == '<')
                        {
                            matrix[currentRow, currentCol - 1] = 'X';
                            playerOneShips--;
                            shipsDestroyed++;
                        }
                        else if (matrix[currentRow, currentCol - 1] == '>')
                        {
                            matrix[currentRow, currentCol - 1] = 'X';
                            playerTwoShips--;
                            shipsDestroyed++;
                        }
                    }

                    if (IndexExists(currentRow, currentCol + 1, matrix))
                    {
                        if (matrix[currentRow, currentCol + 1] == '<')
                        {
                            matrix[currentRow, currentCol + 1] = 'X';
                            playerOneShips--;
                            shipsDestroyed++;
                        }
                        else if (matrix[currentRow, currentCol + 1] == '>')
                        {
                            matrix[currentRow, currentCol + 1] = 'X';
                            playerTwoShips--;
                            shipsDestroyed++;
                        }
                    }

                    if (IndexExists(currentRow + 1, currentCol - 1, matrix))
                    {
                        if (matrix[currentRow + 1, currentCol - 1] == '<')
                        {
                            matrix[currentRow + 1, currentCol - 1] = 'X';
                            playerOneShips--;
                            shipsDestroyed++;
                        }
                        else if (matrix[currentRow + 1, currentCol - 1] == '>')
                        {
                            matrix[currentRow + 1, currentCol - 1] = 'X';
                            playerTwoShips--;
                            shipsDestroyed++;
                        }
                    }

                    if (IndexExists(currentRow + 1, currentCol, matrix))
                    {
                        if (matrix[currentRow + 1, currentCol] == '<')
                        {
                            matrix[currentRow + 1, currentCol] = 'X';
                            playerOneShips--;
                            shipsDestroyed++;
                        }
                        else if (matrix[currentRow + 1, currentCol] == '>')
                        {
                            matrix[currentRow + 1, currentCol] = 'X';
                            playerTwoShips--;
                            shipsDestroyed++;
                        }
                    }

                    if (IndexExists(currentRow + 1, currentCol + 1, matrix))
                    {
                        if (matrix[currentRow + 1, currentCol + 1] == '<')
                        {
                            matrix[currentRow + 1, currentCol + 1] = 'X';
                            playerOneShips--;
                            shipsDestroyed++;
                        }
                        else if (matrix[currentRow + 1, currentCol + 1] == '>')
                        {
                            matrix[currentRow + 1, currentCol + 1] = 'X';
                            playerTwoShips--;
                            shipsDestroyed++;
                        }
                    }
                }

                if (playerOneShips == 0 || playerTwoShips == 0)
                {
                    break;
                }
            }

            if (playerOneShips == 0)
            {
                Console.WriteLine($"Player Two has won the game! " +
                    $"{shipsDestroyed} ships have been sunk in the battle.");
            }
            else if (playerTwoShips == 0)
            {
                Console.WriteLine($"Player One has won the game! " +
                    $"{shipsDestroyed} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"It's a draw! " +
                    $"Player One has {playerOneShips} ships left. " +
                    $"Player Two has {playerTwoShips} ships left.");
            }

        }

        static bool IndexExists(int row, int col, char[,] matrix)
        {
            if (row >= matrix.GetLength(0) || row < 0 ||
                col >= matrix.GetLength(1) || col < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
