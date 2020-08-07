using System;
using System.Collections.Generic;
using System.Text;

namespace ER_GameLibrary
{
    public class Enemies
    {
        public int Power;
        public int Health;
        public int Armor;
        public string Name;
        
        // need attribute values
        public Enemies(string name, int power, int health, int armor)
        {
            Name = name;
            Power = power;
            Health = health;
            Armor = armor;
            
            
        }
        
    }
   

}
