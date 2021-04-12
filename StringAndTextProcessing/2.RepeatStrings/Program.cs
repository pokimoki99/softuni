using System;

namespace _2.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string result = string.Empty;
            foreach (var word in words)
            {
                int lenght = word.Length;
                for (int i = 0; i < lenght; i++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
        }
    }
}
