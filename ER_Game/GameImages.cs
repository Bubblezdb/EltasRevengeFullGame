using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace ER_GameLibrary
{
    public class GameImages
    {

       
        public static string[,] ParseFileToArray(string filePath)// loads txt files... this is good
        {
            string[] lines = File.ReadAllLines(filePath);
            string firstLine = lines[0];
            int rows = lines.Length;
            int cols = firstLine.Length;
            string[,] grid = new string[rows, cols];




            for (int y = 0; y < rows; y++)
            {
                string line = lines[y];
                for (int x = 0; x < cols; x++)
                {
                    char currentChar = line[x];
                    grid[y, x] = currentChar.ToString();

                }
            }
            return grid;
            // good to here
        }


        public void TitlePage()// works
        {

            SetCursorPosition(10, 0);
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine(@"                                              
                                                                                            
                                                                      .-'.  ':'-.
                                                                    .''     ss    '.
                              ...X.XXX.XX.X                        /                \
                              .X.XXX,*%X&&#,X...**  .             ;. sssas        s  ;
                              ,*.X..X**,,*,(X.,X.../              |   ssssasss       |
        '                  ,/X,,XXX.X/%&&%*//X.X/..*              ; '   ssa          ;
                   X...XX..*XX//XX,,X*,****XX.XXX..XX.             \                /
                         ............,.,,,.......                   ''     qqws   .'
                            ,,...,*****,,###(/*.                     '''-.___'_.-'
           .!                ****/(#(,**/(&X/,(
                             (**///#X&&&#X&#**.
                    '         */(//(#X%#/*,%%/.
                              ,**/((##(((**#*
                             */**,*/(#%&%#(,.
                       ,,*/.,/(//***,,,...          '
        '           ,(&&&&&&&%#((/***,..
                %&&%%&&%&&&&&&@@%(////(&
              %%%%&&&&&#&.,/##&&&&&&@(/&%%&(
           ###%%%&&&&%&&&,*#&@&&@&&@@&#%@%#@&&&..
.          %%%%%&%%&&&%#**//#&&&&&&&&&&&&&&&&&@&#
         ##%%%%%%%&%#%.,,//(..,*&@&&&&@%@@&&&@ ,,
      ########%%%%#%%/,*,,,.,,,...,./&&&%@@&&&&& .*
    %(XX((####%%%#%#(*...*....,,*,(/,,,,/&&@@#(,.,.
    /X###(###%%%#    #*..,.....,***(/,,,.,.,.***,.,.,
    X(######%%%#   *,. ..,......,,.,*,,,,,.,*,.,,...&
    (##%%%%%%          .**,............,,,,.........%
    %%%####          , ,,,,,.................*.,...*&(,
    ///(((        .. .  *,,....,,...,..,...,.*,.,(%&#.
    %#*(*.              .......,,../(*.,.,,.,*.,.%%@@&%
    (%(,.               .,.........,/(/*,,,..,,,,%&@#/&
    (%&&&%.....         ..*,......,*//****,,..   ,.,,,,,             '
    //#%%/####/...      ../,*.....,*/*,*,,.,.     . ,  ,                       '
    ,/*.,,,,**(#%/**/,....#,*.....,,/*..,/,..      ,//**                                            '
    .  ...  ..,,,...,.,,*,*,,...,**,,((((*,,,.    ,,(,****
                   ....,,,,..*.,,,.,**,,,...,...,,.,,,*.,,       '
                     .,.,*...**,*,,,,***///,,,.....,.*,,,*                                                                                                                
                     ...,*,..,.....,/**,..,*,,,*....,.,...
                    ..,...*....,,,.,**/*,....,.,........*.
                    .(,....,..,.,.,.......,*,,,....,...*                   '                                                            
                    //(/*,...*/(/###/,......,**,,**/,                     
                    /((/***,**(*/##/*/*..,,,,*.*,./(,                                         .");
            WriteLine();

            
            
SetCursorPosition(59, 12);ForegroundColor=ConsoleColor.DarkCyan;WriteLine(@"               oooooooooooo oooo      .                                                            ");
SetCursorPosition(59, 13);ForegroundColor=ConsoleColor.DarkCyan;WriteLine(@"               `888'     `8 `888    .o8            }                                                ");
SetCursorPosition(59, 14);ForegroundColor=ConsoleColor.DarkCyan;WriteLine(@"                888          888  .o888oo  .oooo.    .oooo.o                                        ");
SetCursorPosition(59, 15);ForegroundColor=ConsoleColor.DarkCyan;WriteLine(@"                888oooo8     888    888   `P  )88b   d88(  '8                                        ");
SetCursorPosition(59, 16);ForegroundColor=ConsoleColor.DarkCyan;WriteLine(@"                888    '     888    888.    oP'888   ` Y88b.                                         ");
SetCursorPosition(59, 17);ForegroundColor=ConsoleColor.DarkCyan;WriteLine(@"                888       o  888    888 . d8(  888   o.  )88b                                        ");
SetCursorPosition(59, 18);ForegroundColor=ConsoleColor.DarkCyan;WriteLine(@"                o888ooooood8 o888o   '888' `Y888''8 o 8''888P'                                       ");
SetCursorPosition(59, 19);ForegroundColor=ConsoleColor.DarkCyan;WriteLine(@"                                                                                                    ");
SetCursorPosition(59, 20);ForegroundColor=ConsoleColor.DarkCyan;WriteLine(@"                                                                                                    ");
SetCursorPosition(59, 21);ForegroundColor=ConsoleColor.DarkCyan;WriteLine(@"              ooooooooo.                                                                            ");
SetCursorPosition(59, 22);ForegroundColor=ConsoleColor.DarkCyan;WriteLine(@"             `888   `Y88.                                                                           ");
SetCursorPosition(59, 23);ForegroundColor=ConsoleColor.DarkCyan;WriteLine(@"              888   .d88'  .ooooo.  oooo    ooo  .ooooo.  ooo. .oo.    .oooooooo  .ooooo.           ");
SetCursorPosition(59, 24);ForegroundColor=ConsoleColor.DarkCyan;WriteLine(@"              888ooo88P'  d88' `88b  `88.  .8'  d88' `88b `888P'Y88b  888' `88b  d88' `88b          ");
SetCursorPosition(59, 25);ForegroundColor=ConsoleColor.DarkCyan;WriteLine(@"              888`88b.    888ooo888   `88..8'   888ooo888  888   888  888   888  888ooo888          ");
SetCursorPosition(59, 26);ForegroundColor=ConsoleColor.DarkCyan;WriteLine(@"              888  `88b.  888    .o    `888'    888    .o  888   888  `88bod8P'  888    .o          ");
SetCursorPosition(59, 27);ForegroundColor=ConsoleColor.DarkCyan;WriteLine(@"             o888o  o888o `Y8bod8P'     `8'     `Y8bod8P' o888o o888o `8oooooo.  `Y8bod8P'          ");
SetCursorPosition(59, 28);ForegroundColor=ConsoleColor.DarkCyan;WriteLine(@"                                                                      d'     YD                    ");
SetCursorPosition(59, 29);ForegroundColor=ConsoleColor.DarkCyan;WriteLine(@"                                                                      'Y88888P'                    ");
            Thread.Sleep(2000);
        }
        
        public void MainMenu()// works
        {
            

            SetCursorPosition(73, 33); ForegroundColor = ConsoleColor.White; WriteLine(@"####################################################################");
            SetCursorPosition(73, 34); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                     Choose an option:                              ");
            SetCursorPosition(73, 35); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                    (1) Start New Game                              ");
            SetCursorPosition(73, 36); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                    (2) Exit                                        ");
            SetCursorPosition(73, 37); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                    (3) Credits                                     ");
            SetCursorPosition(73, 38); ForegroundColor = ConsoleColor.White; WriteLine(@"####################################################################");
        }

        public void AttributeMenu(Player player)// works
        {
            
            SetCursorPosition(0, 38); ForegroundColor = ConsoleColor.White; WriteLine(@" %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            SetCursorPosition(0, 39); ForegroundColor = ConsoleColor.White; WriteLine(@" %+------------------------------------------+     +------------------------------------------------------------------------------------------------------------------+%");
            SetCursorPosition(0, 40); ForegroundColor = ConsoleColor.White; WriteLine(@" %|           PLAYER STATS                   |     |                                                                                                                  |%");
            SetCursorPosition(0, 41); ForegroundColor = ConsoleColor.White; WriteLine(@" %|                                          |     |                                                                                                                  |%");
            SetCursorPosition(0, 42); ForegroundColor = ConsoleColor.White; WriteLine($@" %|COINS:{player.Coin}                HEALTH:{player.Health}             |     |                                                                                                                  |%");
            SetCursorPosition(0, 43); ForegroundColor = ConsoleColor.White; WriteLine(@" %|                                          |     |                                                                                                                  |%");
            SetCursorPosition(0, 44); ForegroundColor = ConsoleColor.White; WriteLine($@" %|ATTACK:{player.Attack}               ARMOR:{player.Armor}             |     |                                                                                                                  |%");
            SetCursorPosition(0, 45); ForegroundColor = ConsoleColor.White; WriteLine(@" %|                                          |     |                                                                                                                  |%");
            SetCursorPosition(0, 46); ForegroundColor = ConsoleColor.White; WriteLine($@" %|LIFE:                 BEETS:             |     |                                                                                                                  |%");
            SetCursorPosition(0, 47); ForegroundColor = ConsoleColor.White; WriteLine(@" %|                                          |     |                                                                                                                  |%");
            SetCursorPosition(0, 48); ForegroundColor = ConsoleColor.White; WriteLine(@" %+------------------------------------------+     +------------------------------------------------------------------------------------------------------------------+%");
            SetCursorPosition(0, 49); ForegroundColor = ConsoleColor.White; WriteLine(@" %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            
        }
        public void Beginning()
        {
            // New Game Loading image
        }
        public void Flight()
        {
            //SpaceShooter Loading image
        }
        public void ShopKeeperImage()
        {
            //Shopkeeper Loading Image
        }
        public void PlanetLanding()
        {
            //planet landing Loading image
        }

        public void FightMenu()
        {
            SetCursorPosition(54, 42); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"++++++++++++++++++++++++++++++");
            SetCursorPosition(54, 43); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  | (A)ttack    (D)efend |    ");
            SetCursorPosition(54, 44); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  |                      |    ");
            SetCursorPosition(54, 45); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  |  (R)un       (H)eal  |    ");
            SetCursorPosition(54, 46); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"++++++++++++++++++++++++++++++");
        }
        public void FightMagicMenu()
        {
            SetCursorPosition(54, 42); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            SetCursorPosition(54, 43); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  | (A)ttack    (D)efend |  (F) Fire      (W )Water     ");
            SetCursorPosition(54, 44); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  |                      |                              ");
            SetCursorPosition(54, 45); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  | (R)un       (H)eal   |  (I) Ice       (V) Voltage   ");
            SetCursorPosition(54, 46); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }
        public void BossFightMenu()
        {
            SetCursorPosition(54, 42); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"++++++++++++++++++++++++++++++");
            SetCursorPosition(54, 43); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  | (A)ttack    (D)efend |    ");
            SetCursorPosition(54, 44); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  |                      |    ");
            SetCursorPosition(54, 45); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  |        (H)eal        |    ");
            SetCursorPosition(54, 46); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"++++++++++++++++++++++++++++++");
        }

        public void BossFightMagicMenu()
        {
            SetCursorPosition(54, 42); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            SetCursorPosition(54, 43); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  | (A)ttack    (D)efend |  (F) Fire      (W )Water     ");
            SetCursorPosition(54, 44); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  |                      |                              ");
            SetCursorPosition(54, 45); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  |        (H)eal        |  (I) Ice       (V) Voltage   ");
            SetCursorPosition(54, 46); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }
        public void BossFightWithBosses()
        {
            SetCursorPosition(54, 42); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            SetCursorPosition(54, 43); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  | (A)ttack    (D)efend |  (F) Fire      (W )Water     |");// TODO
            SetCursorPosition(54, 44); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  |                      |                              |");
            SetCursorPosition(54, 45); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  |        (H)eal        |  (I) Ice       (V) Voltage   |");
            SetCursorPosition(54, 46); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }
        public void EnemyStats()
        {
            SetCursorPosition(85, 29); ForegroundColor = ConsoleColor.White; WriteLine(@"++++++++++++++++++++++++++++++++++++++++++++++++++");
            SetCursorPosition(85, 30); ForegroundColor = ConsoleColor.White; WriteLine(@"  |   Armor:              Attack:                |");
            SetCursorPosition(85, 31); ForegroundColor = ConsoleColor.White; WriteLine(@"  |                                              |");
            SetCursorPosition(85, 32); ForegroundColor = ConsoleColor.White; WriteLine(@"  |   Health:             Agro:                  |");// agro should have a stat bar increase
            SetCursorPosition(85, 33); ForegroundColor = ConsoleColor.White; WriteLine(@"++++++++++++++++++++++++++++++++++++++++++++++++++");

        }
        



        
    }
}
