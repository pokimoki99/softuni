using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentsGrade = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                var student = Console.ReadLine().Split();
                var name = student[0];
                var grade = decimal.Parse(student[1]);
                if (!studentsGrade.ContainsKey(name))
                {
                    studentsGrade.Add(name, new List<decimal>());
                }
                studentsGrade[name].Add(grade);
            }
            foreach (var student in studentsGrade)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }

        }
    }
}
