using System;
using System.Linq;

namespace WarShip
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine().Split('>').Select(int.Parse).ToArray();
            int[] warShip = Console.ReadLine().Split('>').Select(int.Parse).ToArray();
            int maxHelthSection = int.Parse(Console.ReadLine());
            string input = null;
            bool isBroken = false;
            while ((input = Console.ReadLine()) != "Retire")
            {
                string[] commandArgs = input.Split(" ");
                string command = commandArgs[0];
                int index = -1;
                int damage = 0; 
                switch (command)
                {
                    case "Fire":
                        index = int.Parse(commandArgs[1]);
                        damage = int.Parse(commandArgs[2]);
                        if (index >= 0 && index < warShip.Length)
                        {
                            warShip[index] -= damage;
                            if (warShip[index] <= 0)
                            {
                                Console.WriteLine("You won! The enemy ship has sunken.");
                                isBroken = true;
                            }
                           
                        }
                        
                        break;
                    case"Defend":
                        index = int.Parse(commandArgs[1]);
                        int endIndex = int.Parse(commandArgs[2]);
                        damage = int.Parse(commandArgs[3]);
                        if (index >=0 && index < pirateShip.Length &&
                            endIndex > 0 && endIndex < pirateShip.Length)
                        {
                            for (int i = index; i < endIndex; i++)
                            {
                                pirateShip[i] -= damage;
                                if (pirateShip[i] <= 0)
                                {
                                    Console.WriteLine("You lost! The pirate ship has sunken.");
                                    isBroken = true;
                                    break;
                                }
                            }
                        }
                       
                        break;
                    case"Repair":
                        index = int.Parse(commandArgs[1]);
                        int helth = int.Parse(commandArgs[2]);
                        if (index >=0 && index < pirateShip.Length)
                        {
                            pirateShip[index] += helth;
                            if (pirateShip[index] > maxHelthSection)
                            {
                                pirateShip[index] = maxHelthSection;
                            }
                          
                        }
                        break;
                    case"Status":
                        int count = 0;
                        foreach (int section in pirateShip)
                        {
                            double temp = 0.2 * maxHelthSection;
                            if (section < temp)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine($"{count} sections need repair.");

                        break;
                }
                if (isBroken)
                {
                    break;
                }
            }
            if (!isBroken)
            {
                int piratShipSum = 0;
                int warshipSum = 0;
                foreach (int i in pirateShip)
                {
                    piratShipSum += i;
                }
                foreach (int i in warShip)
                {
                    warshipSum += i;
                }
                Console.WriteLine($"Pirate ship status: {piratShipSum}");
                Console.WriteLine($" Warship status: {warshipSum}");

                
                //"Pirate ship status: {pirateShipSum}"
//"Warship status: {warshipSum}"

            }
        }
    }
}
