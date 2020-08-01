using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ER_GameLibrary
{
   public class PlayerControls
    {
        Random rand = new Random();
        public void HandlePlayerInput(Player player,GameLayout gameLayout)
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
                    if (gameLayout.IsPositionWalkable(player.X, player.Y - 1))
                    {
                        //states, if the world is position walkable above the player, then they can walk.
                        player.Clear();
                        player.Y -= 1;
                        


                    }

                    break;
                case ConsoleKey.DownArrow:
                    if (gameLayout.IsPositionWalkable(player.X, player.Y + 1))
                    {//states, if the world is position walkable below the player, then they can walk.
                        player.Clear();
                        player.Y += 1;
                        
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (gameLayout.IsPositionWalkable(player.X - 1, player.Y))
                    {//states, if the world is position walkable right of the player, then they can walk.

                        player.Clear();
                        player.X -= 1;
                        
                    }

                    break;
                case ConsoleKey.RightArrow:
                    if (gameLayout.IsPositionWalkable(player.X + 1, player.Y))
                    { //states, if the world is position walkable left of the player, then they can walk.
                        player.Clear();
                        player.X += 1;
                        

                    }
                    break;
                default:
                    break;

            }


        }
        
            


           
        
    }
}
