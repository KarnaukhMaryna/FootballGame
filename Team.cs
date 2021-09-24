using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Football_Game_Model
{
    class Team
    {
        public string team_name;
        public double team_level;
        public List<Footballer> list;
        public Coach coach;

        public Team(string team_name, Coach coach)
        {
            this.team_name = team_name;
            this.list = new List<Footballer>();
            this.coach = coach;
        }

        public void AddFootballer(string name, int age)
        {
            list.Add(new Footballer(name, age));
        }

        public double TeamLevel()
        {
            for (int i = 0; i < list.Count; i++)
            {
                team_level += list[i].level;
            }
            team_level *= coach.level;
            return Math.Round(team_level, 2);
        }

        public static void ListAll(List<Footballer> list)
        {
            var ListOfAll = from player in list
                            orderby player.name
                            select player;
            foreach (var player in ListOfAll)
            {
                Console.WriteLine("{0}, {1} years, level {2}",
                    player.name, player.age, player.level);
            }
        }

        public static void ListOverThirty(List<Footballer> list)
        {
            var ListOver = from player in list
                           where player.age > 30
                            orderby player.level descending 
                            select player;
            foreach (var player in ListOver)
            {
                Console.WriteLine("{0}, {1} years, level {2}",
                    player.name, player.age,  player.level);
            }
        }
    }
}
