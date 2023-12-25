using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Pokemon_Trainer
{
    public class Trainer
    {

        public string Name { get; set; }    
        public int NumberOfBadges {  get; set; }
        public List<Pokemon> Pokemons { get; set; }


        public Trainer() { }
        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.Pokemons = new List<Pokemon>();
        }
    }
}
