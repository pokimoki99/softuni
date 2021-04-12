using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(numbers);
            int rackCounter = 1;
            int sum = 0;
            while (stack.Count > 0)
            {
                var current = stack.Peek();
                if (sum + current > capacity)
                {
                    rackCounter++;
                    sum = 0;
                }
                else
                {
                    sum += stack.Pop();
                }
            }
            Console.WriteLine(rackCounter);
        }
    }
}
