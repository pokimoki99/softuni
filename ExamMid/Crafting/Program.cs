using System;

namespace Crafting
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] particles = Console.ReadLine().Split('|');//chetem comandi
            string input = Console.ReadLine();
            while (input != "Done")
            {
                string[] splited = input.Split();
                if (splited[0] == "Check")
                {
                    int sign = 0;
                    if (splited[1] == "Odd")
                    {
                        sign = 1;
                    }
                    for (int i = 0; i < particles.Length; i++)
                    {
                        if (i % 2 == sign)
                        {
                            Console.WriteLine(particles[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                if (splited[0] == "Move")
                {
                    if (splited[1] == "Left")
                    {
                        int index = int.Parse(splited[2]);
                        if (index > 0 && index < particles.Length)
                        {
                            string temp = particles[index];
                            particles[index] = particles[index - 1];
                            particles[index - 1] = temp;
                        }
                      
                    }
                    if (splited[1] == "Right")
                    {
                        int index = int.Parse(splited[2]);
                        if (index >= 0 && index < particles.Length - 1)
                        {
                            string temp = particles[index];
                            particles[index] = particles[index + 1];
                            particles[index + 1] = temp;
                        }

                    }
                }
                input = Console.ReadLine();
            }
            Console.Write($"You crafted {string.Join("", particles)}!");
        }
    }
}
