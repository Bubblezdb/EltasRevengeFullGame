using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;

namespace ER_GameLibrary
{
    
    
    public class GameLayout
    {
        private string[,] Grid;
        Random rand = new Random();
        private int Rows;
        private int Cols;
       

        
        


        public GameLayout(string[,] grid)
        {

            Grid = grid;
            Rows = Grid.GetLength(0);
            Cols = Grid.GetLength(1);

        }
        public void Draw()// Draws the text file
        {
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Cols; x++)
                {

                    string element = Grid[y, x];
                    SetCursorPosition(x, y);



                    if (element == "}" || element == "{")//X = exit
                    {
                        ForegroundColor = ConsoleColor.DarkCyan;
                    }
                    else if (element == "q")// roof
                    {
                        ForegroundColor = ConsoleColor.DarkMagenta;
                    }
                    else if (element == "=")// Q= drop
                    {
                        ForegroundColor = ConsoleColor.DarkGray;
                    }
                    else if (element == "X"|| element == "x")// Q= drop
                    {
                        ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    else
                    {
                        ForegroundColor = ConsoleColor.White;
                    }
                    Write(element);

                }


            }

        }

        
        public string GetElementAt(int x, int y)// returns a copy of whatever is in the grid at the x and y position
        {
            return Grid[y, x];
        }

        public bool IsPositionWalkable(int x, int y)
        {
            // Check bounds first
            if (x < 0 || y < 0 || x >= Cols || y >= Rows)
            {
                return false;
            }
            //Check if the grid is walkable tile.
            return Grid[y, x] == " " || Grid[y, x] == "{" || Grid[y, x] == "}" || Grid[y, x] == "=";
        }
    }



}
