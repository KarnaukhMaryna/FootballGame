using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Game_Model
{
    class Game
    {
        public Team team1;
        public Team team2;
        public Referee referee;

        public delegate void Football();

        public static event Football Foul;
        public static event Football Goal;

        public Game (Team team1, Team team2, Referee referee)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.referee = referee;
        }

        public void StartGame()
        {
            Random rand = new Random();
            int f = rand.Next(0, 2);
            int g = rand.Next(0, 2);
            if (f == 1)
            {
                Foul();
            }
            if (g == 1)
            {
                Goal();
            }
        }

        public void HonestGame() 
        {
            double l1 = team1.TeamLevel();
            double l2 = team2.TeamLevel();
            switch (referee.preference)
            {
                case 1:
                    l1 += 40;
                    Console.WriteLine("40 points added to {0} team", team1.team_name);
                    break;
                case 2:
                    l2 += 40;
                    Console.WriteLine("40 points added to {0} team", team2.team_name);
                    break;
            }
            if (((l1 - l2) / l2 * 100) > 10)
            {
                Console.WriteLine("{0} team is winner ", team1.team_name);
            }
            else if (((l2 - l1) / l1 * 100) > 10)
            {
                Console.WriteLine("{0} team is winner ", team2.team_name);
            }
            else
                Console.WriteLine("Draw");

        }

        public void ResultGame()
        {
            double l1 = team1.TeamLevel();
            double l2 = team2.TeamLevel();
            if(referee.honesty == 1)
            {
                if (team1.coach.honesty ==1 && team2.coach.honesty == 1) //both coaches don't give doping to their teams
                {
                    StartGame();
                    HonestGame();
                }
                else if(team1.coach.honesty == 0 && team2.coach.honesty == 1) //coach of the first team gives doping to his teams
                {
                    Console.WriteLine("{0} team has technical win, because {1} team uses doping", team2.team_name, team1.team_name);
                    throw new GameException();   
                }
                else if(team2.coach.honesty == 0 && team1.coach.honesty == 1) //coach of the second team gives doping to his teams
                {
                    Console.WriteLine("{0} team has technical win, because {1} team uses doping",team1.team_name, team2.team_name);
                    throw new GameException();
                }
                else if (team1.coach.honesty == 0 && team2.coach.honesty == 0) //both coaches give doping to their teams
                {
                    Console.WriteLine("There are no winners.");
                    throw new GameException();
                }
            }
            else
            {
                if (team1.owner.sumForReferee > team2.owner.sumForReferee) // the owner of first team gives more money to the referee and get the win
                {
                    Console.WriteLine("{0} team is winner, because their owner pays more money.", team1.team_name);
                }
                else if (team2.owner.sumForReferee > team1.owner.sumForReferee) // the owner of second team gives more money to the referee and get the win
                {
                    Console.WriteLine("{0} team is winner, because their owner pays more money.", team2.team_name);
                }
                else
                {
                    StartGame();
                    HonestGame();
                }
            }
        }

    }
}
