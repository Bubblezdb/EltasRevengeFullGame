using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ER_GameLibrary
{
    public class Player
    {
        
        public int Health = 100 ;
        public int Life = 2;
        public int Defense = 0;
        public int Armor = 0;
        public int Attack = 25;
        public int Coin = 1000;
        public int Rejuvenation = 5;
        public int[] items;// item list
       
        public int X { get; set; }
        public int Y { get; set; }

        private string PlayerMarker;
        private ConsoleColor PlayerColor;

        public Player(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
            PlayerMarker = "O";
            PlayerColor = ConsoleColor.Red;
        }

        public void Draw()
        {

            ForegroundColor = PlayerColor;
            SetCursorPosition(X, Y);
            Write(PlayerMarker);

            ResetColor();

        }
        public void Clear()
        {
            ForegroundColor = PlayerColor;
            SetCursorPosition(X, Y);
            Write(" ");
            ResetColor();


        }

    }

}


