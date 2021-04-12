using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FeedTheAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> animalDailyLimit = new Dictionary<string, int>();
            Dictionary<string, List<string>> areaAnimals = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while(input != "Last Info")
            {
                string[] splitedInput = input.Split(":");
                string command = splitedInput[0];
                string animalName = splitedInput[1];
                int food = int.Parse(splitedInput[2]);
                string area = splitedInput[3];
                if (command == "Add")
                {
                    if (!animalDailyLimit.ContainsKey(animalName))
                    {
                        animalDailyLimit[animalName] = 0;
                    }
                    animalDailyLimit[animalName] += food;
                    if (!areaAnimals.ContainsKey(area))
                    {
                        areaAnimals[area] = new List<string>();
                    }
                    if (!areaAnimals[area].Contains(animalName))
                    {
                        areaAnimals[area].Add(animalName);
                    }
                    else if (command == "Feed")
                    {
                        if (animalDailyLimit.ContainsKey(animalName))
                        {
                            animalDailyLimit[animalName] -= food;
                            if (animalDailyLimit[animalName] < 1)

                            {
                                animalDailyLimit.Remove(animalName);
                                areaAnimals[area].Remove(animalName);
                                Console.WriteLine($"{animalName} was successfully fed");
                            }
                        }
                    }
                    input = Console.ReadLine();
                }
                animalDailyLimit = animalDailyLimit.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, y => y.Value);
                areaAnimals = areaAnimals.Where(x => x.Value.Count>0).OrderByDescending(x => x.Value.Count)
                    .ToDictionary(x => x.Key, y => y.Value);
                Console.WriteLine("Animals:");
                foreach (var animal in animalDailyLimit)
                {
                    Console.WriteLine($"{animal.Key} -> {animal.Value}g");
                }
                Console.WriteLine($"Areas with hungry animals:");
                foreach (var animal in areaAnimals)
                {
                    Console.WriteLine($"{animal.Key} : {animal.Value.Count}");
                }
            }
            
        }
    }
}
