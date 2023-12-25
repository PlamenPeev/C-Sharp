using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Teamwork_Projects
{
    public class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Membres { get; set; }

        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Membres = new List<string>();
        }
    }
}
