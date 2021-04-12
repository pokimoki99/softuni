﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _04.Students
{
    class Program
    {
            static void Main(string[] args)
            {
                List<Team> teams = new List<Team>();
                int numOfTeams = int.Parse(Console.ReadLine());
                for (int i = 0; i < numOfTeams; i++)
                {
                    var Info = Console.ReadLine().Split("-").ToArray();
                    string creator = Info[0];// 6te syzdavame ekip
                    string teamName = Info[1];
                   
                    if (teams.Any(x => x.Name == teamName))
                    {
                        Console.WriteLine($"Team{teamName} was already created!");
                        continue;
                    }
                    else if (teams.Any(x => x.Creator == creator))
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                        continue;
                    }
                    Team team = new Team(teamName, creator);
                    teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
                string command = String.Empty;
                while ((command = Console.ReadLine()) != "end of assignment")
                {
                    var Info = command.Split("->").ToArray();
                    string person = Info[0];// 6te dobavqme chovek
                    string teamName = Info[1];
                if (!teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                if (teams.Any(x => x.peopleJoined.Contains(person)|| teams.Any(x => x.Creator == person && x.Name == teamName)))
                {
                    Console.WriteLine($"Member {person} cannot join team {teamName}");
                }
                int index = teams.FindIndex(x => x.Name == teamName);
                teams[index].peopleJoined.Add(person);
            }
            var teamsToBeDisbanded = teams.FindAll(x => x.peopleJoined.Count == 0).OrderBy(x => x.Name).ToList();
            var validTeams = teams.FindAll(x => x.peopleJoined.Count > 0).OrderBy(x => x.Name).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, validTeams.OrderByDescending(x => x.peopleJoined.Count)
                .ThenBy(x => x.Name)));
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToBeDisbanded)
            {
                Console.WriteLine(team.Name);
            }
        }
        public class Team
        {
            public string Name { get; set; }
            public string Creator { get; set; }
            public List<string> peopleJoined;
            public Team(string name, string creator)
            {
                this.Name = name;
                this.Creator = creator;
                peopleJoined = new List<string>();
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(Name);
                sb.AppendLine("- " + Creator);
                foreach (var member in peopleJoined)
                {
                    sb.AppendLine("-- " + member);
                }
                return sb.ToString().TrimEnd();
            }
        }
       
    }
}
