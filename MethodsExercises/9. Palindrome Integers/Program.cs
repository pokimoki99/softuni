using System;
using System.Linq;
using System.Reflection.Metadata;

namespace _9._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Console.WriteLine(IsPalindrome(input).ToString().ToLower());// za da napravim True/False s malki bukvi
                input = Console.ReadLine();
            }
        }

        private static bool IsPalindrome(string text)
        {
            var reversed = text.Reverse().ToArray();//321/123 = obru6ta chislata
            for (int i = 0; i < text.Length; i++)
            {
                if (!(reversed[i] == text [i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
