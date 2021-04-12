using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guest = new List<string>();
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();
                string name = command[0];//komandata e s 3 elementa i vinagi zapo4va ot 0
                if (command.Length == 0)
                {
                    
                    if (guest.Contains(name))//tyrsi dali imeto na gosta e v spisyka
                    {
                        Console.WriteLine($"{name} is alredy in the list!");
                    }
                    else
                    {
                        guest.Add(name);//dobavq gosta

                    }
                }
                else
                {
                    if (guest.Contains(name)) // v protiven sluchai tursim imeto
                    {
                        guest.Remove(name);//ako go nqma go mahame ot spisyka
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");  
                    }
                }
            }
            Console.WriteLine(string.Join("\n",guest));
            
        }
    }
}
