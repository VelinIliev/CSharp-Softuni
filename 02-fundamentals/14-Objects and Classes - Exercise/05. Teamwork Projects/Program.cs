using System;
using System.Linq;

namespace TeamworkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            List<string> users = new List<string>();
            List<Team> teams = new List<Team>();

            for (int i = 0; i < lines; i++)
            {
                string[] info = Console.ReadLine().Split("-").ToArray();
                
                string userName = info[0];
                string teamName = info[1];

                bool isTeamCreated = false;
                bool isUserCreatedAnotherTeam = false;
                
                foreach (Team t in teams)
                {
                    if (t.TeamName == teamName)
                    {
                        isTeamCreated = true;
                    }

                    if (t.TeamCreator == userName)
                    {
                        isUserCreatedAnotherTeam = true;
                    }
                }

                if (!users.Contains(userName))
                {
                    users.Add(userName);
                }

                if (isTeamCreated)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (isUserCreatedAnotherTeam)
                {
                    Console.WriteLine($"{userName} cannot create another team!");
                }
                else
                {
                    Team team = new Team(teamName, userName);
                    team.TeamCreator = userName;
                    teams.Add(team);
                    Console.WriteLine($"Team {team.TeamName} has been created by {userName}!");
                } 
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of assignment")
                {
                    break;
                }

                string[] info = input.Split("->").ToArray();
                string userName = info[0];
                string teamName = info[1];

                if (teams.Select(x => x.TeamName).Contains(teamName))
                {
                    bool isTeamMember = false;
                    
                    foreach (Team t in teams)
                    {
                        if (t.TeamMembers.Contains(userName) || t.TeamCreator == userName)
                        {
                            isTeamMember = true;
                            break;
                        }
                    }

                    if (!isTeamMember)
                    {
                        foreach (Team t in teams)
                        {
                            if (t.TeamName == teamName)
                            {
                                t.TeamMembers.Add(userName);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                
                
            }

            List<Team> filteredMembers = teams.Where(x => x.TeamMembers.Count > 0).ToList();
            
            List<Team> orderedTeams = filteredMembers
                .OrderByDescending(x => x.TeamMembers.Count)
                .ThenBy(x => x.TeamName)
                .ToList();

            foreach (Team t in orderedTeams)
            {
                Console.WriteLine(t.ToString());
            }

            List<Team> teamsToDisband = teams.Where(x => x.TeamMembers.Count == 0).ToList();
            List<Team> orderedTeamsToDisband = teamsToDisband.OrderBy(x => x.TeamName).ToList();
            Console.WriteLine("Teams to disband:");
            foreach (var t in orderedTeamsToDisband)
            {
               Console.WriteLine(t.TeamName);
            }
        }
    }
    
    class Team
    {
        public string TeamName {get; set;}
        public string  TeamCreator { get; set; }
        public List<string> TeamMembers = new List<string>();
    
        public Team(string teamName, string userName)
        {
            this.TeamName = teamName;
            this.TeamCreator = userName;
        }

        public override string ToString()
        {
            List<string> message = new List<string>();
            message.Add($"{this.TeamName}");
            message.Add($"- {this.TeamCreator}");
            
            if (TeamMembers.Count != 0)
            {
                List<string> orderedMembers = this.TeamMembers.OrderBy(x => x).ToList();
                foreach (string x in orderedMembers)
                {
                    message.Add($"-- {x}");
                }
            }
            return $"{string.Join("\n", message)}";
        }
    }
}