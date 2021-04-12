using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = ReadIntListInASingleLine();
            var secondList = ReadIntListInASingleLine();
            Console.WriteLine(String.Join(" ",MergeList(firstList, secondList)));
            
        }
        private static List<int> ReadIntListInASingleLine()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            return list;
        }
        static List<int>MergeList(List<int> first, List<int> second)
        {
            int count = Math.Max(first.Count, second.Count);//vry6ta nai golqmata stoinost
            List<int> marged = new List<int>();
            for (int i = 0; i < count; i++)
            {
                if (first.Count > i)
                {
                    marged.Add(first[i]);
                }
                if (second.Count > i)
                {
                    marged.Add(second[i]);
                } 
            }
            return marged;

        }
    }
}
