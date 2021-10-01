using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Game_Model
{
    class Referee
    {
        public string name;
        public int preference;
        public int honesty; //the field defines if the referee will take bribes from the teams' owners

        public Referee(string name)
        {
            this.name = name;
            Random rand = new Random();
            this.preference = rand.Next(0, 3);
            this.honesty = rand.Next(0, 2);
        }

        public class HandlerFoul
        {
            public void Message()
            {
                Console.WriteLine("Referee shows a yellow card to the offending team!");
            }
        }

        public class HandlerGoal
        {
            public void Message()
            {
                Console.WriteLine("Referee scores the goal!");
            }
        }
    }
}
