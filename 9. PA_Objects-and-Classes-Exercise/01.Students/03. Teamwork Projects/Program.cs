using System.Diagnostics.Metrics;

namespace _3._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] data = Console.ReadLine().Split("-");
                string creator = data[0];
                string teamName = data[1];

                if (teams.Values.Any(team => team.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    break;
                }

                    if (!teams.ContainsKey(teamName))
                    {
                            Team team = new Team(teamName, creator);
                            teams.Add(teamName, team);
                            Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    }
                    else
                    {
                      Console.WriteLine($"Team {teamName} was already created!");
                    }

            }

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] dataMembers = input.Split("->");
                string member = dataMembers[0];
                string teamToJoin = dataMembers[1];

                if (teams.ContainsKey(teamToJoin))
                {
                    if (teams[teamToJoin].Membres.Contains(member) || teams[teamToJoin].Creator.Equals(member)
                        || teams.Values.Any(team => team.Membres.Contains(member)))
                    {
                        Console.WriteLine($"Member {member} cannot join team {teamToJoin}!");
                       
                    }
                    else
                    {
                        teams[teamToJoin].Membres.Add(member);
                    }

                }
                else
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    
                }

                input = Console.ReadLine();

            }

            foreach (var team in teams.Where(t => t.Value.Membres.Count > 0)
                .OrderByDescending(t => t.Value.Membres.Count)
                .ThenBy(t => t.Key))
            {
                Console.WriteLine(team.Key);
                Console.WriteLine("- " + team.Value.Creator);

                foreach (string member in team.Value.Membres.OrderBy(m => m))
                {
                    Console.WriteLine("-- " + member);
                }
            }

            Console.WriteLine("Teams to disband:");
            
          
            foreach(var team in teams.OrderBy(t => t.Value.Name)
                .Where(t => t.Value.Membres.Count == 0))
            {
                Console.WriteLine(team.Key);
            }
        }
    }
}