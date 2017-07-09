using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCK_PAPER_SCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tournament 1
            // Side 1
            List<Match> t1s1 = new List<Match>();
            t1s1.Add(new Match(new Player("Armando", "P"), new Player("Dave", "S")));
            t1s1.Add(new Match(new Player("Richard", "R"), new Player("Michael", "S")));
            // Side 2
            List<Match> t1s2 = new List<Match>();
            t1s2.Add(new Match(new Player("Allen", "S"), new Player("Omer", "P")));
            t1s2.Add(new Match(new Player("David E.", "R"), new Player("Richard X.", "P")));

            List<Match[]> tournament1 = new List<Match[]>();
            tournament1.Add(t1s1.ToArray());
            tournament1.Add(t1s2.ToArray());
            Tournament t1 = new Tournament(tournament1);
            try
            {
                Player winner = t1.rps_tournament_winner();
                Console.WriteLine(string.Format("Tournament 1 Winner: {0} with move {1}!", winner.Name, winner.Strategy));
            }
            catch (WrongNumberOfPlayersError)
            {
                Console.WriteLine("Error: the number of players is not equal to 2");
            }
            catch (NoSuchStrategyError)
            {
                Console.WriteLine("Error: invalid strategy");
            }

            // Tournament 2

            // Side 1
            List<Match> t2s1 = new List<Match>();
            t2s1.Add(new Match(new Player("Armando", "r"), new Player("Dave", "P"))); 
            t2s1.Add(new Match(new Player("Richard", "P"), new Player("Michael", "R")));
            t2s1.Add(new Match(new Player("John", "S"), new Player("Jake", "P")));
            t2s1.Add(new Match(new Player("Jack", "P"), new Player("Steve", "R")));
            // Side 2
            List<Match> t2s2 = new List<Match>();
            t2s2.Add(new Match(new Player("Allen", "P"), new Player("Omer", "R")));
            t2s2.Add(new Match(new Player("David E.", "R"), new Player("Richard X.", "R")));
            t2s2.Add(new Match(new Player("Mike", "S"), new Player("Jamal", "P")));
            t2s2.Add(new Match(new Player("Hurley", "R"), new Player("Will.", "P")));

            List<Match[]> tournament2 = new List<Match[]>();
            tournament2.Add(t2s1.ToArray());
            tournament2.Add(t2s2.ToArray());
            Tournament t2 = new Tournament(tournament2);
            try
            {
                Player winner = t2.rps_tournament_winner();
                Console.WriteLine(string.Format("Tournament 2 Winner: {0} with move {1}!", winner.Name, winner.Strategy));
            }
            catch (WrongNumberOfPlayersError)
            {
                Console.WriteLine("Error: the number of players is not equal to 2");
            }
            catch (NoSuchStrategyError)
            {
                Console.WriteLine("Error: invalid strategy");
            }
            Console.ReadKey();

        }
    }
}
