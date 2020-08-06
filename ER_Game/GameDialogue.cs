using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static System.Console;

namespace ER_GameLibrary
{
    public class GameDialogue
    {
        public void PrintbyChar(string sentence)
        {
            foreach (char character in sentence)
            {
                Write(character);
                Thread.Sleep(40);
            }
        }
        public void Loadingpage()
        {
            SetCursorPosition(91, 43); ForegroundColor = ConsoleColor.Yellow; PrintbyChar(@"████████████████████████████████████");
        }

        public void Shop()
        {
            SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; PrintbyChar($"Wanna Shop? (Y)es||(N)o");
        }
        public void StartEvent()
        {
            SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; PrintbyChar($"Start the event? (Y)es||(N)o"); 
        }
        public void Travel()
        {
            SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; PrintbyChar($"Would you like to travel? (Y)es||(N)o"); 
        }
        public void TravelOnHold()
        {
            SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; PrintbyChar($"You must finish the event before you can travel!"); 
        }
       
    }
}
