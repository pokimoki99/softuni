﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._SetsofElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                first.Add(num);
            }
            for (int i = 0; i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                second.Add(num);
            }
            var intersection = first.Intersect(second);
            Console.WriteLine(String.Join(" ", intersection));
        }
    }
}
