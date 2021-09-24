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

        public Game (Team team1, Team team2, Referee referee)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.referee = referee;
        }

        public void ResultGame()
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

    }
}
