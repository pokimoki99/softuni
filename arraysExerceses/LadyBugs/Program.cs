using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] intionalIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] filed = new int[fieldSize];
            for (int i = 0; i < intionalIndexes.Length; i++)
            {
                int currentIndex = intionalIndexes[i];
                if (currentIndex >= 0 && currentIndex < filed.Length)
                {
                    filed[currentIndex] = 1;
                }

            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] elements = command.Split();
                int ladybugIndex = int.Parse(elements[0]);
                string direction = elements[1];
                int flylenght = int.Parse(elements[2]);
                if (ladybugIndex < 0 || ladybugIndex > filed.Length - 1 || filed[ladybugIndex] == 0)
                {
                    continue;
                }
                filed[ladybugIndex] = 0;
                if (direction == "right")
                {
                    int landIndex = ladybugIndex + flylenght;
                    if (landIndex > filed.Length)
                    {
                        continue;
                    }
                    if (filed[landIndex] == 1)
                    {
                        while (filed[landIndex] == 1)
                        {
                            landIndex += flylenght;
                            if (landIndex > filed.Length - 1)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex <= filed.Length - 1)
                    {
                        filed[landIndex] = 1;
                    }
                }
                else if (direction == "left")
                {
                    int landIndex = ladybugIndex - flylenght;
                    if (landIndex < 0)
                    {
                        continue;
                    }
                    if (filed[landIndex] == 1)
                    {
                        while (filed[landIndex] == 1)
                        {
                            landIndex -= flylenght;
                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex <= filed.Length - 1)
                    {
                        filed[landIndex] = 1;
                    }

                }

            }
            Console.WriteLine(string.Join(" ", filed));
        }

    }
}
