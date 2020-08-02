using System;
using static System.Console;

namespace ER_GameLibrary
{
    public class UserMenus
    {
        Random rand = new Random();
        public Player CurrentPlayer; 
        Chapters Chapters = new Chapters();//istantiate the chapters here?

        public bool MainMenu(GameImages images)// works
        {
            try
            {
                    switch(Console.ReadLine())
                {
                    case "1":
                        CurrentPlayer = new Player(2, 2);
                        Chapters.Chapter1(CurrentPlayer,images);
                        return true;
                    
                    case "2":
                        Environment.Exit(2);
                        return false;
                    
                    case "3":
                        //call credits
                        return true;
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

        public void ShowMercyOption()
        {
            SetCursorPosition(54, 40); WriteLine("Enter 1 to spare him, Enter 2 to kill him.");
            int saveCount = 2;
            int enterAnswer = int.Parse(Console.ReadLine());
            if (enterAnswer == 1) //SPARE OPTION
            {
                 WriteLine("I don't want to see your face again, run and tell your boys that I'm coming");
                saveCount++;
            }
            else if (enterAnswer == 2) //KILL OPTION
            {
                 WriteLine("Enter a catchphrase before you kill ");
                string catchphrase = Console.ReadLine();
                 WriteLine("Elta:" + catchphrase);
            }
        }


        public void StoryFightMenu( Player player,Enemies enemy,GameImages images)
        {
                while (player.Health > 0)
                {
                    string input = ReadLine();
                    if (input.ToLower() == "a"/*enum */ || input.ToLower() == "attack")/*enum */
                    {
                        //Attack
                        int damage = enemy.Power - player.Armor;
                        int attack = rand.Next(0, player.Attack) + rand.Next(1, 4);//randomized damage value
                        if (damage < 0)
                            damage = 0;
                    SetCursorPosition(54, 40); WriteLine($"Elta wildy attacks, leaving herself open to take major damage from {enemy} :Tip, press defend to shield and attack at the same time:");
                     WriteLine($"You lose  " + damage + "  health, and deal " + attack + "  damage");
                    player.Health -= damage;
                    enemy.Health -= attack;

                     }
                    else if (input.ToLower() == "d" || input.ToLower() == "defend")
                    {
                    //Defend
                    SetCursorPosition(54, 40); WriteLine($"Elta waits for {enemy} to attack, but swiftly blocks only taking a small amount of damage and dealing heavy damage to Ocil with his gaurd down:");
                        int damage = (enemy.Power / 2) - player.Armor;
                    int attack = rand.Next(0, player.Attack *2) + rand.Next(1, 4);
                         if (damage < 0) 
                            damage = 0;

                     WriteLine("You lose  " + damage + "  health, and deal  " + attack + "  damage");

                    player.Health -= damage;
                    enemy.Health -= attack;

                    }
                    else if (input.ToLower() == "h" || input.ToLower() == "heal")
                    {
                        //Heal
                        if (player.Rejuvenation == 0)
                        {
                        SetCursorPosition(54, 40); WriteLine("As you desperatly grasp for a beet in your sack, all that you feel is dirt");
                            int damage = enemy.Power - player.Armor;
                            if (damage < 0)
                                damage = 0;

                            WriteLine($" {enemy}  strikes you with a mighty blow and you lose  " + damage + "  health!");

                        }
                        else
                        {
                            WriteLine("You reach into your sack and pull out a delicious beet. You devour it within seconds!");
                            int beetV = 10;
                            
                            WriteLine("You gain " + beetV + " health");
                            player.Health += beetV;
                        player.Rejuvenation --;
                            WriteLine($"As you were occupied, {enemy} advanced and struck.");
                            int damage = (enemy.Power / 2) - player.Armor;
                            if (damage < 0)
                                damage = 0;
                            WriteLine("You lose  " + damage + "  health");
                        }
                        ReadKey();

                    }
                    if (player.Health <= 0)
                    {
                        if(player.Life<=0)
                        {
                        //death code
                        SetCursorPosition(54, 40); WriteLine($"Feeling tired, you let your guard down  {enemy}  deals the final blow. Dude you are dead!");
                            ReadKey();
                            ContinueMenu(images);


                        }
                        else
                        {
                        SetCursorPosition(54, 40); WriteLine($"In a deperate attempt, you reach into your sack and pull out an elixir. Glowing bright green, you chug it as quickly as possible. Atlas! You feel brand new and ready to continue the fight!");
                            player.Rejuvenation--;
                            player.Health += 40;
                        }

                    }
                    Console.ReadKey();
                }
                int c = rand.Next(0, 15);
               SetCursorPosition(54, 40); Console.WriteLine($"As you stand vitorious over {enemy}!  You get ready to leave and spot gold coins around {enemy}! You pick them up.");
                player.Coin += c;
                Console.ReadKey();
            }
            public void MagicMenu()
        {

        }
        public void FinalBoss()
        {

        }
        //public void PlayerStats(Player player)
        //{
        //    SetCursorPosition(10, 41); ForegroundColor = ConsoleColor.Yellow; WriteLine(player.Coin);
            
        //    if (player.Coin <= 20)
        //    {
        //        ForegroundColor = ConsoleColor.Red;
        //    }
        //    SetCursorPosition(32, 41); ForegroundColor = ConsoleColor.Green; WriteLine(player.Health);
        //    if (player.Health <= 50)
        //    {
        //        ForegroundColor = ConsoleColor.Red;
        //    }
        //    SetCursorPosition(32, 43); ForegroundColor = ConsoleColor.White; WriteLine(player.Armor);
            
        //    SetCursorPosition(11, 43); ForegroundColor = ConsoleColor.White; WriteLine(player.Attack);
            
        //    SetCursorPosition(10, 45); ForegroundColor = ConsoleColor.Cyan; WriteLine(player.Life);
        //    if (player.Coin <= 2)
        //    {
        //        ForegroundColor = ConsoleColor.Red;
        //    }
        //    SetCursorPosition(32, 45); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(player.Rejuvenation);
        //    if(player.Rejuvenation<=5)
        //    {
        //        ForegroundColor = ConsoleColor.Red;
        //    }
            
            
        //}

        public void EnemyStats(Enemies enemy)
        {
            
            SetCursorPosition(85, 41); ForegroundColor = ConsoleColor.Green; WriteLine(enemy.Health);
            if (enemy.Health <= 50)
            {
                ForegroundColor = ConsoleColor.Red;
            }
            SetCursorPosition(85, 41); ForegroundColor = ConsoleColor.White; WriteLine(enemy.Armor);

            SetCursorPosition(85, 41); ForegroundColor = ConsoleColor.White; WriteLine(enemy.Power);

           


        }
        public void ContinueMenu(GameImages images)
        {
            SetCursorPosition(80, 15); //image//
            
        }
        public void Shopkeepermenu(Player player)
        {

        }
    }
}
