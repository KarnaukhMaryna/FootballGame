using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Game_Model
{
    class Footballer
    {
        public string name;
        public int age;
        public int level { get; }
        
        

        public Footballer( string name, int age)
        {
            this.name = name;
            this.age = age;
            Random rand = new Random();
            level = rand.Next(0, 101);           
        }

        public override string ToString()
        {
            return string.Format($"{name} {age} {level}");
            
        }
    }
}
