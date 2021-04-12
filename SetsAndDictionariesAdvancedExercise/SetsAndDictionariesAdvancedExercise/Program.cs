using System;
using System.Collections.Generic;

namespace SetsAndDictionariesAdvancedExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> userNames = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                userNames.Add(name);
            }
            Console.WriteLine(String.Join(Environment.NewLine, userNames));
        }
    }
}
