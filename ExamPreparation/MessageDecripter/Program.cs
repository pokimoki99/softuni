using System;
using System.Text.RegularExpressions;

namespace MessageDecripter
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([*@])([A-Z][a-z]{2,})([*@])\:\s\[(\w+)\]\|\[(\w+)\]\|\[(\w+)\]\|$";
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Match match = Regex.Match(Console.ReadLine(), pattern);
                if (match.Length == 0)
                {
                    Console.WriteLine("Valid message not found!");
                    continue;
                }
                char first = Convert.ToChar(match.Groups["first"].Value);
                char second = Convert.ToChar(match.Groups["second"].Value);
                char third = Convert.ToChar(match.Groups["third"].Value);
                Console.WriteLine($"{match.Groups["name"].Value}: {(int)first} {(int)second} {(int)third}");
            }
        }
    }
}
