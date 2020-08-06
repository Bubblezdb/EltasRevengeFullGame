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
        public int AGRO;
        public int Saved;
        public string Name;
        
        // need attribute values
        public Enemies(string name, int power, int health, int armor)
        {
            Name = name;
            Power = power;
            Health = health;
            Armor = armor;
            
            
        }
        public void VakirLowerMinion()
        {
            //TODO

        }


        public void VIkirUpperMInion()
        {
            //TODO
        }
        public void Audinians()
        {
            //TODO

        }
    }
   

}
