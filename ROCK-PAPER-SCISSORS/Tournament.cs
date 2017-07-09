using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCK_PAPER_SCISSORS
{
    public class Tournament
    {
        public List<Match[]> ListMatches { get; private set; }
        public Match[] Matches { get; private set; }

        public Tournament(List<Match[]> matches)
        {
            this.ListMatches = matches;
        }

        public Tournament(Match[] matches)
        {
            this.Matches = matches;
        }

        public Player rps_tournament_winner()
        {
            if (this.ListMatches != null)
            {
                Tournament t1 = new Tournament(this.ListMatches[0]);
                Player winnerT1 = t1.rps_tournament_winner();
                Tournament t2 = new Tournament(this.ListMatches[1]);
                Player winnerT2 = t2.rps_tournament_winner();
                Match finalMatch = new Match(winnerT1, winnerT2);
                return finalMatch.rps_game_winner();
            }
            else if (this.Matches != null)
            {
                List<Match> resultMatches = new List<Match>();
                if (this.Matches.Length > 1)
                {
                    for (int i = 0; i < this.Matches.Length; i += 2)
                    {
                        Player winner1 = this.Matches[i].rps_game_winner();
                        Player winner2 = this.Matches[i + 1].rps_game_winner();
                        Match winnerMatch = new Match(winner1, winner2);
                        resultMatches.Add(winnerMatch);
                    }

                    Tournament t3 = new Tournament(resultMatches.ToArray());
                    return t3.rps_tournament_winner();
                }
                else
                {
                    return this.Matches[0].rps_game_winner();
                }
                
            }
            else
            {
                return null;
            }
        }
    }
}
