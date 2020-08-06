using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Text;
using System.Threading;
using static System.Console;

namespace ER_GameLibrary
{
    public class Chapters
    {
        public Player CurrentPlayer;
        public GameLayout CurrentLayout;
        public string[,] grid;
        public string gridname= "FI_Chap1.txt";
        private Encounters CurrentEncounter = new Encounters();
        public GameImages CurrentImages;
        public UserMenus CurrentMenu;
        private GameDialogue CurrentDialogue = new GameDialogue();
        public int eventcounter = 0;
        public bool chap1 = false;
       public  bool chap2 = false;
       public bool chap3 = false;
        public bool chap4 = false;
       public bool chap5 = false;

        Random rand = new Random();


        public void Chapter(Player player, GameImages images)
        {
            Clear();
            CurrentPlayer = player;
            grid = GameImages.ParseFileToArray($"{gridname}");// creates grid. using enum
            CurrentLayout = new GameLayout(grid);


            CurrentImages = images;
            CurrentMenu = new UserMenus();

            //run the world
            CurrentImages.Beginning(CurrentDialogue);
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

            } while (KeyAvailable);// loop that ensures proper keys are pressed. 

            switch (key)
            {
                case ConsoleKey.J:
                    CurrentImages.HelpMenu();
                    break;
                case ConsoleKey.K:
                    CurrentImages.HelpMenuClear();
                    break;
                case ConsoleKey.Escape:
                    CurrentImages.ExitMenu();
                    break;
                case ConsoleKey.Tab:
                    CurrentImages.ExitMenuClear();
                    break;

                //shooter keys.....if they are can be used

                case ConsoleKey.UpArrow:
                    if (CurrentLayout.IsPositionWalkable(CurrentPlayer.X, CurrentPlayer.Y - 1))
                    {
                        //states, if the world is position walkable above the player, then they can walk.

                        CurrentPlayer.Y -= 1;

                    }

                    break;
                case ConsoleKey.DownArrow:
                    if (CurrentLayout.IsPositionWalkable(CurrentPlayer.X, CurrentPlayer.Y + 1))
                    {//states, if the world is position walkable below the player, then they can walk.

                        CurrentPlayer.Y += 1;

                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (CurrentLayout.IsPositionWalkable(CurrentPlayer.X - 1, CurrentPlayer.Y))
                    {//states, if the world is position walkable right of the player, then they can walk.

                        CurrentPlayer.X -= 1;
                    }

                    break;
                case ConsoleKey.RightArrow:
                    if (CurrentLayout.IsPositionWalkable(CurrentPlayer.X + 1, CurrentPlayer.Y))
                    { //states, if the world is position walkable left of the player, then they can walk.

                        CurrentPlayer.X += 1;

                    }
                    break;
                default:
                    break;
            }

        }



        private void RunGameLoop()// allows the landscape to continue generating when the player goes through it.
        {

            int coincount = 0;
            int healthcount = 0;
            int powercount = 0;
            int armorcount = 0;
            int beetcount = 0;
            


            Clear();



            while (true)
            {
                // draw everything else
                CursorVisible = false; // hide cursor
                CurrentLayout.Draw();
                CurrentImages.AttributeMenu(CurrentPlayer);
                CurrentImages.ActionMenu(CurrentPlayer);
                CurrentPlayer.Draw();
                HandlePlayerInput();
                string elementAtPlayerPos = CurrentLayout.GetElementAt(CurrentPlayer.X, CurrentPlayer.Y);

                
                if (elementAtPlayerPos == "{" || elementAtPlayerPos == "}")//Triggers shop event
                {
                    ConsoleKeyInfo keyInfo = ReadKey(true);
                    ConsoleKey key; key = keyInfo.Key;
                    CurrentDialogue.Shop();

                    if (key == ConsoleKey.Y)
                    {
                        CurrentImages.ShopKeeperImage(CurrentDialogue);
                        //Shopkeeper(CurrentPlayer, CurrentImages);
                    }
                    // slows down the speed so it doesn't disappear too fast
                }
                else if (elementAtPlayerPos == ">")// Triggers Boss Fight
                {
                    if(eventcounter== 0)
                    {
                        
                        ChapterBosses();
                    }
                    
                    else
                    {
                        SetCursorPosition(58, 40); WriteLine("You already beat this boss, but his goons took off with Irno!");
                        SetCursorPosition(58, 41); WriteLine("You should get into your spaceship and chase after them!");
                        SetCursorPosition(54, 42); WriteLine("Press any key to continue...");

                        ReadKey();
                    }
                }
                else if (elementAtPlayerPos == "<")// Triggers space adventure
                {
                    CurrentDialogue.Travel();
                    ConsoleKeyInfo keyInfo = ReadKey(true);
                    ConsoleKey key; key = keyInfo.Key;
                    if (eventcounter == 1)
                    {//if count if event count is set to 1,
                         
                        switch(key)
                        { 
                            case ConsoleKey.Y:
                            SpaceTravel(); // leads to next chapter and eventcounter reset
                            break;
                            case ConsoleKey.N:
                            break;
                            default:
                            break;

                        }
                    }
                    else
                    {
                        CurrentDialogue.TravelOnHold();
                        ReadKey();
                    }
                       
                   

                }
                else if (elementAtPlayerPos == "$")
                {//Coin Drop
                    if (coincount == 0)
                    {
                        int coin = rand.Next(0, 50);
                        CurrentPlayer.Coin += coin;

                        SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You received {coin}!");
                        SetCursorPosition(54, 41); WriteLine("Press any key to continue...");
                        ReadKey();// slows down the speed so it doesn't disappear too fast
                        coincount = 1;
                    }
                    else
                    {

                        SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You already picked up this loot!");
                        SetCursorPosition(54, 41); WriteLine("Press any key to continue...");
                        ReadKey();// slows down the speed so it doesn't disappear too fast
                    }
                }
                else if (elementAtPlayerPos == "╬")
                {//Health drop
                    if (healthcount == 0)
                    {
                        int health;
                        if (CurrentPlayer.Health == 100)
                        {
                            health = 0;
                            CurrentPlayer.Coin += health;
                            SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You received {health}!");
                            SetCursorPosition(54, 41); WriteLine("Press any key to continue...");
                            ReadKey();
                        }
                        else if (CurrentPlayer.Health < 100)
                        {
                            if (CurrentPlayer.Health < 50)
                            {
                                health = rand.Next(0, 49);
                            }
                            else
                            {
                                int healthDiff = 100 - CurrentPlayer.Health;
                                health = healthDiff;
                                CurrentPlayer.Health += health;

                            }
                            SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You received {health}!");
                            SetCursorPosition(54, 41); WriteLine("Press any key to continue...");
                            ReadKey();
                        }
                        healthcount = 1;
                    }
                    else
                    {

                        SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You already picked up this loot!");
                        SetCursorPosition(54, 41); WriteLine("Press any key to continue...");
                        ReadKey();
                    }
                }
                else if (elementAtPlayerPos == "?")// Triggers encounters
                {
                    //if statement that triggers elemental and upper minions

                }
                else if (elementAtPlayerPos == "☼")// Beet Drops
                {
                    if (beetcount == 0)
                    {
                        int beets;
                        if (CurrentPlayer.Rejuvenation == 10)
                        {
                            beets = 0;
                            CurrentPlayer.Coin += beets;
                            SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You received {beets}!");
                            SetCursorPosition(54, 41); WriteLine("Press any key to continue...");
                            ReadKey();
                        }
                        else if (CurrentPlayer.Rejuvenation < 10)
                        {
                            if (CurrentPlayer.Rejuvenation < 5)
                            {
                                beets = rand.Next(0, 4);
                            }
                            else
                            {
                                int beetsDiff = 10 - CurrentPlayer.Rejuvenation;
                                beets = beetsDiff;
                                CurrentPlayer.Rejuvenation += beets;

                            }
                            SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You received {beets}!");
                            SetCursorPosition(54, 41); WriteLine("Press any key to continue...");
                            ReadKey();
                        }
                        beetcount = 1;
                    }
                    else
                    {

                        SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You already picked up this loot!");
                        SetCursorPosition(54, 41); WriteLine("Press any key to continue...");
                        ReadKey();
                    }
                }
                else if (elementAtPlayerPos == "╧")//attack drop
                {
                    if (powercount == 0)
                    {
                        int power = rand.Next(0, 5);
                        CurrentPlayer.Coin += power;

                        SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You received {power}!");
                        SetCursorPosition(54, 41); WriteLine("Press any key to continue...");
                        ReadKey();// slows down the speed so it doesn't disappear too fast
                        coincount = 1;
                    }
                    else
                    {

                        SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You already picked up this loot!");
                        SetCursorPosition(54, 41); WriteLine("Press any key to continue...");
                        ReadKey();
                        // slows down the speed so it doesn't disappear too fast
                    }
                }
                else if (elementAtPlayerPos == "¥")//armor drop
                {
                    if (armorcount == 0)
                    {
                        int armor = rand.Next(0, 5);
                        CurrentPlayer.Armor += armor;

                        SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You received {armor}!");
                        SetCursorPosition(54, 41); WriteLine("Press any key to continue...");
                        ReadKey();

                        armorcount = 1;
                    }
                    else
                    {

                        SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You already picked up this loot!");
                        SetCursorPosition(54, 41); WriteLine("Press any key to continue...");
                        ReadKey();

                    }
                }

                System.Threading.Thread.Sleep(20);

            }
        }

        public void Shopkeeper(Player player, GameImages images)
        {
            //CurrentMenu.Shopkeepermenu(CurrentPlayer);
        }
        public void RandomEncounters(Player player, GameImages images)
        {
            // encounterfights

        }
        public void ChapBoss(Player player, GameImages images, GameDialogue dialogue, Enemies enemies, UserMenus menu)
        {

            Clear();
            
            menu.StoryFightMenu(CurrentPlayer, enemies, images);

        }

        
        public void SpaceTravel()
        {
            
            
            if (chap2 == false)
            {
                gridname = "maze1.txt";
                chap2 = true;
                eventcounter = 0;
                Clear();
                SetCursorPosition(2, 2);
                Chapter(CurrentPlayer, CurrentImages);
            }
            else if (chap2 == true && chap3 == false)
            {
                gridname = "maze2.txt";
                chap3 = true;
                eventcounter = 0;
                Clear();
                SetCursorPosition(2, 2);
                Chapter(CurrentPlayer, CurrentImages);
            }
            else if (chap2 == true && chap3 == true && chap4 == false)
            {
                gridname = "maze3.txt";
                chap4 = true;
                eventcounter = 0;
                Clear();
                SetCursorPosition(2, 2);
                Chapter(CurrentPlayer, CurrentImages);
            }
            else if (chap2 == true && chap3 == true && chap4 == true && chap5 == false)
            {
                eventcounter = 0;
                gridname = "maze4.txt";
                
                Chapter(CurrentPlayer, CurrentImages);
            }   Clear();
            


        }
        public void ChapterBosses()
        {
            

            CurrentDialogue.StartEvent();
            ConsoleKeyInfo keyInfo = ReadKey(true);
            ConsoleKey key; key = keyInfo.Key;
            // check if event count is set to 1. 
            // if event count is set to 0, then Y option N opion
            // if event count is set to 1, else statement will conclude.
            switch (key)
            {
                case ConsoleKey.Y:

                    if (chap1 == false)
                    {
                        string name = "Orcil";
                        Enemies Chp1 = new Enemies(name, 10, 50, 15);
                        ChapBoss(CurrentPlayer, CurrentImages, CurrentDialogue, Chp1, CurrentMenu);
                        Clear();
                        chap1 = true;
                        eventcounter = 1;
                    }
                    else if (chap1 == true && chap2 == false)
                    {
                        string name = "Thruul";
                        Enemies Chp2 = new Enemies(name, 10, 50, 15);
                        ChapBoss(CurrentPlayer, CurrentImages, CurrentDialogue, Chp2, CurrentMenu);
                        Clear();
                        chap2 = true;
                        eventcounter = 1;
                    }
                    else if (chap1 == true && chap2 == true && chap3 == false)
                    {
                        string name = "Yilkir";
                        Enemies Chp3 = new Enemies(name, 10, 50, 15);
                        ChapBoss(CurrentPlayer, CurrentImages, CurrentDialogue, Chp3, CurrentMenu);
                        Clear();
                        chap3 = true;
                        eventcounter = 1;
                    }
                    else if (chap1 == true && chap2 == true && chap3 == true && chap4 == false)
                    {
                        string name = "Yilkir";
                        Enemies Chp4 = new Enemies(name, 10, 50, 15);
                        ChapBoss(CurrentPlayer, CurrentImages, CurrentDialogue, Chp4, CurrentMenu);
                        Clear();
                        chap4 = true;
                        eventcounter = 1;
                    }
                    else if (chap1 == true && chap2 == true && chap3 == true && chap4 == true && chap5 == false)
                    {
                        string name = "Bailmaith";
                        Enemies Chp5 = new Enemies(name, 10, 50, 15);
                        ChapBoss(CurrentPlayer, CurrentImages, CurrentDialogue, Chp5, CurrentMenu);
                        Clear();
                        chap5 = true;
                        SetCursorPosition(58, 40); WriteLine("You beat the game! Now you can explore or start the game all over!");
                        SetCursorPosition(54, 41); WriteLine("Press any key to continue...");
                        ReadKey();
                    }
                    

                    break;
                case ConsoleKey.N:
                    break;
                default:
                    break;
            }

           

        }
    }
}

