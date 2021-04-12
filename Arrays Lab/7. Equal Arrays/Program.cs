using System;
using System.Linq;


namespace _7._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)

        {
            //"Arrays are identical. Sum: {sum}""Arrays are not identical. Found difference at {index} index".
            int[] numbersOne = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] numbersTwo = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i <= numbersOne.Length; i++)
            {
                if (numbersOne[i] != numbersTwo [i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                {
                    sum += numbersOne[i];
                    if (i == numbersOne.Length - 1)
                    {
                        Console.WriteLine($"Arrays are identical. Sum: {sum}");
                    }

                }
            }
           
        }

    }
}
