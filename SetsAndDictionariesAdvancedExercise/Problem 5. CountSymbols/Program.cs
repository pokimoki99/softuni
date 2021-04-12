using System;
using System.Collections.Generic;

namespace Problem_5._CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> ocurrency = new SortedDictionary<char, int>();
            var input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (!ocurrency.ContainsKey(currentChar))
                {
                    ocurrency.Add(currentChar, 0);
                }
                ocurrency[currentChar]++;
            }
            foreach (var item in ocurrency)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
