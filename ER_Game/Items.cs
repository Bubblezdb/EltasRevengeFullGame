using System;
using System.Collections.Generic;
using System.Text;

namespace ER_GameLibrary
{
   public class Items
    {

        public int X { get; set; }
        public int Y { get; set; }
        private string DropMarker;
        private string ClearDrop;
        private ConsoleColor DropColor;

        public Items()
        {


            DropMarker = "$";
            ClearDrop = " ";
            DropColor = ConsoleColor.DarkYellow;
        }
        public void Draw()
        {
            //TODO
        }

    } 
}
