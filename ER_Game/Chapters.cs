using System;
using static System.Console;

namespace ER_GameLibrary
{
    public class Chapters
    {
        
        public GameLayout CurrentLayout;
        public string[,] grid;
        public string gridname;
        
        public GameImages CurrentImages= new GameImages();
        public UserMenus CurrentMenu;
        public Player CurrentPlayer = new Player(2, 2);
        private GameDialogue CurrentDialogue = new GameDialogue();
        
        public int eventcounter = 0;
        public bool chap1 = false;
        public bool tchap1 = false;
        public  bool chap2 = false;
        public bool chap3 = false;
        public bool chap4 = false;
        public bool chap5 = false;
        Random rand = new Random();


        public void Chapter(Player player, GameImages images)
        {
            //builds the chapter images and gameplay. Grid takes the .txt and populates a two-dimensional jagged array 
            Clear();
            CurrentPlayer = player;
            grid = GameImages.ParseFileToArray($"{gridname}");// creates grid. using enum
            CurrentLayout = new GameLayout(grid);
            CurrentImages = images;
            CurrentMenu = new UserMenus();
            //run the world
            RunGameLoop();
        }
        
        public void HandlePlayerInput()//handles key input
        {//tutorial presented by Michael Hadley on youtube: ITP SP20: Creating an Explorable Maze in a C# Console Game 

            ConsoleKey key;// get only the most recent key press
            do
            {
                ConsoleKeyInfo keyInfo = ReadKey(true);
                key = keyInfo.Key;

            } while (KeyAvailable);// loop that ensures proper keys are pressed. 

            switch (key)
            {
                
               
                case ConsoleKey.F1:
                    Clear();
                    CurrentImages.TitlePage();
                    CurrentImages.MainMenu();

                    bool mainMenu = true;
                    while (mainMenu)
                    {
                        SetCursorPosition(113, 34);
                        mainMenu = CurrentMenu.MainMenu(CurrentImages);
                    }
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



        private void RunGameLoop()//tutorial presented by Michael Hadley on youtube: ITP SP20: Creating an Explorable Maze in a C# Console Game 
        { // allows the landscape to continue generating when the player goes through it.
            // counts stops player from being able to collect unlimited amount of drops.
            int coincount = 0;
            int healthcount = 0;
            int powercount = 0;
            int armorcount = 0;
            int beetcount = 0;
            


            Clear();
            
            SetCursorPosition(2, 38); ForegroundColor = ConsoleColor.White; WriteLine(@"Press (F1) to exit game");
            if (chap2 == true && chap3 == true && chap4 == true && chap5 == true)
            {
                // once the player beats the final boss, the game ends with the following methods.
               
                
            }

               
            while (true)// while loop will break depending on the elementAtPlayerPos.
            {
                
                CursorVisible = false;// hide cursor
                SetCursorPosition(58, 45);
                CurrentLayout.Draw();// draw everything
                CurrentImages.AttributeMenu(CurrentPlayer);
                CurrentImages.ActionMenu(CurrentPlayer);
                CurrentPlayer.Draw();
                HandlePlayerInput();
                string elementAtPlayerPos = CurrentLayout.GetElementAt(CurrentPlayer.X, CurrentPlayer.Y);

                
                if (elementAtPlayerPos == "{" || elementAtPlayerPos == "}")//Triggers shop event
                { 
                    CurrentDialogue.Shop();
                    ConsoleKeyInfo keyInfo = ReadKey(true);
                    ConsoleKey key; key = keyInfo.Key;
                    

                    if (key == ConsoleKey.Y)
                    {
                        
                        Shopkeeper(CurrentPlayer, CurrentImages);
                    }
                    
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
                else if (elementAtPlayerPos == "$")//Coin Drop
                {
                    if (coincount == 0)
                    {
                        int coin = rand.Next(0, 50);
                        CurrentPlayer.Coin += coin;
                        SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You received {coin} coins!");
                        SetCursorPosition(54, 41); WriteLine("Press any key to continue...");
                        ReadKey();
                        coincount = 1;
                    }
                    else
                    {

                        SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You already picked up this loot!");
                        SetCursorPosition(54, 41); WriteLine("Press any key to continue...");
                        ReadKey();
                    }
                }
                else if (elementAtPlayerPos == "╬")//Health drop
                {
                    if (healthcount == 0)
                    {
                        int health;
                        if (CurrentPlayer.Health == 100)
                        {
                            health = 0;
                            CurrentPlayer.Health += health;
                            
                            SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"Your health is already full!");
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
                            
                            SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You received {health} health points!");
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
                    RandomEncounters();

                }
                else if (elementAtPlayerPos == "▄")// Beet Drops
                {
                    if (beetcount == 0)
                    {
                        int beets;
                        if (CurrentPlayer.Rejuvenation == 10)
                        {
                            beets = 0;
                            CurrentPlayer.Rejuvenation += beets;
                            
                            SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"Your beet stash is full!");
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
                            
                            SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You received {beets} rejuventation beets!");
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
                        CurrentPlayer.Attack += power;
                        
                        SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You received {power} attack points!");
                        SetCursorPosition(54, 41); WriteLine("Press any key to continue...");
                        ReadKey();
                        coincount = 1;
                    }
                    else
                    {

                        SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You already picked up this loot!");
                        SetCursorPosition(54, 41); WriteLine("Press any key to continue...");
                        ReadKey();
                        
                    }
                }
                else if (elementAtPlayerPos == "¥")//armor drop
                {
                    if (armorcount == 0)
                    {
                        int armor = rand.Next(0, 5);
                        CurrentPlayer.Armor += armor;
                        
                        SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; CurrentDialogue.PrintbyChar($"You received {armor} armor points!");
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
            
            CurrentImages.ShopKeeperImage();
            CurrentMenu.ShopkeeperMethod(CurrentPlayer, CurrentImages);
            
            
        }
        public void RandomEncounters()
        {
            switch (rand.Next(0,2))
            {
                case 0:
                    string name = "Lower Minion";
                    int p = rand.Next(0, 5);
                    int h = rand.Next(15, 50);
                    int a = rand.Next(2, 6);
                    int j = rand.Next(0, 4);
                    Clear();
                    CurrentDialogue.Encounter();
                    Enemies enemies = new Enemies(name, p, h, a);
                    ChapBoss(CurrentPlayer, CurrentImages, CurrentDialogue, enemies, CurrentMenu);
                    CurrentPlayer.Junk += j;
                    SetCursorPosition(58, 44); ForegroundColor = ConsoleColor.White;WriteLine($"Before you walk away, you realize that you can make a profit selling their clothes and items!");
                    SetCursorPosition(58, 45); ForegroundColor = ConsoleColor.White; WriteLine($"You pick up {j} junk items!");
                    SetCursorPosition(54, 46); WriteLine("Press any key to continue...");
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    name = "Upper Minion";
                     p = rand.Next(2, 10);
                    h = rand.Next(20, 70);
                     a = rand.Next(5, 9);
                    j = rand.Next(0, 8);
                    Clear();
                    CurrentDialogue.Encounter();
                    Enemies RAM = new Enemies(name, p, h, a);
                    ChapBoss(CurrentPlayer, CurrentImages, CurrentDialogue, RAM, CurrentMenu);
                    CurrentPlayer.Junk += j;
                    SetCursorPosition(58, 44); ForegroundColor = ConsoleColor.White;WriteLine($"Before you walk away, you realize that you can make a profit selling their clothes and items!");
                    SetCursorPosition(58, 45); ForegroundColor = ConsoleColor.White;WriteLine($"You pick up {j} junk items!");
                    SetCursorPosition(54, 46); WriteLine("Press any key to continue...");
                    ReadKey();
                    Clear();
                    break;
            }
          
                 
                    

        }
        public void ChapBoss(Player player, GameImages images, GameDialogue dialogue, Enemies enemies, UserMenus menu)
        {

            Clear();
            
            menu.StoryFightMenu(CurrentPlayer, enemies, images,dialogue);

        }

        
        public void SpaceTravel()// loads the maps according to the chapter.
        {
            if (tchap1 == false)
            {
                gridname = "FI_Chap1.txt";
                tchap1 = true;
                eventcounter = 0;
                Clear();
                CurrentDialogue.Chapter1();
                CurrentImages.Beginning(CurrentDialogue);
               
                Chapter(CurrentPlayer, CurrentImages);
            }

            else if (tchap1==true && chap2 == false)
            {
                gridname = "maze1.txt";
                chap2 = true;
                eventcounter = 0;
                Clear();
                CurrentImages.Flight(CurrentDialogue);
                CurrentDialogue.Chapter2();
                Chapter(CurrentPlayer, CurrentImages);
            }
            else if (chap2 == true && chap3 == false)
            {
                gridname = "maze2.txt";
                chap3 = true;
                eventcounter = 0;
                Clear();
                CurrentDialogue.Chapter2End();
                CurrentImages.Flight(CurrentDialogue);
                CurrentDialogue.Chapter3();
                Chapter(CurrentPlayer, CurrentImages);
            }
            else if (chap2 == true && chap3 == true && chap4 == false)
            {
                gridname = "maze3.txt";
                chap4 = true;
                eventcounter = 0;
                Clear();
                CurrentDialogue.Chapter3End();
                CurrentImages.Flight(CurrentDialogue);
                CurrentDialogue.Chap4Dialouge();
                Chapter(CurrentPlayer, CurrentImages);
            }
            else if (chap2 == true && chap3 == true && chap4 == true && chap5 == false)
            {
                eventcounter = 0;
                gridname = "maze5.txt";
                CurrentDialogue.Chap4End();
                CurrentImages.Flight(CurrentDialogue);
                CurrentDialogue.Chap5Dialouge();
                Chapter(CurrentPlayer, CurrentImages);
            }   Clear();

            


        }
        public void ChapterBosses()
        {
            

            CurrentDialogue.StartEvent();
            ConsoleKeyInfo keyInfo = ReadKey(true);
            ConsoleKey key; key = keyInfo.Key;
            // check if event count is set to 1. 
            // if event count is set to 0, then Y option N option
            // if event count is set to 1,  statement will conclude.
            switch (key)
            {
                case ConsoleKey.Y:

                    if (chap1 == false)
                    {
                        string name = "Orcil";
                        Enemies Chp1 = new Enemies(name, 10, 50, 15);
                        ChapBoss(CurrentPlayer, CurrentImages, CurrentDialogue, Chp1, CurrentMenu);
                        Clear();
                        CurrentImages.Escape();
                        CurrentDialogue.Escape();
                        Clear();
                        eventcounter = 1; 
                        chap1 = true;
                    }
                    else if (chap1 == true && chap2 == false)
                    {
                        string name = "Thruul";
                        Enemies Chp2 = new Enemies(name, 15, 75, 20);
                        ChapBoss(CurrentPlayer, CurrentImages, CurrentDialogue, Chp2, CurrentMenu);
                        Clear();
                        CurrentImages.Escape();
                        CurrentDialogue.Escape();
                        Clear();
                        chap2 = true;
                        eventcounter = 1;
                    }
                    else if (chap1 == true && chap2 == true && chap3 == false)
                    {
                        string name = "Yilkir";
                        Enemies Chp3 = new Enemies(name, 15, 100, 25);
                        ChapBoss(CurrentPlayer, CurrentImages, CurrentDialogue, Chp3, CurrentMenu);
                        Clear();
                        CurrentImages.Escape();
                        CurrentDialogue.Escape();
                        Clear();
                        chap3 = true;
                        eventcounter = 1;
                    }
                    else if (chap1 == true && chap2 == true && chap3 == true && chap4 == false)
                    {
                        string name = "Yilkir";
                        Enemies Chp4 = new Enemies(name, 20, 150, 25);
                        ChapBoss(CurrentPlayer, CurrentImages, CurrentDialogue, Chp4, CurrentMenu);
                        Clear();
                        CurrentImages.Escape();
                        CurrentDialogue.Escape();
                        Clear();
                        
                        chap4 = true;
                        eventcounter = 1;
                    }
                    else if (chap1 == true && chap2 == true && chap3 == true && chap4 == true && chap5 == false)
                    {
                        string name = "Bailmaith";
                        Enemies Chp5 = new Enemies(name, 25, 200, 25);
                        ChapBoss(CurrentPlayer, CurrentImages, CurrentDialogue, Chp5, CurrentMenu);
                        Clear();
                        chap5 = true;
                        CurrentImages.Ending();
                        CurrentDialogue.Ending();
                        SetCursorPosition(58, 40); WriteLine("You beat the game! Now you can explore or start the game all over!");
                        SetCursorPosition(54, 41); WriteLine("Press any key to continue...");
                        ReadKey(); 
                        Clear();
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

