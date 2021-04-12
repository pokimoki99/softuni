using System;
using System.Collections.Generic;
using System.Linq;

namespace AsossiativeArraysLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var sortedDictionari = new SortedDictionary<double, int>();
            foreach (var number in numbers)
            {
                if (sortedDictionari.ContainsKey(number))
                {
                    sortedDictionari[number]++;
                }
                else
                {
                    sortedDictionari.Add(number, 1);
                }
            }
            foreach (var pair in sortedDictionari)
            {
                Console.WriteLine(pair.Key + " -> "+ pair.Value);
            }
        }
    }
}
