using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> print = (arr) =>
            {
                Console.WriteLine(String.Join(" ", arr));
            };
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "print")
                {
                    print(numbers);
                }
                else
                {
                    Func<int[], int[]> processor = GetProcesor(input);
                    numbers = processor(numbers);
                }
            }
        }
        static Func<int[], int[]> GetProcesor(string input)
        {
            Func<int[], int[]> processor = null;
            if (input == "add")
            {
                processor = new Func<int[], int[]>((arr) =>
                {
                   return arr.Select(n => n + 1).ToArray();
                });
            }
            else if (input == "multiply")
            {
                processor = new Func<int[], int[]>((arr) =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = arr[i]* 2;
                    }
                    return arr;
                });
            }
            else if (input == "subtract")
            {
                processor = new Func<int[], int[]>((arr) =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i]--; ;
                    }
                    return arr;
                });
            }
            return processor;
        }
    }
}
