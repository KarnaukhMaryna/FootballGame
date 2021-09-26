using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Game_Model
{
    class TeamsOwner
    {
        public string name;
        public int honesty;
        public int sumForReferee;

        public TeamsOwner(string name)
        {
            this.name = name;
            Random rand = new Random();
            this.honesty = rand.Next(0, 2);
            switch (honesty)
            { 
             case 0:
                    this.sumForReferee = rand.Next(0, 201);
                    break;
            case 1:
                    this.sumForReferee = 0;
                    break;
            }

        }
    }
}
