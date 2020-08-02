using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Console;

namespace ER_GameLibrary
{
    public class Chapters
    {
        public Player CurrentPlayer;
        public GameLayout CurrentLayout;
        
        public Items CurrentItems;
        public GameImages CurrentImages;
        public UserMenus CurrentMenu;
        private GameDialogue CurrentDialogue = new GameDialogue();
        Random rand = new Random();

        
        public void Chapter1(Player player,GameImages images)
        {
            CurrentPlayer = player;
            string[,] grid = GameImages.ParseFileToArray("FI_Chap1.txt ");// creates grid. using enum
            CurrentLayout = new GameLayout(grid);
            
            CurrentItems = new Items();
            CurrentImages = images;
            CurrentMenu = new UserMenus(); 

            //run the world 
            RunGameLoop();
            
            

        }
        public void HandlePlayerInput()//handles key input
        {
            // get only the most recent key press

            ConsoleKey key;
            do
            {
                ConsoleKeyInfo keyInfo = ReadKey(true);
                key = keyInfo.Key;

            } while (KeyAvailable);



            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (CurrentLayout.IsPositionWalkable(CurrentPlayer.X, CurrentPlayer.Y - 1))
                    {
                        //states, if the world is position walkable above the player, then they can walk.
                        CurrentPlayer.Clear();
                        CurrentPlayer.Y -= 1;



                    }

                    break;
                case ConsoleKey.DownArrow:
                    if (CurrentLayout.IsPositionWalkable(CurrentPlayer.X, CurrentPlayer.Y + 1))
                    {//states, if the world is position walkable below the player, then they can walk.
                        CurrentPlayer.Clear();
                        CurrentPlayer.Y += 1;

                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (CurrentLayout.IsPositionWalkable(CurrentPlayer.X - 1, CurrentPlayer.Y))
                    {//states, if the world is position walkable right of the player, then they can walk.

                        CurrentPlayer.Clear();
                        CurrentPlayer.X -= 1;

                    }

                    break;
                case ConsoleKey.RightArrow:
                    if (CurrentLayout.IsPositionWalkable(CurrentPlayer.X + 1, CurrentPlayer.Y))
                    { //states, if the world is position walkable left of the player, then they can walk.
                        CurrentPlayer.Clear();
                       CurrentPlayer.X += 1;


                    }
                    break;
                default:
                    break;
            }

        }

        private void RunGameLoop()// allows the landscape to continue generating when the player goes through it.
        {
            // code needs working on. Doesn't acknowledge map items
           


            
            // draw attribute menu
           
           
            

            
            while (true)
            { 
                // draw everything else
                //items.Draw();//
                Clear();
                CurrentImages.AttributeMenu(CurrentPlayer);
                CurrentLayout.Draw();
                CurrentPlayer.Draw();
                HandlePlayerInput();
                string elementAtPlayerPos = CurrentLayout.GetElementAt(CurrentPlayer.X, CurrentPlayer.Y);

                if (elementAtPlayerPos == "}" || elementAtPlayerPos == "}")// This is how to break the loop to exit
                {
                    Shopkeeper();// go to the store
                }
                else if (elementAtPlayerPos == ">" )// This is how to break the loop to exit
                {
                    // Go to CHp converstaion fightscene
                }
                else if (elementAtPlayerPos == "<")// This is how to break the loop to exit
                {
                    //go to space... Triggers planet jump or shooter
                }
                else if (elementAtPlayerPos == "$")
                {
                    int coin= rand.Next(0,50);
                    CurrentPlayer.Coin += coin;
                    //make drop disappear
                    SetCursorPosition(54, 40); ForegroundColor = ConsoleColor.White;WriteLine($"You received {coin}!");
                }
                 
                 System.Threading.Thread.Sleep(0);

            }
        }

        public void Shopkeeper()
        {
            CurrentMenu.Shopkeepermenu(CurrentPlayer);
        }
        

       
                
    }
}

