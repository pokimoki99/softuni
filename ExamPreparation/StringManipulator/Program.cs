using System;
using System.Linq;

namespace StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] splitedInput = input.Split(" ");
                string command = splitedInput[0];
                if (command == "Add")
                {
                    string newStringtoAdd = splitedInput[1];
                    result += newStringtoAdd;
                }
                else if (command == "Upgrade")
                {
                    char oldChar = char.Parse(splitedInput[1]);
                    result = result.Replace(oldChar, (char)(oldChar + 1));
                }
                else if (command == "Print")
                {
                    Console.WriteLine(result);
                }
                else if (command == "Index")
                {
                    char symbol = char.Parse(splitedInput[1]);
                    List<int> indexes = new List<int>();
                    int startIndex = 0;
                    indexes = result.Select((x, i) => i).Where(indexes => result[i] == symbol).ToList();
                    if (!indexes.Any())
                    {
                        Console.WriteLine("None");
                    }
                    else
                    {
                        Console.WriteLine(string.Join(" ", indexes));
                    }
                }
                else if (command == "Remove")
                {
                    string searchStr = splitedInput[1];
                     result = result.Replace(searchStr, "")
                }
                input = Console.ReadLine();
                
            }
        }
    }
}
