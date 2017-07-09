using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCK_PAPER_SCISSORS
{
    public class Player
    {
        public string Name { get; set; }
        public string Strategy { get; set; }

        public Player(string name, string strategy)
        {
            this.Name = name;
            this.Strategy = strategy;
        }
    }
}
