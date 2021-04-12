using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> item = Console.ReadLine().Split("|").ToList();
            item.Reverse();
            List<string> result = new List<string>();
            foreach (string currentItem in item)
            {
                string[] numbers = currentItem
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();
                foreach (string numbersToAdd in numbers)
                {
                    result.Add(numbersToAdd);
                }
            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
