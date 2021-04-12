using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int> (Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new Stack<int> (Console.ReadLine().Split().Select(int.Parse));
            int wasteWater = 0;
            int cup = cups.Peek();
            while (cups.Any()&& bottles.Any())
            {
               
                int bottle = bottles.Pop();
                if (bottle >= cup)
                {
                    bottle -= cup;
                    wasteWater += bottle;
                    cups.Dequeue();
                    if (cups.Count > 0)
                    {
                        cup = cups.Peek();
                    }
                }
                else
                {
                    cup -= bottle;
                }
            }
            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wasteWater}");
        }
    }
}
