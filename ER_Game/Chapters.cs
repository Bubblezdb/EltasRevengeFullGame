using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Console;

namespace ER_GameLibrary
{
    public class Chapters
    {
        private Player CurrentPlayer;
        private GameLayout CurrentLayout;
        private PlayerControls CurrentControls;
        private Items CurrentItems;
        private GameImages CurrentImages;
        private UserMenus CurrentMenu;
        private GameDialogue CurrentDialogue = new GameDialogue();
        Random rand = new Random();


        public void Chapter1(Player player,GameImages images)
        {
            CurrentPlayer = player;
            string[,] grid = GameImages.ParseFileToArray("maze1.txt ");// creates grid. using enum
            CurrentLayout = new GameLayout(grid);
            CurrentControls = new PlayerControls();
            CurrentItems = new Items();
            CurrentImages = images;
            CurrentMenu = new UserMenus(); 
            RunGameLoop(CurrentPlayer,CurrentItems,CurrentLayout, CurrentControls,CurrentMenu);
            // add game menu and narrative.
            

        }

        private void RunGameLoop(Player player,Items items, GameLayout gameLayout, PlayerControls playerControls, UserMenus menu)// allows the maze to continue generating when the player goes through it.
        {
            
            Clear();
            gameLayout.Draw();
            CurrentImages.AttributeMenu();
            items.Draw();

            string elementAtPlayerPos = gameLayout.GetElementAt(player.X, player.Y);
            while (true)
            {
                
                //check for player input from keyboard and move the player
                CurrentPlayer.Draw();
                CurrentMenu.PlayerStats(CurrentPlayer);
               CurrentControls.HandlePlayerInput(CurrentPlayer, gameLayout);
                if (elementAtPlayerPos == "{" || elementAtPlayerPos == "}")// This is how to break the loop to exit
                {
                    Shopkeeper();
                }
                else if (elementAtPlayerPos == "$")
                {
                    player.Coin += rand.Next(0, 5);
                }
            }
            
        }
        public void Shopkeeper()
        {

        }
    }
}

