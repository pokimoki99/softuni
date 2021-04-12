using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterial = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterial = new Dictionary<string, int>();
            keyMaterial["shards"] = 0;
            keyMaterial["motes"] = 0;
            keyMaterial["fragments"] = 0;
            bool hasToBreak = false;
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string matirial = input[i + 1].ToLower();
                    if (matirial == "shards" || matirial == "motes" || matirial == "fragments")
                    {
                        keyMaterial[matirial] += quantity;
                        if (keyMaterial[matirial] >= 250)
                        {
                            keyMaterial[matirial] -= 250;
                            if (matirial == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (matirial == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else if (matirial == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            hasToBreak = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterial.ContainsKey(matirial))
                        {
                            junkMaterial.Add(matirial, 0);
                        }
                        junkMaterial[matirial] += quantity;
                    }
                }
                if (hasToBreak)
                {
                    break;
                }

            }
            Dictionary<string, int> filterKeyMaterials = keyMaterial
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x=> x.Value);
            foreach (var kvp in filterKeyMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junkMaterial.OrderBy(k=>k.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
