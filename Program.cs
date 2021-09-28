using System;
using System.Collections.Generic;

namespace Football_Game_Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach c1 = new Coach("DeZerbi");
            TeamsOwner o1 = new TeamsOwner("Akhmetov");
            Team t1 = new Team("Shakhtar", c1, o1);
            t1.list = new List<Footballer>();
            t1.AddFootballer("Pyatov", 37);
            t1.AddFootballer("Puzankov", 18);
            t1.AddFootballer("Marlos", 33);
            t1.AddFootballer("Stepanenko", 32);

            Coach c2 = new Coach("Luchkov");
            TeamsOwner o2 = new TeamsOwner("Yaroslavsky");
            Team t2 = new Team("Metalist", c2, o2);
            t2.list = new List<Footballer>();
            t2.AddFootballer("Dyomchenko", 24);
            t2.AddFootballer("Banada", 29);
            t2.AddFootballer("Fomin", 35);
            t2.AddFootballer("Rybka", 34);

            Console.WriteLine("Level of the team {0} is {1}", t1.team_name, t1.TeamLevel());
            Console.WriteLine("Level of the team {0} is {1}", t2.team_name, t2.TeamLevel());
            Console.WriteLine();
            Console.WriteLine("Honesty of the {0} coach is {1}", c1.name, c1.honesty);
            Console.WriteLine("Honesty of the {0} coach is {1}", c2.name, c2.honesty);
            Console.WriteLine();
            Console.WriteLine("Honesty of the {0} is {1}", o1.name, o1.honesty);
            Console.WriteLine("{0} give to referee {1} thousand dollars", o1.name, o1.sumForReferee);
            Console.WriteLine();
            Console.WriteLine("Honesty of the {0} is {1}", o2.name, o2.honesty);
            Console.WriteLine("{0} give to referee {1} thousand dollars", o2.name, o2.sumForReferee);
            Console.WriteLine();
            Referee r1 = new Referee("Ivanov");
            Console.WriteLine("Referee {0} has preference {1} ", r1.name, r1.preference);
            Console.WriteLine("Referee {0} honesty is {1} ", r1.name, r1.honesty);

            Game game = new Game(t1,t2,r1);
            Referee.HandlerFoul newFaul = new Referee.HandlerFoul();
            Referee.HandlerGoal newGoal = new Referee.HandlerGoal();

            Game.Foul += newFaul.Message;
            Game.Goal += newGoal.Message;
            
            try
            {
                game.ResultGame();
            }
            catch (GameException e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

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
