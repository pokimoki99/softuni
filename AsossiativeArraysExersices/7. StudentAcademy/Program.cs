using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<double>());
                    studentGrades[name].Add(grade);
                }
                else
                {
                    studentGrades[name].Add(grade);
                }
            }
            var averageResult = new Dictionary<string, double>();
            foreach (var pair in studentGrades)
            {
                averageResult.Add(pair.Key, pair.Value.Average());
            }
            foreach (var pair in averageResult.Where(st=>st.Value >= 4.50).OrderByDescending(st =>st.Value))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:f2}");
            }
        }
    }
}
