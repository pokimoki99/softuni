﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<int>> boxes = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
                boxes.Add(box);
            }
            int[] indexis = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            SwapIndexes(boxes, indexis[0], indexis[1]);
            foreach (Box<int> currentBox in boxes)
            {
                Console.WriteLine(currentBox);
            }
        }
        private static void SwapIndexes<T>(List<Box<T>>boxes, int firstIndex, int secondIndex)
        {
            Box<T> temp = boxes[firstIndex];
            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = temp;
        }
    }
}
