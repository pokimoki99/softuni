using System;
using System.Collections.Generic;
using System.Linq;

namespace Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> materialsForCrafting = new Stack<int>(input1);
            Queue<int> magicLevelValues = new Queue<int>(input2);
            Dictionary<int, string> presentMagicLevel = new Dictionary<int, string>
            {
                {150, "Doll" },
                {250, "Wooden train" },
                {300, "Teddy bear" },
                {400, "Bicycle" }
            };
            Dictionary<string, int> presentMade = new Dictionary<string, int>();
            while (materialsForCrafting.Count > 0 && magicLevelValues.Count > 0)
            {
                int magicLevel = materialsForCrafting.Peek() * magicLevelValues.Peek();
                if (presentMagicLevel.ContainsKey(magicLevel))
                {
                    if (!presentMade.ContainsKey(presentMagicLevel[magicLevel]))
                    {
                        presentMade.Add(presentMagicLevel[magicLevel], 0);
                    }
                    presentMade[presentMagicLevel[magicLevel]]++;
                    materialsForCrafting.Pop();
                    magicLevelValues.Dequeue();
                }
                else
                {
                    if (magicLevel < 0)
                    {
                        int sum = materialsForCrafting.Peek() + magicLevelValues.Peek();
                        materialsForCrafting.Pop();
                        magicLevelValues.Dequeue();
                        materialsForCrafting.Push(sum);

                    }
                    else if (magicLevel > 0)
                    {
                        int material = materialsForCrafting.Peek() + 15;
                        materialsForCrafting.Pop();
                        magicLevelValues.Dequeue();
                        materialsForCrafting.Push(material);
                    }
                    else if (magicLevel == 0)
                    {
                        if (materialsForCrafting.Peek() == 0)
                        {
                            materialsForCrafting.Pop();
                        }
                        if (magicLevelValues.Peek()==0)
                        {
                            magicLevelValues.Dequeue();
                        }
                      
                    }
                }
            }
            if ((presentMade.ContainsKey("Doll") && presentMade.ContainsKey("Wooden train"))
                || (presentMade.ContainsKey("Teddy bear") && presentMade.ContainsKey("Bicycle")))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }
            if (materialsForCrafting.Count > 0)
            {
                Console.WriteLine("Materials left: " + String.Join(",", materialsForCrafting));
            }
            if (magicLevelValues.Count > 0)
            {
                Console.WriteLine("Magic left: " + String.Join(",", magicLevelValues));
            }
            foreach (var presents in presentMade.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{presents.Key}: {presents.Value}");
            }
        }
    }
}
