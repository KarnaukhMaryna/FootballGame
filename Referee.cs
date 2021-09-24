using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Game_Model
{
    class Referee
    {
        public string name;
        public int preference;

        public Referee(string name)
        {
            this.name = name;
            Random rand = new Random();
            this.preference = rand.Next(0, 3);
        }
    }
}
