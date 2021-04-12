﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string cmdType = cmdArg[0];
                if (cmdType == "1")
                {
                    int elementToPush = int.Parse(cmdArg[1]);
                    numbers.Push(elementToPush);
                }
                else if (cmdType == "2")
                {
                    if (numbers.Any())
                    {
                    numbers.Pop();
                    }
                }
                else if (cmdType == "3")
                {
                    if (numbers.Any())
                    {
                        Console.WriteLine(numbers.Max());
                    }
                }
                else if (cmdType == "4")
                {
                    if (numbers.Any())
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ", numbers));

        }
    }
}
