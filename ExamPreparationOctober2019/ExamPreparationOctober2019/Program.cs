using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPreparationOctober2019
{
    class Program
    {
        static void Main(string[] args)

        {
            const int  GlassValue = 25;
            const int  AluminiumValue = 50;
            const int  LithiumValue = 75;
            const int  CarbonValue = 100;

            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> items = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Dictionary<string, int> craftedItems = new Dictionary<string, int>
            {
                {"Aluminium", 0},
                {"Carbon fiber", 0},
                {"Glass", 0},
                {"Lithium", 0},
            };
            while (liquids.Count > 0 && items.Count > 0)
            {
                int currentLiquids = liquids.Dequeue();
                int currentItem = items.Pop();
                int sum = currentLiquids + currentItem;
                switch (sum)
                {

                    case GlassValue:
                        craftedItems["Glass"] += 1;
                        break;
                    case AluminiumValue:
                        craftedItems["Aluminium"] += 1;
                        break;
                    case LithiumValue:
                        craftedItems["Lithium"] += 1;
                        break;
                    case CarbonValue:
                        craftedItems["Carbon fibre"] += 1;
                        break;
                    default:
                        items.Push(currentItem + 3);
                        break;
                  
                }
            }
            if (!craftedItems.ContainsValue(0))
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn’t have enough materials to build the spaceship.");
            }
            if (liquids.Count > 0)
            {
                Console.WriteLine($"Liquids left: {String.Join(" ", liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }
            if (items.Count > 0)
            {
                Console.WriteLine($"Phisical items left: {String.Join(" ", items)}");
            }
            else
            {
                Console.WriteLine("Phisical items left: none");
            }
            foreach (var itemCount in craftedItems)
            {
                Console.WriteLine($"{itemCount.Key}: {itemCount.Value}");
            }
        }
    }
}
