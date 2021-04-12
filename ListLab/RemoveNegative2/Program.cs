using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegative2
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 -5 7 9 -33 50	//   50 9 7 10
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = numbers//vzima chislata i vijda kude sa po golemi ot nula
                .Where(n => n >= 0)//proverqvame dali uslovieto e vqrno
                .Reverse()//obry6tame go
                .ToList();// i go pravim v kolekciq
            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
            
        }

    }
}
