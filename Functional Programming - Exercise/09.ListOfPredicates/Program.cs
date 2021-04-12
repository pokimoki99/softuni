using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            List<int> deviders = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> numbers = new List<int>();
            Func<int, int, bool> predicate = (num, d) => num % d == 0;

            for (int i = 1; i <= end; i++)
            {
                if (deviders.All(d => predicate(i,d)))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
