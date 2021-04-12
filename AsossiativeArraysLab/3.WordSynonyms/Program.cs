using System;
using System.Collections.Generic;

namespace _3.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordSynonyms = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonims = Console.ReadLine();
                if (wordSynonyms.ContainsKey(word))
                {
                    wordSynonyms[word].Add(synonims);
                }
                else
                {
                    wordSynonyms.Add(word, new List<string>());
                    wordSynonyms[word].Add(synonims);
                }
            }
            foreach (var pair in wordSynonyms)
            {
                Console.WriteLine(pair.Key + " - "+ string.Join(", ", pair.Value));
            }
           

        }
    }
}
