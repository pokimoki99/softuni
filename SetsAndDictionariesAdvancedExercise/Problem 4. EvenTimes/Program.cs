using System;
using System.Collections.Generic;

namespace Problem_4._EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> ocurrency = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (!ocurrency.ContainsKey(currentNumber))
                {
                    ocurrency.Add(currentNumber, 0);
                }
                ocurrency[currentNumber]++;
            }
            foreach (var item in ocurrency)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
                
            }
        }
    }
}
