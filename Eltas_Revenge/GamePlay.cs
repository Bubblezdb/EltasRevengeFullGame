using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static System.Console;
using System.Linq;
using System.IO;
using ER_GameLibrary;

namespace EltasRevenge
{
    public class GamePlay
    {     ER_GameLibrary.GameImages GameImages = new ER_GameLibrary.GameImages();
          ER_GameLibrary.UserMenus Menus = new ER_GameLibrary.UserMenus();
 
        public void Start()
        {
            //Game and all settings will be loaded here 
            
          
        
            GameScreenSize();
            GameImages.TeamTitle();
            Clear();
            GameImages.TitlePage();
            GameImages.MainMenu();

            bool mainMenu = true;
            while(mainMenu)
            {
                SetCursorPosition(113, 34);
                mainMenu = Menus.MainMenu(GameImages);// verified success aug 1 goes to USerMenus
            }
        }

        public void GameScreenSize()
        {

            //size verified on jul31
            WindowHeight = 50;
            WindowWidth = 170;
            BufferHeight = 50;
            BufferWidth = 170;

        }

    }
}
