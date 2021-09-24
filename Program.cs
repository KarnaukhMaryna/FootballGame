using System;
using System.Collections.Generic;

namespace Football_Game_Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach c1 = new Coach("DeZerbi");
            Team t1 = new Team("Shakhtar", c1);
            t1.list = new List<Footballer>();
            t1.AddFootballer("Pyatov", 37);
            t1.AddFootballer("Puzankov", 18);
            t1.AddFootballer("Marlos", 33);
            t1.AddFootballer("Stepanenko", 32);

            Coach c2 = new Coach("Luchkov");
            Team t2 = new Team("Metalist", c2);
            t2.list = new List<Footballer>();
            t2.AddFootballer("Dyomchenko", 24);
            t2.AddFootballer("Banada", 29);
            t2.AddFootballer("Fomin", 35);
            t2.AddFootballer("Rybka", 34);

            Console.WriteLine("Level of the team {0} is {1}", t1.team_name, t1.TeamLevel());
            Console.WriteLine("Level of the team {0} is {1}", t2.team_name, t2.TeamLevel());

            Referee r1 = new Referee("Ivanov");
            Console.WriteLine("Referee {0} has preference {1} ", r1.name, r1.preference);
            Game game = new Game(t1,t2,r1);
            game.ResultGame();

            Console.WriteLine();
            Console.WriteLine("All players from {0} team", t1.team_name);
            Team.ListAll(t1.list);

            Console.WriteLine();
            Console.WriteLine("All players from {0} team", t2.team_name);
            Team.ListAll(t2.list);

            Console.WriteLine();
            Console.WriteLine("Players over thirty years old from {0} team", t1.team_name);
            Team.ListOverThirty(t1.list);
            Console.WriteLine();
            Console.WriteLine("Players over thirty years old from {0} team", t2.team_name);
            Team.ListOverThirty(t2.list);


        }
    }
}
