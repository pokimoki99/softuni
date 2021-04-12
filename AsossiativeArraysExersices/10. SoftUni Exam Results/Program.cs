using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> submisson = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] cmdArgs = input.Split("-");
                string user = cmdArgs[0];
                if (cmdArgs.Length > 2)
                {
                    string language = cmdArgs[1];
                    int points = int.Parse(cmdArgs[2]);
                    if (!students.ContainsKey(user))
                    {
                        students.Add(user, points);
                    }
                    else
                    {
                        if (students[user] < points)
                        {
                            students[user] = points;
                        }
                    }
                    if (!submisson.ContainsKey(language))
                    {
                        submisson.Add(language, 0);
                    }
                    submisson[language]++;
                }
                else
                {
                    students.Remove(user);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            foreach (var currentStudent in students.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{currentStudent.Key} | {currentStudent.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var currentSubmisson in submisson.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{currentSubmisson.Key} - {currentSubmisson.Value}");
            }
        }
    }
}
