using System;
using System.Collections.Generic;
using System.Linq;

namespace warcraft2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Ship_status = Console.ReadLine();
            List<String> Ship = Ship_status.Split(">").ToList();
            //List<String> Ship_max = Ship_status.Split(">").ToList();



            string Warship_status = Console.ReadLine();
            List<String> Warship = Warship_status.Split(">").ToList();

            int maxHealth = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            List<String> order = command.Split(" ").ToList();



            while (command != "Retire")
            {
                bool breakLoops = false;
                if (order[0] == "Fire")
                {
                    if (0 < int.Parse(order[1]) && int.Parse(order[1]) <= Warship.Count)
                    {
                        Warship[int.Parse(order[1])] = (int.Parse(Warship[int.Parse(order[1])]) - int.Parse(order[2])).ToString();
                        if (int.Parse(Warship[int.Parse(order[1])]) <= 0)
                        {
                            Console.WriteLine($"You won! The enemy ship has sunken.");
                            breakLoops = true;
                            break;
                        }
                    }
                }
                if (order[0] == "Defend")
                {
                    if (0 < int.Parse(order[2]) && int.Parse(order[2]) <= Ship.Count)
                    {
                        for (int i = 0; i < int.Parse(order[2]); i++)
                        {
                            Ship[i] = (int.Parse(Ship[i]) - int.Parse(order[3])).ToString();
                            if (int.Parse(Ship[i]) <= 0)
                            {
                                Console.WriteLine($"You lost! The pirate ship has sunken.");
                                breakLoops = true;
                                break;
                            }
                        }
                    }
                }
                if (order[0] == "Repair")
                {
                    if (0 < int.Parse(order[1]) && int.Parse(order[1]) <= Ship.Count)
                    {
                        Ship[int.Parse(order[1])] = (int.Parse(Ship[int.Parse(order[1])]) + int.Parse(order[2])).ToString();

                        if (int.Parse(Ship[int.Parse(order[1])]) > maxHealth)
                        {
                            Ship[int.Parse(order[1])] = (maxHealth).ToString();
                        }
                    }
                }
                if (order[0] == "Status")
                {
                    int status = 0;
                    for (int i = 0; i < Ship.Count; i++)
                    {
                        if (((double.Parse(Ship[i]) / maxHealth) * 100) < 20)
                        {
                            status += 1;
                        }
                    }
                    Console.WriteLine($"{status} sections need repair.");
                }

                if (breakLoops)
                {
                    break;
                }

                command = Console.ReadLine();
                order = command.Split(" ").ToList();
                if (command == "Retire")
                {
                    int hp_Ship = Ship.Sum(x => Convert.ToInt32(x));
                    int hp_Warship = Warship.Sum(y => Convert.ToInt32(y));
                    Console.WriteLine($"Pirate ship status: {hp_Ship}");
                    Console.WriteLine($"Warship status: {hp_Warship}");
                }
            }
        }
    }
}
