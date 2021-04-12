using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = ReadIntListInASingleLine();
            Console.WriteLine(String.Join(" ",Sum(list)));
        }
        static List<int> Sum(List<int> numbers)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count / 2; i++)//tova deli 4islata na 2
            {
                result.Add(numbers[i] + numbers[numbers.Count - i - 1]);//vzima poslednoto chislo
            }
            if (numbers.Count % 2 == 1)
            {
                result.Add(numbers[numbers.Count / 2]);//tova dava sredniq element
            }
            return result;
        }

        private static List<int> ReadIntListInASingleLine()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            return list;
        }
    }
}
