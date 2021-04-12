using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i--);//maha s edin element nazad
                }
            }
            numbers.Reverse();//obru6ta procesa
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");// ne ssa ostanalli elementi
                return;
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
