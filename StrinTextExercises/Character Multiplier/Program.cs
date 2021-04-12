using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(CharMultiplayer(input[0], input[1]));
        }

        static int CharMultiplayer(string first, string second)
        {
            int sum = 0;
            string longest = "";
            string shortest = "";
            if (first.Length > second.Length)
            {
                longest = first;
                shortest = second;
            }
            else
            {
                longest = second;
                shortest = first;
            }
            for (int i = 0; i < shortest.Length; i++)
            {
                sum += shortest[i] * longest[i];
            }
            for (int i = shortest.Length; i < longest.Length; i++)
            {
                sum += longest[i];
            }
            return sum;
        }
    }
}
