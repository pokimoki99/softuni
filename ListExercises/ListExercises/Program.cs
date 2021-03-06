using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapasity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] elements = command.Split();
                if (elements[0]=="ADD")
                {
                    int passengers = int.Parse(elements[1]);
                    train.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(elements[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + passengers <= maxCapasity)
                        {
                            train[i] += passengers;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",train));
        }
    }
}
