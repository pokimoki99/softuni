using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading;

namespace _4._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int studentCount = int.Parse(Console.ReadLine()); //broi nastudentite
            for (int i = 0; i < studentCount; i++)
            {
                var studentInfo = Console.ReadLine().Split().ToArray();
                Student student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
                students.Add(student);
            }
            Console.WriteLine(String.Join(Environment.NewLine, students.OrderByDescending(x => x.Grade)));

        }
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Grade { get; set; }
            public Student(string firstName, string lastName, string grade)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Grade = grade;
            }
            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }
        }
    }
}
