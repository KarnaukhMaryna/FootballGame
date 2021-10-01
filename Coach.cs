using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Game_Model
{
    class Coach
    {
        public string name;
        public double level;
        public int honesty; //this field defines if the coach gives doping to his team

        public Coach(string name)
        {
            this.name = name;
            Random rand = new Random();
            double a = rand.NextDouble();
            if (a < 0.5)
            {
                this.level = 1 + a;
            }
            else this.level = a;
            this.honesty = rand.Next(0, 2);
        }
    }
}
