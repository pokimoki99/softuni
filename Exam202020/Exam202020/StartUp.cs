using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam202020
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());//price of each bullet

            int total = 0;

            string[] plate = Console.ReadLine().Split(" ");
            string[] warriors = Console.ReadLine().Split(" ");

            List<int> warrior = new List<int>();
            List<int> plates = new List<int>();

            foreach (var bull in warriors)
            {
                warrior.Add(int.Parse(bull));
            }
            foreach (var lo in plate)
            {
                plates.Add(int.Parse(lo));
            }

            for (int i = 1; i <= waves; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    plates.Add(int.Parse(Console.ReadLine()));
                }

                while (warrior.First() != 0)
                {
                    if (warrior.Last() > plates.First())
                    {
                        warrior[warrior.Count - 1] -= plates[0];
                        plates.Remove(plates[0]);

                    }
                    else if (warrior.Last() < plates.First())
                    {
                        plates[0] -= warrior.Last();
                        warrior.Remove(warrior.Last());
                    }
                    else
                    {
                        plates.Remove(plates[0]);
                        warrior.Remove(warrior.Last());
                    }
                    if (plates.Count == 0 || warrior.Count == 0)
                    {
                        break;
                    }
                }

                if (plates.Count == 0)
                {
                    break;
                }
                if (waves == i)
                {
                    break;
                }


                warriors = Console.ReadLine().Split(" ");



                foreach (var bull in warriors)
                {
                    warrior.Add(int.Parse(bull));
                }
                warrior.Remove(0);
                total++;
            }

            if (plates.Count == 0)
            {
                Console.WriteLine($"The orcs successfully destroyed the Gondor's defense.");

                StringBuilder sb = new StringBuilder();
                sb.Append("Orcs left: ");

                for (int i = warrior.Count - 1; i > -1; i--)
                {
                    sb.Append(warrior[i]);
                    if (i == 0)
                    {
                    }
                    else
                    {
                        sb.Append(", ");
                    }
                }
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine($"The people successfully repulsed the orc's attack.");

                StringBuilder sb = new StringBuilder();
                sb.Append("Plates left: ");

                for (int i = plates.Count - 1; i > -1; i--)
                {
                    sb.Append(plates[i]);
                    if (i == 0)
                    {
                    }
                    else
                    {
                        sb.Append(", ");
                    }
                }
                Console.WriteLine(sb.ToString());

            }
        }
    }
}
