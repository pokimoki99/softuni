using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();
            while (command[0].ToUpper() != "END")//pravi taka che da nqma znachenie bukvi, malki ili golemi
            {
                switch (command[0].ToUpper())
                {
                    case "ADD":
                        numbers.Add(int.Parse(command[1]));//Add {number}: add a number to the end of the list.
                        break;
                    case "REMOVE":
                        numbers.Remove(int.Parse(command[1]));//Remove {number}: remove a number from the list.
                        break;
                    case "REMOVEAT":
                        numbers.RemoveAt(int.Parse(command[1]));//RemoveAt {index}: remove a number at a given index.
                        break;
                    case "INSERT":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));//Insert {number} {index}: insert a number at a given index.
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
