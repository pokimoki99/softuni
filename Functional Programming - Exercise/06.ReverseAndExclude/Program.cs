using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            numbers.Reverse();
            Predicate<int> predicate = num => num % n != 0;
            numbers = MyWhere(numbers, predicate);
            Action<List<int>> print = nums => Console.WriteLine(String.Join(" ", nums));
            print(numbers);
        }
        static List<int> MyWhere(List<int> numbers, Predicate<int> predicate)
        {
            List<int> newNumbers = new List<int>();
            foreach (var currentNum in numbers)
            {
                if (predicate(currentNum))
                {
                    newNumbers.Add(currentNum);
                }
            }
            return newNumbers;
        }
    }
}
