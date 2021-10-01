using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Game_Model
{
    class TeamsOwner
    {
        public string name;
        public int honesty; //this field defines if the team's owner will give a bribe for the referee
        public int sumForReferee; //this field defines the sum of the bribe

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
