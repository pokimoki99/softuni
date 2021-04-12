using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            List<string> evenLenght = words.Where(word => word.Length % 2 == 0).ToList();
            Console.WriteLine(string.Join("\n", evenLenght));
        }
    }
}
