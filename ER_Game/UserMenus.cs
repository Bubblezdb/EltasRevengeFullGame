using System;
using static System.Console;

namespace ER_GameLibrary
{
    public class UserMenus
    {
        Random rand = new Random();
        
        Chapters Chapters = new Chapters();

        public bool MainMenu(GameImages images)// Main Menu
        {
            try
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        
                        Chapters.SpaceTravel();
                        return true;

                    case "2":
                        Environment.Exit(2);
                        return false;
                    default:
                        return true;

                }

            }
            catch (FormatException e)
            {
                WriteLine("Invalid Entry", e.Message);
                return true;
            }


        }

      


        public void FightKeyHandling(Player player, Enemies enemy, GameImages images)
        {
            
            
            

            ConsoleKeyInfo keyInfo = ReadKey(true);
            ConsoleKey key; key = keyInfo.Key;

           
            switch (key)
            {
                case ConsoleKey.A://Attack
                    
                    int damage = enemy.Power - player.Armor;
                    int attack = rand.Next(0, player.Attack) + rand.Next(1, 4);//randomized damage value
                    if (damage < 0)
                        damage = 0;
                    SetCursorPosition(54, 40); WriteLine($"Elta wildy attacks, leaving herself open to take major damage from {enemy.Name} ");
                    SetCursorPosition(54, 41); WriteLine($"Tip, press defend to shield and attack at the same time");
                    SetCursorPosition(54, 42); WriteLine($"You lose  " + damage + "  health, and deal " + attack + "  damage");
                    SetCursorPosition(54, 43); WriteLine("Press any key to continue...");
                    player.Health -= damage;
                    if (player.Health < 0)
                        player.Health = 0;
                    enemy.Health -= attack;
                    if (enemy.Health < 0)
                        enemy.Health = 0;
                    images.AttributeMenu(player);
                    images.EnemyStats(enemy);

                    break;


                case ConsoleKey.D://Defend
                    
                    SetCursorPosition(54, 40); WriteLine($"Elta waits for {enemy.Name} to attack, but swiftly blocks only taking a");
                    SetCursorPosition(54, 41); WriteLine($" small amount of damage and dealing heavy damage to Ocil with his gaurd down:");
                    int defensedamage = (enemy.Power / 2) - player.Armor;
                    if (defensedamage < 0)
                        defensedamage = 0;
                    int counterattack = rand.Next(0, player.Attack * 2) + rand.Next(1, 4);
                    SetCursorPosition(54, 43); WriteLine("You lose  " + defensedamage + "  health, and deal  " + counterattack + "  damage");
                    SetCursorPosition(54, 44); WriteLine("Press any key to continue...");
                    player.Health -= defensedamage;
                    if (player.Health < 0)
                        player.Health = 0;
                    enemy.Health -= counterattack;
                    if (enemy.Health < 0)
                        enemy.Health = 0;
                    images.AttributeMenu(player);
                    images.EnemyStats(enemy);
                    break;

                case ConsoleKey.H:// heal
                    if (player.Rejuvenation == 0)
                    {
                        SetCursorPosition(54, 40); WriteLine("As you desperatly grasp for a beet in your sack, all that you feel is dirt");
                        int healingdamage = enemy.Power - player.Armor;
                        
                        player.Health -= healingdamage;
                        if (healingdamage < 0)
                            healingdamage = 0;
                        SetCursorPosition(54, 41); WriteLine($" {enemy.Name}  strikes you with a mighty blow and you lose  " + healingdamage + "  health!");
                        SetCursorPosition(54, 42); WriteLine("Press any key to continue...");
                    }
                    else
                    {
                        SetCursorPosition(54, 40); WriteLine("You reach into your sack and pull out a delicious beet. You devour it within seconds!");
                        int beetV = 10;
                        SetCursorPosition(54, 41); WriteLine("You gain " + beetV + " health");
                        SetCursorPosition(54, 42); WriteLine("Press any key to continue...");
                        player.Health += beetV;
                        player.Rejuvenation--;
                    }
                    images.AttributeMenu(player);
                    images.EnemyStats(enemy);
                    break;
                default:
                    break;

            }
        }


        public void StoryFightMenu(Player player, Enemies enemy, GameImages images,GameDialogue dialogue)
        {
            CursorVisible = false;
        restart:
            

            while (player.Health > 0 && enemy.Health> 0)
            {
                
                DrawFightMenu(player, enemy, images);
                SetCursorPosition(54, 40); WriteLine($" Press (A) to attack, (D) to Defend, (H) to heal....");
                ReadKey();
                SetCursorPosition(54, 40); WriteLine($"                                                                                      ");
                FightKeyHandling(player, enemy, images);
                
                ReadKey();

            }
            if (enemy.Health == 0)
            {
                DrawFightMenu(player, enemy, images);
                Kill(player, enemy,images, dialogue);
            }
            else if (player.Life > 0 && player.Health == 0)
            {

                DrawFightMenu(player, enemy, images);
                SetCursorPosition(54, 40); WriteLine($"You are dying. Do you have any elixirs? If so, press L to use it!");
                ConsoleKeyInfo keyInfo = ReadKey(true);
                ConsoleKey key; key = keyInfo.Key;
                switch (key)
                {
                    case ConsoleKey.L:

                        if (player.Life > 0)
                        {
                            images.ActionMenu(player);
                            SetCursorPosition(54, 40); WriteLine($"In a deperate attempt, you reach into your sack and pull out an elixir.");
                            SetCursorPosition(54, 41); WriteLine($"Glowing bright green, you chug it as quickly as possible.");
                            SetCursorPosition(54, 42); WriteLine($" Atlas! You feel brand new and ready to continue the fight!");
                            SetCursorPosition(54, 43); WriteLine("Press any key to continue...");
                            player.Life--;
                            player.Health += 40;
                            ReadKey();
                            goto restart;
                        }
                        break;
                    default:
                        Death(enemy, images,dialogue);
                        break;
                }
            }
            else if (player.Life == 0 && player.Health == 0)
            {
                Death(enemy, images, dialogue);

            }
        }
    


                  

   
            public void DrawFightMenu(Player player, Enemies enemy, GameImages images)
        {
            Clear();
            images.FightImage();
            images.EnemyStats(enemy);
            images.ActionMenu(player);
            images.BossFightMenu();
            images.AttributeMenu(player);
            
            
        }
    
        public void Death(Enemies enemy, GameImages images, GameDialogue dialogue)// when player dies
        {
            Clear();
            images.Death();
            SetCursorPosition(54, 40); WriteLine($"In a deperate attempt, you reach into your sack and see feel nothing.");
            SetCursorPosition(54, 41); WriteLine($"Feeling tired, you let your guard down {enemy.Name} deals the final blow. Dude you are dead!");
            SetCursorPosition(54, 42); WriteLine("Press any key to continue...");
            ReadKey();
            Clear();
            //go back to start menu
            images.TitlePage();
            images.MainMenu();

            bool mainMenu = true;
            while (mainMenu)
            {
                SetCursorPosition(113, 34);
                mainMenu = MainMenu(images);
            }

        }
       
       
        public void Kill(Player player, Enemies enemy, GameImages images, GameDialogue dialogue)// when player wins
        {
            
            int c = rand.Next(0, 45);
            SetCursorPosition(54, 40); Console.WriteLine($"As you stand vitorious over {enemy.Name}!");
            SetCursorPosition(54, 41); WriteLine($"You get ready to leave and spot gold coins around {enemy.Name}! You pick them up.");
            SetCursorPosition(54, 42); WriteLine("Press any key to continue...");
            ReadKey();
            
            player.Coin += c;
            
        }
        public void RandomEncounters()
        {
            
        }
         

    }
}
