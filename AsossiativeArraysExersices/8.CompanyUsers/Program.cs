using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new SortedDictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string name = input.Split(" -> ")[0];
                string id = input.Split(" -> ")[1];
                if (!company.ContainsKey(name))
                {
                    company.Add(name, new List<string>());
                    company[name].Add(id);
                }
                else
                {

                    if (!company[name].Contains(id))
                    {
                        company[name].Add(id);
                    }
                }
            }
            foreach (var pair in company)
            {
                Console.WriteLine(pair.Key);
                foreach (string id in pair.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
