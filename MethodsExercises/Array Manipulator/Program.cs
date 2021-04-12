using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);
                    if (index < 0 || index > arr.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    Exchange(arr, index);
                }
                else if (command[0] ==  "max")
                {
                    if (command[1] == "even")

                    {
                        if (MaxEven(arr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MaxEven(arr));
                    }
                    else
                    {
                        if (MaxOdd(arr) == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        Console.WriteLine(MaxOdd(arr));
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[0] == "even")
                    {
                        Console.WriteLine(minEven(arr));
                    }
                    else
                    {
                        Console.WriteLine(MinOdd(arr));    
                    }
                }
            }
        }
        static void Exchange(int[] array, int index)
        {
            int[] firstArr = new int[array.Length - index - 1];
            int[] secondArr = new int[index + 1];
            int firstArrCounter = 0;
            for (int i = index + 1; i < array.Length; i++)
            {
                firstArr[firstArrCounter] = array[i];
                firstArrCounter++;

            }
            for (int i = 0; i < index + 1; i++)
            {
                secondArr[i] = array[i];

            }
            for (int i = 0; i < firstArr.Length; i++)
            {
                array[i] = firstArr[i];
            }
            for (int i = 0; i < secondArr.Length; i++)
            {
                array[firstArr.Length + i] = secondArr[i];
            }
        }
        static int MaxEven(int[] array)
        {
            int maxEven = int.MinValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] >= maxEven)
                    {
                        maxEven = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }
        static int MaxOdd(int[] array)
        {
            int maxOdd = int.MinValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] >= maxOdd)
                    {
                        maxOdd = array[i];
                        index = 1;
                    }
                }
            }
            return index;
        }
        static int minEven(int[] array)
        {
            int minEven = int.MaxValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] <= minEven)
                    {
                        minEven = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }
        static int MinOdd(int[] array)
        {
            int minOdd = int.MaxValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] <= minOdd)
                    {
                        minOdd = array[i];
                        index = 1;
                    }
                }
            }
            return index;
        }
    }
}
