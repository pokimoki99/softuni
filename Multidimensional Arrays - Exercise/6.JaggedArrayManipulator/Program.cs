using System;
using System.Linq;

namespace _6.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jaggedMatrix = new double[n][];
            for (int row = 0; row < n; row++)
            {
                double[] rowdata = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
                jaggedMatrix[row]= rowdata;
            }
            for (int row = 0; row < n - 1; row++)
            {
                double[] firstArray = jaggedMatrix[row];
                double[] secondArray = jaggedMatrix[row + 1];
                if (firstArray.Length == secondArray.Length)
                {
                    jaggedMatrix[row] = firstArray.Select(x => x * 2).ToArray();
                    jaggedMatrix[row+1] = secondArray.Select(x => x * 2).ToArray();
                }
                else
                {
                    jaggedMatrix[row] = firstArray.Select(x => x / 2).ToArray();
                    jaggedMatrix[row + 1] = secondArray.Select(x => x / 2).ToArray();
                }
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandData = command.Split(" ");
                int rowIndex = int.Parse(commandData[1]);
                int coIndex = int.Parse(commandData[2]);
                int value = int.Parse(commandData[3]);
                bool isValidCell = rowIndex >= 0 && rowIndex < n && coIndex >= 0 && coIndex < jaggedMatrix[rowIndex].Length;
                if (!isValidCell)
                {
                    command = Console.ReadLine();
                    continue;
                }
                if (commandData[0] == "Add")
                {
                    jaggedMatrix[rowIndex][coIndex] += value;
                }
                else if (commandData[0] == "Subtract")
                {
                    jaggedMatrix[rowIndex][coIndex] -= value;
                }
                command = Console.ReadLine(); 
            }
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join(" ", jaggedMatrix[row]));
            }
        }
    }
}
