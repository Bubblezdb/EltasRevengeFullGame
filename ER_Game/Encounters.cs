using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ER_GameLibrary
{
    public class Encounters
    {
        public void Chap1Boss(Player player, GameImages images, GameDialogue dialogue, Enemies enemies, UserMenus menu)
        {

            Clear();
            //graphics
             
            
            while(true)
            {
                Clear();
            images.BossFightMenu();
            images.EnemyStats(enemies);
            images.ActionMenu(player);
            images.AttributeMenu(player);
            menu.StoryFightMenu(player, enemies, images);//fight menu
                System.Threading.Thread.Sleep(20);
            }
            
            //
            

        }
       
        public void RandomEncounters(Player player, GameImages images)
        {
            // encounterfights
        }

        //public void Chap2Boss(Player player, GameImages images, GameDialogue dialogue, Enemies enemies)
        //{
        //    string name = "Thruul";
        //    Enemies Chp2 = new Enemies(name, 43, 200, 15);
        //    //graphics
        //   images.BossFightMenu();
        //    //fight menu
        //    CurrentMenu.StoryFightMenu(CurrentPlayer, Chp2, CurrentImages);
        //}
        //public void Chap3Boss(Player player, GameImages images, GameDialogue dialogue, Enemies enemies)
        //{
        //    string name = "Yilkir";
        //    Enemies Chp3 = new Enemies(name, 43, 200, 15);
        //    //graphics
        //    CurrentImages.BossFightMenu();
        //    //fight menu
        //    CurrentMenu.StoryFightMenu(CurrentPlayer, Chp3, CurrentImages);
        //}
        //public void Chap4Boss(Player player, GameImages images, GameDialogue dialogue, Enemies enemies)
        //{
        //    string name = "Tanquin";
        //    Enemies Chp4 = new Enemies(name, 43, 200, 15);
        //    //graphics
        //    CurrentImages.BossFightMenu();
        //    //fight menu
        //    CurrentMenu.StoryFightMenu(CurrentPlayer, Chp4, CurrentImages);
        //}
        //public void Chap5Boss(Player player, GameImages images, GameDialogue dialogue, Enemies enemies)
        //{
        //    string name = "Bailmaith";
        //    Enemies Chp5 = new Enemies(name, 43, 200, 15);
        //    //graphics
        //    CurrentImages.BossFightMenu();
        //    //fight menu
        //    CurrentMenu.StoryFightMenu(CurrentPlayer, Chp5, CurrentImages);
        //}

    }
    
}
