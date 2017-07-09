using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCK_PAPER_SCISSORS
{
    public class Match
    {
        public Player[] Players { get; set; }

        public Match(Player player1, Player player2)
        {
            this.Players = new Player[]{ player1, player2 };
        }

        public Match()
        {
            this.Players = null;
        }

        public Player rps_game_winner()
        {
            if (this.Players == null || this.Players.Length != 2 || this.Players.Contains(null))
            {
                throw new WrongNumberOfPlayersError();
            }
            string[] strategies = { "r", "p", "s" };
            string[] playersStrategies = { this.Players[0].Strategy.ToLower(), this.Players[1].Strategy.ToLower() };
            int winnerIndex = 0;

            if (!strategies.Contains(playersStrategies[0]) || !strategies.Contains(playersStrategies[1]))
            {
                throw new NoSuchStrategyError();
            }

            if (playersStrategies.Contains("r") && playersStrategies.Contains("s"))
            {
                winnerIndex = Array.IndexOf(playersStrategies, "r");
            }
            else if (playersStrategies.Contains("p") && playersStrategies.Contains("r"))
            {
                winnerIndex = Array.IndexOf(playersStrategies, "p");
            }
            else if (playersStrategies.Contains("s") && playersStrategies.Contains("p"))
            {
                winnerIndex = Array.IndexOf(playersStrategies, "s");
            }

            Player winner = this.Players[winnerIndex];
            return winner;
        }
    }
}
