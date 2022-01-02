using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _05.TeamworkProjects
{
    class Teams
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Member { get; set; }

        //public Teams(string teamName, string creator, string member)
        //{
        //    TeamName = teamName;
        //    Creator = creator;
        //    Member = member;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Teams> teams = new List<Teams>();

            for (int i = 0; i < n; i++)
            {
                string[] newTeams = Console.ReadLine().Split("-");
                string creator = newTeams[0];
                string teamName = newTeams[1];
                if (teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Teams team = new Teams() { Creator = creator, TeamName = teamName, Member = new List<string>() };
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
            string[] addMembers = Console.ReadLine().Split("->");
            while (addMembers[0] != "end of assignment")
            {
                string member = addMembers[0];
                string teamName = addMembers[1];

                if (!teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }

                else if (teams.Any(x => x.Member.Contains(member)) || teams.Any(x => x.Creator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                }

                else
                {
                    Teams currTeam = teams.First(x => x.TeamName == teamName);
                    currTeam.Member.Add(member);
                }
                addMembers = Console.ReadLine().Split("->");
            }

            IEnumerable<Teams> finalTeams = teams.Where(x => x.Member.Count > 0);
            IEnumerable<Teams> bannedTeams = teams.Where(x => x.Member.Count == 0);

            foreach (Teams team in finalTeams.OrderByDescending(x => x.Member.Count).ThenBy(x => x.TeamName))
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Creator}");
                foreach (string member in team.Member.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");

            if (bannedTeams != null)
            {
                foreach (Teams teams1 in bannedTeams.OrderBy(x => x.TeamName))
                {
                    Console.WriteLine(teams1.TeamName);
                }
            }
        }
    }
}
