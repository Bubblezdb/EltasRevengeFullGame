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



            SetCursorPosition(0, 38); WriteLine($" Press (A) to attack, (D) to Defend, (H) to heal");
           

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


        public void StoryFightMenu(Player player, Enemies enemy, GameImages images, GameDialogue dialogue)
        {
            CursorVisible = false;
        restart:


            while (player.Health > 0 && enemy.Health > 0)
            {
                SetCursorPosition(58, 45);
                DrawFightMenu(player, enemy, images);
                SetCursorPosition(54, 40); WriteLine($" Press (A) to attack, (D) to Defend, (H) to heal....");
                SetCursorPosition(54, 40); WriteLine($"                                                                                      ");
                FightKeyHandling(player, enemy, images);
                ReadKey();

            }
            if (enemy.Health <1 )
            {
                DrawFightMenu(player, enemy, images);
                Kill(player, enemy, images, dialogue);
            }
            else if (player.Life > 0 && player.Health < 1)
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
                        Death(enemy, images, dialogue);
                        break;
                }
            }
            else if (player.Life == 0 && player.Health <1 )
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
            SetCursorPosition(54, 41); WriteLine($"You get ready to leave and spot gold coins around {enemy.Name}! You pick up {c} coins.");
            SetCursorPosition(54, 42); WriteLine("Press any key to continue...");
            ReadKey();
            player.Coin += c;

        }
        public void ShopkeeperMethod(Player player, GameImages images)
        {

            // Shopkepper method

            SetCursorPosition(105, 20); WriteLine("Shopkeeper: Welcome to my shop Ms. Traveler. ");
            SetCursorPosition(105, 20); WriteLine("How can I Help you.");
            SetCursorPosition(105, 21); WriteLine("Elta: Yea, show me what you got!");
            SetCursorPosition(105, 22); WriteLine("Would you like to buy or sell?.");
            SetCursorPosition(105, 37); WriteLine("(Enter S, D, G, or B to buy something)  ");
            SetCursorPosition(105, 38); WriteLine("Enter M to sell junk  ");
            SetCursorPosition(105, 23); WriteLine(" Press (ESC) to Exit.");
            CursorVisible = false;
            bool shop = true;
            while (shop == true)
            {

                images.ActionMenu(player);
                images.AttributeMenu(player);

                SetCursorPosition(105, 35); WriteLine($"You currently have {player.Coin} krubels ");
                
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                ConsoleKey key; key = keyInfo.Key;

                if (player.Coin == 0)
                {
                    player.Coin = 0;

                    SetCursorPosition(54, 40); WriteLine("Shopkeeper: You need krubels to buy things. Sell something or get out. ");
                    SetCursorPosition(54, 41); WriteLine("Press any key to continue");
                    ReadKey();
                    break;

                }
                else if (player.Coin > 1)
                {
                    switch (key)
                    {
                        case ConsoleKey.S: //sword
                            if (player.Coin < 500)
                            {
                                SetCursorPosition(54, 40); WriteLine("you don't have enough krubels, try again");
                                SetCursorPosition(54, 41); WriteLine("Press any key to continue");
                                ReadKey();
                            }
                            else if (player.Coin >= 500)
                            {
                                player.Coin -= 500;
                                player.Attack += 40;
                                player.Defense += 10;
                                SetCursorPosition(54, 40); WriteLine($"You now have {player.Coin} Krubels, {player.Defense} defense, and do {player.Attack} damage.");
                                SetCursorPosition(54, 41); WriteLine("Press any key to continue");
                                ReadKey();
                            }
                            break;

                        case ConsoleKey.D: //Dual_Pistols
                            if (player.Coin < 750)
                            {
                                SetCursorPosition(54, 40); WriteLine("you don't have enough krubels, try again");
                                SetCursorPosition(54, 41); WriteLine("Press any key to continue");
                                ReadKey();

                            }
                            else if (player.Coin >= 750)
                            {
                                player.Attack += 55;
                                player.Coin -= 750;
                                SetCursorPosition(54, 40); WriteLine($"You now have {player.Coin} Krubels and do {player.Attack} damage.");
                                SetCursorPosition(54, 41); WriteLine("Press any key to continue");
                                ReadKey();
                            }

                            break;
                        case ConsoleKey.G: //shotgun
                            if (player.Coin < 1000)
                            {
                                SetCursorPosition(54, 40); WriteLine("you don't have enough krubels, try again");
                                SetCursorPosition(54, 41); WriteLine("Press any key to continue");
                                ReadKey();
                            }
                            else if (player.Coin >= 1000)
                            {
                                player.Attack += 80;
                                player.Defense += 10;
                                player.Coin -= 1000;
                                SetCursorPosition(54, 40); WriteLine($"You now have {player.Coin} Krubels, {player.Defense} defense, and do {player.Attack} damage.");
                                SetCursorPosition(54, 41); WriteLine("Press any key to continue");
                                ReadKey();
                            }

                            break;

                        case ConsoleKey.B: //Beets
                            if (player.Coin < 10)
                            {
                                SetCursorPosition(54, 40); WriteLine("you don't have enough krubels, try again");
                                SetCursorPosition(54, 41); WriteLine("Press any key to continue");
                                ReadKey();
                            }
                            else if (player.Coin >= 10)
                            {
                                if (player.Rejuvenation < 10)
                                {
                                    player.Rejuvenation += 1;
                                    SetCursorPosition(54, 40); WriteLine($"You have {player.Rejuvenation} beets");
                                    player.Coin -= 10;
                                    SetCursorPosition(54, 41); WriteLine("Press any key to continue");
                                    ReadKey();
                                }
                                else
                                {
                                    SetCursorPosition(54, 40); WriteLine($"You are fully stocked with rejuvenating beets, my friend!");
                                    SetCursorPosition(54, 41); WriteLine("Press any key to continue");
                                    ReadKey();
                                }
                            }

                            break;


                        case ConsoleKey.M: //Moneybuyback
                            if (player.Junk > 0)
                            {
                                SetCursorPosition(54, 40); WriteLine(" I can give you all my junk");
                                int sell = player.Junk * 10;
                                SetCursorPosition(54, 40); WriteLine($"you earned ${sell} in junk buyback! ");
                                player.Coin += sell;
                                SetCursorPosition(54, 41); WriteLine("Press any key to continue");
                                ReadKey();

                            }
                            else if (player.Junk == 0)
                            {

                                SetCursorPosition(54, 40); WriteLine($"It looks like you don;t have any junk to sell!");
                                SetCursorPosition(54, 41); WriteLine("Press any key to continue");
                                ReadKey();
                            }
                            break;
                        case ConsoleKey.Escape: //Moneybuyback
                            shop = false;
                            SetCursorPosition(54, 40); WriteLine("Thanks for shopping!");
                            SetCursorPosition(54, 41); WriteLine("Press any key to continue");
                            ReadKey();
                            Clear();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}

                    
                        
                    
             
                    



                    
              
