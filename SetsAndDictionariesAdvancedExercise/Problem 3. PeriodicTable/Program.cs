using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> elements = new HashSet<string>();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                foreach (var item in input)
                {
                    elements.Add(item);
                }
            }
            var sorted = elements.OrderBy(x => x);
            Console.WriteLine(String.Join(" ", sorted));
        }
    }
}
