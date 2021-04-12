using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TheIsleoftheManTTRace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                string input = Console.ReadLine();
                string lenghtPattern = @"=(\d+)!!";
                Match m = Regex.Match(input, lenghtPattern);
                if (m.Success)
                {
                    int lenght = int.Parse(m.Groups[1].Value);
                    string pattern = $@"([#$%*&])(\w+)\1=(\d+)!!(.{{{lenght}}})$";
                    Match match = Regex.Match(input, pattern);
                    if (match.Success)
                    {
                        string name = match.Groups[2].Value;
                        string coordinates = match.Groups[4].Value;
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < coordinates.Length; i++)
                        {
                            sb.Append((char)(coordinates[i] + lenght));
                        }
                        Console.WriteLine($"Coordinates found! {name} -> {sb.ToString()}");
                        break;
                    }
                }
                Console.WriteLine("Nothing found!");
               

            }
        }
    }
}
