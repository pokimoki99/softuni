using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmojiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string emojiCodeAsStr = Console.ReadLine();
            int[] asciCode = emojiCodeAsStr.Split(":").Select(int.Parse).ToArray();
            string emojiCode = ":";
            for (int i = 0; i < asciCode.Length; i++)
            {
                emojiCode += (char)asciCode[i];
            }
            emojiCode += ":";
            string pattern = @"(?<emoji>:(?<emojivalue>[a-z]{4,}):)( |,|\.|!|\?)";
            MatchCollection matches = Regex.Matches(text, pattern);
            List<string> emojis = matches.Select(x => x.Groups["emoji"].Value).ToList();
            int totalAsciSum = 0;
            foreach (var emoji in emojis)
            {
                foreach (var symbol in emoji)
                {
                    if (symbol != ':')
                    {
                        totalAsciSum += symbol;
                    }
                }
            }
            if (emojis.Contains(emojiCode))
            {
                totalAsciSum *= 2;
            }
            if (emojis.Any())
            {
                Console.WriteLine($"Emojis found: {string.Join(",", emojis)}");
            }
            Console.WriteLine($"Total Emoji Power: {totalAsciSum}");
        }
    }
}
