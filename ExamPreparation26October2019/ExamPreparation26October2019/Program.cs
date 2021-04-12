﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPreparation26October2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] malesInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] femaileInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> males = new Stack<int>(malesInput);
            Queue<int> females = new Queue<int>(femaileInput);
            int matchesCount = 0;
            while (males.Count > 0 && females.Count > 0)
            {
                int currentMale = males.Peek();
                int currentFemale = females.Peek();
                if (currentMale <= 0)
                {
                    males.Pop();
                    continue;
                }
                if (currentFemale <= 0)
                {
                    females.Dequeue();
                    continue;
                }
                if (currentMale % 25 == 0)
                {
                    males.Pop();
                    if (males.Count>0)
                    {
                        males.Pop();
                    }
                    continue;
                }
                if (currentFemale % 25 == 0)
                {
                    females.Dequeue();
                    if (females.Count > 0)
                    {
                        females.Dequeue();
                    }
                    continue;
                }
                if (currentMale == currentFemale)
                {
                    matchesCount++;
                    males.Pop();
                    females.Dequeue();

                }
                else
                {
                    females.Dequeue();
                    males.Pop();
                    males.Push(currentMale - 2);
                }


            }
            Console.WriteLine($"Matches: {matchesCount}");
            string malesString = males.Count > 0 ? String.Join(" ", males) : "none";
            Console.WriteLine($"Males left: {malesString}");
            string femailsString = females.Count > 0 ? String.Join(" ", females) : "none";
            Console.WriteLine($"Females left: {femailsString}");

        }
    }
}
