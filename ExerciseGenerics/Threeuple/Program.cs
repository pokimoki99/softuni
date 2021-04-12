using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstTupleData = Console.ReadLine().Split(" ");
            string fullName = $"{firstTupleData[0]} {firstTupleData[1]}";
            List<string> townRowData = firstTupleData.ToList().Skip(3).ToList();
            string town = string.Join(" ", townRowData);
            Threeuple<string, string, string> firstThreeuple = new Threeuple<string, string, string>(fullName, firstTupleData[2]
                , town);
           
            string[] secondTupleData = Console.ReadLine().Split(" ");
            int num = secondTupleData[2] == "drunk" ? 10 : 100;
            bool drunk = secondTupleData[2] == "drunk" ? true : false;
            Threeuple<string, int, bool> secondTuple = new Threeuple<string, int, bool>(secondTupleData[0],
               int.Parse(secondTupleData[1]), drunk);
         
            string[] thurdTupleData = Console.ReadLine().Split(" ");
            Threeuple<string, double, string> thirdThreple = new Threeuple<string, double, string>(thurdTupleData[0],
                double.Parse(thurdTupleData[1]), thurdTupleData[2]);

            Console.WriteLine(firstThreeuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdThreple);
        }
    }
}
