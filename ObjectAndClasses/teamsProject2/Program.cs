using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace teamsProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] newTeam = Console.ReadLine().Split("-");
                string creatorName = newTeam[0];
                string teamName = newTeam[1];
                Team team = new Team(teamName, creatorName);

                bool isTeamExist = teams.Select(x => x.TeamName).Contains(teamName);//tursi dali ima takova ime na otbor
                bool isCreatorNameExist = teams.Select(x => x.CreatorName).Contains(creatorName);// tursi dali ima takowa ime na avtor
                if (!isTeamExist)
                {
                    if (!isCreatorNameExist)
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                    }
                    else
                    {
                        Console.WriteLine($" {creatorName} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }
            string teamMembers = Console.ReadLine();
            while (teamMembers != "end of assignment")
            {
                string[] cmdArg = teamMembers.Split(new char[] {'-','>'}).ToArray();
                string newUser = cmdArg[0];
                string teamName = cmdArg[2];

                bool isTeamExist = teams.Select(x => x.TeamName).Contains(teamName);
                bool isCreatorExist = teams.Select(x => x.CreatorName).Contains(newUser);
                bool isMemberExist = teams.Select(x => x.Member).Any(x => x.Contains(newUser));
                if (!isTeamExist)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (isCreatorExist || isMemberExist)
                {
                    Console.WriteLine($"Member {newUser} cannot join team {teamName}!");
                }
                else
                {
                    int index = teams.FindIndex(x => x.TeamName == teamName);
                    teams[index].Member.Add(newUser);
                }

                     teamMembers = Console.ReadLine();
            }
            Team[] teamsToDisband = teams.OrderBy(x => x.TeamName).Where(x => x.Member.Count == 0).ToArray();
            Team[] fullTeam = teams.OrderByDescending(x => x.Member.Count).ThenBy(x => x.TeamName)
                .Where(x => x.Member.Count > 0).ToArray();
            StringBuilder sb = new StringBuilder();
            foreach (Team team in fullTeam)
            {
                sb.AppendLine($" {team.TeamName}");
                sb.AppendLine($"- {team.CreatorName}");
                foreach (var member in team.Member.OrderBy(x=>x))
                {
                    sb.AppendLine($"-- {member}");
                }
            }
            sb.AppendLine("Teams to disband:");
            foreach (Team item in teamsToDisband)
            {
                sb.AppendLine(item.TeamName);
            }
            Console.WriteLine(sb.ToString());
        }
    }
    class Team
    {
        public Team(string teamName, string creatorName)
        {
            TeamName = teamName;
            CreatorName = creatorName;
            Member = new List<string>();
        }
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Member { get; set; }
    }
}
