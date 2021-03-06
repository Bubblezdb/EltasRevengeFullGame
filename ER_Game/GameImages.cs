﻿using System;
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
            string[] drops = lines;



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

            CursorVisible = false;
            SetCursorPosition(10, 0);
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine(@"                                              
                                                                                            
                                                                      .-'.  ':'-.
                                                                    .''     ss    '.
                              ...X.XXX.XX.X                        /                \
                              .X.XXX,*%X&&#,X...**  .             ;. sssas        s  ;
                              ,*.X..X**,,*,(X.,X.../              |   ssssasss       |
        '                  ,/X,,XXX.X/%&&%*//X.X/..*              ; 'ssssssa          ;
                   X...XX..*XX//XX,,X*,****XX.XXX..XX.             \   sssssss      /
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



            SetCursorPosition(59, 12); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"               oooooooooooo oooo      .                                                            "); Thread.Sleep(25);
            SetCursorPosition(59, 13); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"               `888'     `8 `888    .o8            }                                                "); Thread.Sleep(25);
            SetCursorPosition(59, 14); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                888          888  .o888oo  .oooo.    .oooo.o                                        "); Thread.Sleep(25);
            SetCursorPosition(59, 15); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                888oooo8     888    888   `P  )88b   d88(  '8                                        "); Thread.Sleep(25);
            SetCursorPosition(59, 16); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                888    '     888    888.    oP'888   ` Y88b.                                         "); Thread.Sleep(25);
            SetCursorPosition(59, 17); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                888       o  888    888 . d8(  888   o.  )88b                                        "); Thread.Sleep(25);
            SetCursorPosition(59, 18); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                o888ooooood8 o888o   '888' `Y888''8 o 8''888P'                                       "); Thread.Sleep(25);
            SetCursorPosition(59, 19); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                                                                                                    "); Thread.Sleep(25);
            SetCursorPosition(59, 20); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                                                                                                    "); Thread.Sleep(25);
            SetCursorPosition(59, 21); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"              ooooooooo.                                                                            "); Thread.Sleep(25);
            SetCursorPosition(59, 22); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"             `888   `Y88.                                                                           "); Thread.Sleep(25);
            SetCursorPosition(59, 23); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"              888   .d88'  .ooooo.  oooo    ooo  .ooooo.  ooo. .oo.    .oooooooo  .ooooo.           "); Thread.Sleep(25);
            SetCursorPosition(59, 24); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"              888ooo88P'  d88' `88b  `88.  .8'  d88' `88b `888P'Y88b  888' `88b  d88' `88b          "); Thread.Sleep(25);
            SetCursorPosition(59, 25); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"              888`88b.    888ooo888   `88..8'   888ooo888  888   888  888   888  888ooo888          "); Thread.Sleep(25);
            SetCursorPosition(59, 26); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"              888  `88b.  888    .o    `888'    888    .o  888   888  `88bod8P'  888    .o          "); Thread.Sleep(25);
            SetCursorPosition(59, 27); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"             o888o  o888o `Y8bod8P'     `8'     `Y8bod8P' o888o o888o `8oooooo.  `Y8bod8P'          "); Thread.Sleep(25);
            SetCursorPosition(59, 28); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                                                                      d'     YD                    "); Thread.Sleep(25);
            SetCursorPosition(59, 29); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                                                                      'Y88888P'                    "); Thread.Sleep(25);
            Thread.Sleep(500);
        }

        public void TeamTitle()// team logo page
        {
            CursorVisible = false;
            SetCursorPosition(20, 9); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                                @   @                     @                             "); Thread.Sleep(25);
            SetCursorPosition(20, 10); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                              @ ....                   @....@@                          "); Thread.Sleep(25);
            SetCursorPosition(20, 11); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                              @......                 @......                           "); Thread.Sleep(25);
            SetCursorPosition(20, 12); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                                @ . @&.............@@@ .  . @                           "); Thread.Sleep(25);
            SetCursorPosition(20, 13); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                                @.........................*@.                           "); Thread.Sleep(25);
            SetCursorPosition(20, 14); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                             .@....(@@@@@@@@@@@@@@...........                           "); Thread.Sleep(25);
            SetCursorPosition(20, 15); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                            @...@@@@@@@@@@@@@@@@@@@@@@.........*                        "); Thread.Sleep(25);
            SetCursorPosition(20, 16); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                           @.#@@@@@@@@@@@@@@@@@@@@@@@@@@........                       "); Thread.Sleep(25);
            SetCursorPosition(20, 17); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                          @.@@@@&&@@@@@@@@@@@:      :@@@@@.......@         Desiree Blaney           "); Thread.Sleep(25);
            SetCursorPosition(20, 18); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                         /.:          @@@@@            @@@........@        Wren Pacheco            "); Thread.Sleep(25);
            SetCursorPosition(20, 19); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                         ..&          @@@@@            @@@........@        Jonathan Kneeland           "); Thread.Sleep(25);
            SetCursorPosition(20, 20); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                         .@@         @@@@@@           @@@.........@        Patricia Quinteros             "); Thread.Sleep(25);
            SetCursorPosition(20, 21); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                           ,         @@@@@@@         @@@@........@                      "); Thread.Sleep(25);
            SetCursorPosition(20, 22); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                           &.@@@@@@@@@@@@@@@@@@@@@@@@@@@........@                       "); Thread.Sleep(25);
            SetCursorPosition(20, 23); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                            &..@@@@@@@@@WW@@@@@@@@@@@@.........@                        "); Thread.Sleep(25);
            SetCursorPosition(20, 24); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                             .@...@@@@@@@@@@@@@@@@@/.........@ .                        "); Thread.Sleep(25);
            SetCursorPosition(20, 25); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                                 @......@@@@@@@@..........@... ..                       "); Thread.Sleep(25);
            SetCursorPosition(20, 26); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                                  . @......#@........./...../  .                        "); Thread.Sleep(25);
            SetCursorPosition(20, 27); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                                  .@.....@/........@.......... .                        "); Thread.Sleep(25);
            SetCursorPosition(20, 28); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"   ###       ######## ########    ###    ##     ##     #######   (...............@#...........*.                        "); Thread.Sleep(25);
            SetCursorPosition(20, 29); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"  ## ##         ##    ##         ## ##   ###   ###    ##     ## @................@,......,.....@                        "); Thread.Sleep(25);
            SetCursorPosition(20, 30); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@" ##   ##        ##    ##        ##   ##  #### ####           ## ....@....................@,.....                        "); Thread.Sleep(25);
            SetCursorPosition(20, 31); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"##     ##       ##    ######   ##     ## ## ### ##     #######  ...,...........,,,........,......@ .                    "); Thread.Sleep(25);
            SetCursorPosition(20, 32); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"#########       ##    ##       ######### ##     ##    ##        ...&......................@,......@.                    "); Thread.Sleep(25);
            SetCursorPosition(20, 33); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"##     ##       ##    ##       ##     ## ##     ##    ##        ..,*.................@.....,.......@                    "); Thread.Sleep(25);
            SetCursorPosition(20, 34); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"##     ##       ##    ######## ##     ## ##     ##    ######### .,,..%...............,.....,,..*@@@@                    "); Thread.Sleep(25);
            SetCursorPosition(20, 35); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@" ######  ########  ########    ###    ######## ####  #######  ##    ## /@%..........(@.....@                            "); Thread.Sleep(25);
            SetCursorPosition(20, 36); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"##    ## ##     ## ##         ## ##      ##     ##  ##     ## ###   ## /(/#&@@@%###@@@%/(@ .                            "); Thread.Sleep(25);
            SetCursorPosition(20, 37); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"##       ##     ## ##        ##   ##     ##     ##  ##     ## ####  ## //////@//////@////@ .                            "); Thread.Sleep(25);
            SetCursorPosition(20, 38); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"##       ########  ######   ##     ##    ##     ##  ##     ## ## ## ## /////@,/////////// .                             "); Thread.Sleep(25);
            SetCursorPosition(20, 39); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"##       ##   ##   ##       #########    ##     ##  ##     ## ##  #### ////@. //////////@ .                             "); Thread.Sleep(25);
            SetCursorPosition(20, 40); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"##    ## ##    ##  ##       ##     ##    ##     ##  ##     ## ##   ### ///@ ..//////////# . .                           "); Thread.Sleep(25);
            SetCursorPosition(20, 41); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@" ######  ##     ## ######## ##     ##    ##    ####  #######  ##    ## //(. ../////////(  . .                           "); Thread.Sleep(25);
            SetCursorPosition(20, 42); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                            @@@.... .@@@@@@@@@/ ......./@*. .                           "); Thread.Sleep(25);
            SetCursorPosition(20, 43); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                          @@@@@  .....  @@@@@@@%.  ..%@(@@@@@                           "); Thread.Sleep(25);
            SetCursorPosition(20, 44); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                          @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                           "); Thread.Sleep(25);
            SetCursorPosition(20, 45); ForegroundColor = ConsoleColor.DarkGreen; WriteLine(@"                                                          . @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*                           "); Thread.Sleep(25);
            Thread.Sleep(3000);
        }

        public void MainMenu()// works
        {

            CursorVisible = false;
            SetCursorPosition(73, 33); ForegroundColor = ConsoleColor.White; WriteLine(@"####################################################################");
            SetCursorPosition(73, 34); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                     Choose an option:                              ");
            SetCursorPosition(73, 35); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                    (1) Start New Game                              ");
            SetCursorPosition(73, 36); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                    (2) Exit                                        ");
            SetCursorPosition(73, 38); ForegroundColor = ConsoleColor.White; WriteLine(@"####################################################################");
            SetCursorPosition(73, 39); ForegroundColor = ConsoleColor.Green; WriteLine(@"                        A Team 2 Project                              ");
        }

       
        
        
        
        public void Credits()
        {


            CursorVisible = false;
            SetCursorPosition(73, 33); ForegroundColor = ConsoleColor.White; WriteLine(@"####################################################################");
            SetCursorPosition(73, 34); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                                                  ");
            SetCursorPosition(73, 35); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                                                ");
            SetCursorPosition(73, 36); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                                                           ");
            SetCursorPosition(73, 37); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                                                        ");
            SetCursorPosition(73, 38); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                                                        ");
            SetCursorPosition(73, 39); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                                                        ");
            SetCursorPosition(73, 40); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                                                        ");
            SetCursorPosition(73, 41); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"                                                        ");
            SetCursorPosition(73, 42); ForegroundColor = ConsoleColor.White; WriteLine(@"####################################################################");


        }

        public void AttributeMenu(Player player)// works
        {

            CursorVisible = false;
            SetCursorPosition(0, 39); ForegroundColor = ConsoleColor.White; WriteLine(@" %+------------------------------------------+%");
            SetCursorPosition(0, 40); ForegroundColor = ConsoleColor.White; WriteLine(@"                 PLAYER STATS                  ");
            SetCursorPosition(0, 41); ForegroundColor = ConsoleColor.White; WriteLine(@"                                      ");
            SetCursorPosition(0, 42); ForegroundColor = ConsoleColor.White; WriteLine($@"   COINS:{player.Coin}             HEALTH:{player.Health}        ");
            SetCursorPosition(0, 43); ForegroundColor = ConsoleColor.White; WriteLine(@"                                          ");
            SetCursorPosition(0, 44); ForegroundColor = ConsoleColor.White; WriteLine($@"   ATTACK:{player.Attack}              ARMOR:{player.Armor}            ");
            SetCursorPosition(0, 45); ForegroundColor = ConsoleColor.White; WriteLine(@"                                           ");
            SetCursorPosition(0, 46); ForegroundColor = ConsoleColor.White; WriteLine($@"   LIFE:{player.Life}                 BEETS:{player.Rejuvenation}            ");
            SetCursorPosition(0, 47); ForegroundColor = ConsoleColor.White; WriteLine(@"                                          ");
            SetCursorPosition(0, 48); ForegroundColor = ConsoleColor.White; WriteLine(@" +------------------------------------------+%");


        }
        public void ActionMenu(Player player)// works
        {

            CursorVisible = false;
            
            SetCursorPosition(52, 39); ForegroundColor = ConsoleColor.White; WriteLine(@"%+-----------------------------------------------------------------------------------------------------+%");
            SetCursorPosition(52, 40); ForegroundColor = ConsoleColor.White; WriteLine(@"                                                                                                     ");
            SetCursorPosition(52, 41); ForegroundColor = ConsoleColor.White; WriteLine(@"                                                                                                     ");
            SetCursorPosition(52, 42); ForegroundColor = ConsoleColor.White; WriteLine(@"                                                                                                      ");
            SetCursorPosition(52, 43); ForegroundColor = ConsoleColor.White; WriteLine(@"                                                                                                      ");
            SetCursorPosition(52, 44); ForegroundColor = ConsoleColor.White; WriteLine(@"                                                                                                      ");
            SetCursorPosition(52, 45); ForegroundColor = ConsoleColor.White; WriteLine(@"                                                                                                      ");
            SetCursorPosition(52, 46); ForegroundColor = ConsoleColor.White; WriteLine(@"                                                                                                      ");
            SetCursorPosition(52, 47); ForegroundColor = ConsoleColor.White; WriteLine(@"                                                                                                      ");
            SetCursorPosition(52, 48); ForegroundColor = ConsoleColor.White; WriteLine(@" %+-----------------------------------------------------------------------------------------------------+%");


        }

        public void Beginning(GameDialogue dialogue)
        {
            Clear();
            SetCursorPosition(60, 10);
            ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  
                                                     XXXX         XXXX
                                                    XX*,*XXXX   XXXX.XXXXXX
                                                    XXXX..%*XXXXX/XXXX..@*.XXX
                                                      XXX/*********XXX...@(* XXX
                                                       XX*  .,****************.XX
                                                      XX****,@@*****************X
                                                     XX****@((@****************,X
                                                XXXXXX***********,.....%*******X*
                                                XXXXXXXXXXXXXXXXXXXXXXXX.@*****X@
                                                 XXXXXX      XX        .XX*****XX
                                                   X XXXXXXXXXX         .X@*****XXX      XXXXXXXXXXX
                                                             @XX         X@***/(*(bbbbbbbb::::**.*..XXX
                                                              (XX        X#@%(((@**.bbbbbbbb*******..XXX
                                                               @(%%%%%%%%%%%@*******..XXXXXXX*********.XX
                                                              XXX  .. @@X @***********.@XXXX*XX********.XX
                                                             XX*,.     XX(**************.,XXXXXX*@/*****.XX
                                                             X***.     X******************..XXXXX*/*****,XX
                                                             X@****    X******.*************.XXXX/*****XXX
                                                             XX,***    X@****..*************..@XX**XXXXXX
                                                              XX*****. XX*****,**************..&XXXXX XXX
                                                               XXX**,  *XX**.,****************.XXX*XXX
                                                               .XX .% .*/X*.@***************,XXXXXXX
                                                           .. XX   XXXXXX&& **/@*********XXXXXXXXX
                                                              XXX .XX(   ..      %***XXXXXXXXXXXX
                                                                    XXXXXXXX  ..@.  XXXXXXXXXX
                                                                           XXXXXXXXXXXXX");
            WriteLine(@"
                                                 _                      _ _             
                                                | |                    | (_)            
                                                | |      ___   ____  _ | |_ ____   ____ 
                                                | |     / _ \ / _  |/ || | |  _ \ / _  |
                                                | |____| |_| ( ( | ( (_| | | | | ( ( | |
                                                |_______)___/ \_||_|\____|_|_| |_|\_|| |
                                                                                 (_____|"); Thread.Sleep(300); dialogue.Loadingpage();


        }
        public void Flight(GameDialogue dialogue)
        {
            //transition art for shooter
            Clear();
            CursorVisible = false;
            SetCursorPosition(40, 10);
            WriteLine(@"
                    ---------------------------------------------------------------------------------------------------------
                    |              .     .   !   '  (_)      .                .:MMMMM88&&&&&&                               |
                    |        .              ,|.'                     .      .:'  MMMMM88&&&&                                |
                    |             -  -- ---(-O-`--- --  -      .          .:'   .:'MMM8&&&'           .                     |
                    |                        |                            '... .'                                 '/''/     |
                    |         .              !   +                                               /        */*/*/*///*///    |
                    |             .          :          .       .                        .         */*******************    |
                    |                        ,                                     /         .//*/*/*/*/*/*/*/*/*/*///*/    |
                    |              .:                                                    /****************************/ /   |
                    |                                                 +             ./*/*/*/*/*&@@@@@@@@@(*/*/*/*/*/*/      |
                    |                     ++                    .                /**********/@@@@@@@@@@@@@@&*********       |
                    |n             .                  .                      **/*/*/*/*/*/*/*/*/*/*/*(@@@@@@@/*/*/*/.     / |
                    |nnnn                                                 /****************************/@@@@@******.        |
                    |nnnnn                                 .&&&&#(**,../*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/(@@@@/*/*/.         |
                    |nnnnnnn               .             %%%%%%%%%%%(************************************@@#*****           |
                    |nnnnnnnn                         %%%%%%%%%%%%//*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/&/*/*/*/    /       |
                    |nnnnnnnnn                     #%%%%%%%%%%%%%**********************(&%%(******************/             |
                    |nnnnnnnnnn                 (%%%%%%%%%%%%%%(*/*/*/*/*/*/*/*/*/*(%%%%%%//*/*/*/*/*/*/*/*/*.              |
                    |zzzzzzzzzz))))).        *%%%%%%%%%%%%%%%%/****************/%%%%%%%%%******************/                |
                    |zzzzzzzzzz   ) ))     (#&&%%%%%%%%%%%%%%/*/*/*/*/*/*/*//&%%%%%%%%%**/*/*/*/*/*/*/*/*/.                 |
                    |zzzzzzzz/ . /))                .#%%%%%%%************(%%%%%%%%%%%/*******************                   |
                    |zzzzz...  ))                         #%//*/*/*/*/#%%%%%%%%%%%%/*/*/*/*/*/*/*/*/*/*                     |
                    |.z.)zz)                                /******#%%%%%%%%%%%%%(******************/          /            |
                    |z)zzzz                      /          */**%%%%%%%%%%%%%%%(*/*/*/*/*/*/*/*/*//                         |
                    |zzzzz                     /      ,,,,,,/#%%%%%%%%%%%%%%%(******************//                          |
                    |zzzz                   //    ,,,,,,.,.(%%%%%%%%%%%%%%%(*/*/*/*/*/*/*/*/*/#%%(                          |
                    |zzz                       .,,,,,.....,%%%%%%%%%%%%%%/****************/%%%%%%%                          |
                    |z                        ,,,,,,.,.,.,#%%%%%%%%%%%%/*/*/*/*/*/*/*/%%%%%%%%%%%&                          |
                    |                 /      *,,,,,,......%%%%%%%%%%%******,*%%%%%%%%%%%%%%%%%%%%%                          |
                    |                       .,,,,,,,.,.,.,.,.,.,.,.,.,,.      &%%%%%%%%%%%%%%%%#                            |
                    |              /        ,,,,,,,,,..............,,,.        %%%%%%%%%%%%%%/                              |
                    |                      ,,,,,,,,,,,,,.,.,.,.,,,,,,.          #%%%%%%%%%%,                                |
                    |                      ,,,,,,,,,,,,,,,,,,,,,,,,*      //     &%%%%%%%                                   |
                    |                      ,,,,,,,,,,,,,,,,,,,,,,                 %%%%&                                     |
                    |                     .,,,,,,,,,,,,,,,,.        /             &%&                                       |
                    |                     ....                                    .                                         |
                    |                                           /                                                           |
                    +-------------------------------------------------------------------------------------------------------+

");
            WriteLine(@"
                                                 _                      _ _             
                                                | |                    | (_)            
                                                | |      ___   ____  _ | |_ ____   ____ 
                                                | |     / _ \ / _  |/ || | |  _ \ / _  |
                                                | |____| |_| ( ( | ( (_| | | | | ( ( | |
                                                |_______)___/ \_||_|\____|_|_| |_|\_|| |
                                                                                 (_____|"); Thread.Sleep(300); dialogue.Loadingpage(); Clear();
        }
        public void ShopKeeperImage()
        {
            //transition page
            Clear();
            CursorVisible = false;
            SetCursorPosition(80, 8);
            WriteLine(@"
                                                  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#                 
                                                ((((((      ((((((      (      ((((((      ((((((               
                                               ((((((      ((((((      (((      ((((((      ((((((              
                                              ((((((      (((((/     ,(((((,     ((((((      ((((((             
                                             ((((#/     /(((((      ((((((((#      (((((*     ((((((            
                                           *((((#      ((((((      (((((((((((      ((((((     .(((((,          
                                          ,#####*,,,**######,,,,,,#############*,,,,,######*,,,,*#####.         
                                           #####,,,,,,/#####*,,,,*,###########,,,,,,,#####*,,,,*,#####          
                                               .,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,               
                                               .,,,,,,&(((((((((((((#&,,,,,,,,,,,,,,,,,,,,,,,,,,,               
                                               .,,,,,,&              &,,,,,,,,,,,,,,,,,,,,,,,,,,,               
                                               .,,,,,,&              &,,,,,,,,,,,,,,,,,,,,,,,,,,,               
                                               .,,,,,,&              &,,,,,,,,,,,,,,,,,,,,,,,,,,,               
                                               .,,,,,,&              &,,,,,,,,,,,,%%%%%%%%%%,,,,,               
                                               .,,,,,,&              &,,,,,,,,,,,%          %,,,,               
                                               .,,,,*%%%%%%%%%%%%%%%%%%,,,,,,,,,,%          %,,,,               
                                               .,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,% %%       %,,,,               
                                               .,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%          %,,,,               
                                               .,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%          %,,,,             
                                                      |=====================================|
                                                      | S:  Sword         (500 Krubels)     |
                                                      |                                     |
                                                      | D:  Dual Pistols  (750 Krubels)     |
                                                      |                                     |
                                                      | G: Shotgun       (1000 Krubels)     |
                                                      |                                     |
                                                      | B:  Beets         (10 Krubels)      |
                                                      |                                     |
                                                      | M: Sell Junk                        |
                                                      |=====================================|





            ");



        }
           
                                               

                                               
      

       

        public void FightMenu()
        {
            CursorVisible = false;
            SetCursorPosition(13, 32); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"++++++++++++++++++++++++++++++");
            SetCursorPosition(13, 33); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"       *****ELTA******        ");
            SetCursorPosition(13, 34); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  | (A)ttack    (D)efend  |   ");
            SetCursorPosition(13, 35); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  |                       |   ");
            SetCursorPosition(13, 36); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  |  (R)un       (H)eal   |   ");
            SetCursorPosition(13, 37); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"++++++++++++++++++++++++++++++");
        }
     
        public void BossFightMenu()
        {
            SetCursorPosition(13, 32); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"++++++++++++++++++++++++++++++");
            SetCursorPosition(13, 33); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"       *****ELTA******        ");
            SetCursorPosition(13, 34); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  | (A)ttack    (D)efend |    ");
            SetCursorPosition(13, 35); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  |                      |    ");
            SetCursorPosition(13, 36); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"  |        (H)eal        |    ");
            SetCursorPosition(13, 37); ForegroundColor = ConsoleColor.DarkCyan; WriteLine(@"++++++++++++++++++++++++++++++");
        }

       
        public void EnemyStats(Enemies enemy)
        {
            SetCursorPosition(88, 32); ForegroundColor = ConsoleColor.White; WriteLine(@"++++++++++++++++++++++++++++++++++++++++++++++++++");
            SetCursorPosition(88, 33); ForegroundColor = ConsoleColor.White; WriteLine($@"                    ****{enemy.Name}****                       ");
            SetCursorPosition(88, 34); ForegroundColor = ConsoleColor.White; WriteLine($@"      Armor:{enemy.Armor}            Attack:{enemy.Power}  ");
            SetCursorPosition(88, 35); ForegroundColor = ConsoleColor.White; WriteLine(@"                                               ");
            SetCursorPosition(88, 36); ForegroundColor = ConsoleColor.White; WriteLine($@"       Health:{enemy.Health}                     ");// agro should have a stat bar increase
            SetCursorPosition(88, 37); ForegroundColor = ConsoleColor.White; WriteLine(@"++++++++++++++++++++++++++++++++++++++++++++++++++");

        }

        public void Death()
        {//get the position
            SetCursorPosition(29, 10); WriteLine(@" 
                              ,@@@.. .......&&@                 ___           ___           ___           ___
                           &@....................@&            /\__\         /\  \         /\  \         /\__\
                        @@*@...... .. ...... .....,.&         /:/ _/_       /::\  \       +::\  \       /:/ _/_
                       @//&.,  ,.. . ,..... ..........@      /:/ /\  \     /:/\:\  \      |:+:\  \     /:/ /\__\
                      @//@.,..... .. ..................&    /:/ /::\  \   /:/ /::\  \   __+:|\:\  \   /:/ /:/ _/_
                     %/,*@.... .......,.........,.,.. ..@  /:/__\/\:\__\ /:/_/:/\:\__\ /::::+_\:\__\ /:/_/:/ /\__\
                    %.*,,*.............,,.....,.....,...@  \:\  \ /:/  / \:\/:/  \/__/ \:\~~\  \/__/ \:\/:/ /:/  /
                    %..,,,............/&@(#@&@..,........@  \:\  /:/  /   \::/__/       \:\  \        \::/_/:/  /
                   %(,.*@..........&,,,,,,,,.,,%........ @   \:\/:/  /     \:\  \        \:\  \        \:\/:/  /
                   %,.,,@.......,.&,*,*@&,,%@,,.,........@    \::/  /       \:\__\        \:\__\        \::/  /
                   %*.*/@ ..,.,...,@.*,,,,,*,,.%.......,.(,    \/__/         \/__/         \/__/         \/__/
                   @,*,*@..,....,,..,..*,/*.,,, ... . ... %        ___                         ___           ___
                   @*,**%...,..,..... .&&.@......,........@       /\  \          ___          /\__\         /\  \
                   %,.,,@,.. ............................ %      /::\  \        /\  \        /:/ _/_       /::\  \
                   %,,,,&.. ..,.. ...... . ,....,,,,,.. ,.%     /:/\:\  \       \:\  \      /:/ /\__\     /:/\:\__\
                   @.%,,&,..  . .... .. ......,..,..,,,...,*   /:/  \:\  \       \:\  \    /:/ /:/ _/_   /:/ /:/  /
                   @/,//&. ...     . .. ..,...,,,..... ....@  /:/__/ \:\__\  ___  \:\__\  /:/_/:/ /\__\ /:/_/:/__/___
                   @,.,,... ..  ... ...  .,.,,,.,,.,.......&  \:\  \ /:/  / /\  \ +:+  +  \:\/:/ /:/  / \:\/:::::/  /
                   @,,..,..... ........,,.,.,,,,,,,..., ...@   \:\  /:/  /  \:\  \|:|  |   \::/_/:/  /   \::/~~/~~~~
                   @*,.,,@.......... .,,,,,,..,,,..........@    \:\/:/  /    \:\__+:+__+    \:\/:/  /     \:\~~\
                   &,,,,.&.,,..........,.,,,..........,....%     \::/  /      \::::/__/      \::/  /       \:\__\
                   ,,**,/.,,...,......,,,,,.....,...,,.. ..@   .& \/__/        ~~~~           \/__/         \/__/
                    &.,*//@,,.,.*.(..,....,.....,.....,....@. &,%@,*
                .&*  &*,*/,@..,...,.,,.....,..,.,...........&&*,,(*@
                 %,%%&.*///.,,,..,.....,. .....,.....@@@,,**,,**,*&
                  %,./@@*//@,,,,....,(@&&@@,,*,,,,,,,,,,***@&
                   @@**///@@@(*((,///@@@@*,&@@@&

                                                                                ");
        }
        public void Escape()
        {
            SetCursorPosition(10, 0); WriteLine(@"
                    +-------------------------------------------------------------------------------------------------------+
                    |                                                ,,,                                                    |
                    |                                               .***                                                    |
                    |                                                &@                                                     |
                    |                                            .(@@@@@&&&&@@@@%,                                          |
                    |                                       #@@#     ,@@&           %@@.                                    |
                    |                                   (@@                             .%@/                                |
                    |                                %@(                                    /@#                             |
                    |                             .@&      XXXXXXXX                            (@                           |
                    |                           .@#      XXXXXXXXXXXX                            /@.                        |
                    |                          @&       XXXXXXXX  XXXX                             (@                       |
                    |                         @*        XXX XXXX   XXX                              ,@                      |
                    |                       .@.          XXXXXXXXXXXXX                               .&                     |
                    |                       @/            XXXXXXXXXXX                                 /&                    |
                    |                      /@              XXXXXXXX                                   .%                    |
                    |                      %&       XXX     XXXXX      XXX                             %.                   |
                    |                      #&      XXXXXXXXXXXXXXXXXXXXXXX                            .%                    |
                    |                      .@       XXXXXXXXXXXXXXXXXXXXXX                            /&                    |
                    |                       %@           XXXXXXXXXXX                XX---XX           %.                    |
                    |                        @@            XXXXXXX                XXX - - XXX        ##                     |
                    |                         #@            XXXXXX                XX \ o / XX       #@                      |
                    |                          .@*   *((/*****%@(((((((((((((/*********,,,,***,.   (&                       |
                    |                          @@@@/*********/@(((((((((((((/*********(,,,,,,,,,,*&@@@%                     |
                    |                       @@((((((((#@&/***@@(((((((((((((***********(*&@&(///////////%@%                 |
                    |                     @@((((((((#%((((((((((#%&&&@@@@@&&&&%##/////////////&&(//////////&@,              |
                    |                   *@(((((((((****((((((((((((((((((((((((((///////////#****////////////#@(            |
                    |                  @&(((((((((#,,,,%(((((((((((((((&&&&&&((((///////////#,,,,#/////////////#@*          |
                    |                 @&(((((((((((((((((((((((((((((((%&&##%(((////////////////////////////////@@          |
                    |                   &@@@%(((((((((((((((((((((((((((((((((///////////////////////((%@@@@@@@*            |
                    |                           .*#%&@@@((###%%&&&&&&&&&&&&&&&&&&%%###((/******&@/,.                        |
                    |             /                     .@@@@@&((((((((((((((((((((/****@@@%(@*                             |
                    |                                    %@@@@@@(%********************@@@@@@(%&          /                  |
                    |                      /              /@@%&@@.  ./#&@@@@@@(&@/.    &@@@@@*                              |
                    |                  /                                  @@@@&                                             |
                    |              /               /                              /           /        /                    |
                    |                                             /                                                         |
                    +-------------------------------------------------------------------------------------------------------+
                                                           ");


        }
        public void FightImage()
        {
            SetCursorPosition(15, 2); WriteLine(@"            
                      ,(%%&&%%#                                                                         ..                  .
                     .&&&%%&%%%%&#/,                                                                ..        ##########(#      .
                    %&&@%%#%##&%&@@&%.                                                           .      ######################    ..
                   #@#@&&&&      /%%##%&/        .                                              .     (#########((((((((###(((((((    .
                   %@@%#@&#     ,#%#&*(,/%#*###,/(                                           .     ######&(&&&&&(((((%&&&&&&&&((((/   .
                    %&&&&*     (%&&%/%@@&&%#%#%%,                                         .    #####&&%&&(               &&(((((((    .
                    ,##&%%(/(/((%@@&((%#%&@&&%%%/                                        .    ######%#&&(              &&%(((((((((   .
                     %%%%&%&#%%&%@&(&&/                                                .    &&&&&&(#&&&             /&&&%((((((((((    .
                  %#%&%&&&&%&&&%##&&&&&                                                 .     &  &###&&&&&&&&&&&&&&&&%/(((#((((&(    .
                 /%&%&@@@&&&&%%&#%&%&@%&                                                  .   &&&#######&&&&&&&&&&&#####%(((((&(    .
                 #&%#&@&&&##%*&%&&%%#&@#          ###                                    .   &&#################&&&####(((&(&(     .
                 %&##&@@@&&%%%&%&&&%%&&      #%&%%/                                      .   &#####&############(&####((&#((     .
                %&%%%&.&@@@@&%#&&&&%&&/  %%&%%%                                           .   *#####&##############%(((&#(%.   ..
              &&&%(&@# &&&&&%&&##%(%%%%%%%%                                                .    %###############%##(((%##((      .
            ,%#%##,%%#%%&%%&%(#%%(,(/#/(#%(#/,                                              .    %#########%####%((((%##(((        .
            &&&&@&&#(#%#%(#%#(##%(@#@*&#%%%&%%(                                              .    %############(((((&%#%((((  *    .
             /%%##&&&@@&&@@@&#%&@@@@@&&&/*.%%##/                                              .    %##########(%%##%&##((((#%
                    #%%@@&%%@@&@@@@&&%&&#%&(      *                                            .    #####%%####&&&%%%#%(((%(((     .
                   /#&&&@@@@&%&&@@@%##%%%%(&&%                                                .    .#(#### ,%##&&&&%####(%#%%##      .
                    %%%&%&&&@@@@&&&##%%%&%%..&%%                                           .               /  #%&&&%###((#% (((((%   .
                    *(#&&%%&&&&&( &&&%%##&%/   *%#/                                        .       %#(   %      (%&%&#((##%((  ((     .
                    // #%&&@&@&&% #&%%###@%       ###                                       .        .  %       %#%&#((#%(((*(( (     .
                    .  .%&&@@@@@.  (@&%%%##                                                         #    &  %, &##%##(#%(%/*#.###    ..
                        (%@@@@&%    %&&##%&%                                                      *     &    .,(%###(%&/./(%% (((       .
                        (%@@@&#/,/  &%/(&%%%&                                                 .      .     *((,(##%(#& /(((( #%/(  ((    .
                        .#%###%%/(% %&@&%%&%(                                                   .   %     (((#* %%(*#   (((((  %%       .
                           (#/#%%%&  &&&##%@@(                                                   .                    ###             .
                                  %. @&&%(%&@#/                                                        .    ...       %    ..  ....
                      


");
        }

        public void Ending()
        {
            WriteLine(@"
                                                          &&&  *%%%     ,%&&%%&%%
                                                        &%#  %%%     &&%&%,., &&%
                                                      *%%  /%&    .%&&#... &%%%*
                                                     .%&  %%#    &%%/.,. &%%(
                                                     &%. *&&   .&&&.,. ,%%%
                                                     *%  &%.   &%&,,,  %%#
                                                         .(   (%%.,,. &%%
                                                           ./&&&&.... &%%%,
                                                       %%%%%%#*.,,,,,.  ,#&%%%&/
                                                    &&%&*,,,,,,.,.,.,.,.,,,.  #&%&/
                                                  &&%/,...................,,...  &%%(
                                                /%%#,,,.,.,.,.,.,.,.,.,.,.,.,.,.,  &%%
                                               ,%%/.,.........................,,.,. &%&
                                               &%&.,..,...,.,.,....,,.,,...,,,..,,, .%%(
                                              *&%&%%%%%%%%%%&%%%%%%%%&%&%%%%%%%%%%%%%%%%.
                                           &%%%%%&%%%%%%%%%&*...,,,,,...,. (&%%%%%%%%%%&%%%(
                                        (%%%/%%%%%%%%%%%%%,,,......,,....,.. .%%%%%%%%%%%%%&%%,
                                  ,/(&&%&#..&%%%%%%%%%%%/,,.,.,.,.,.,.,,,,,... &%%%%%%%%%%%(.%%%&%/*.
                              *%%&&&%(,..,,%%%%%%%%%%%&%,..,%&%%,,,,,..(&%&#... %%%%%%%%%%%&,,. ,(&&&%%%
                              &%&...,.,.,,.&%%%%%%%%%%%,,.,%/.,&%,,.,.&%*..&#,, *%%%%%%%%%&%,.,,,,,. .%%*
                               %%%%,.,,....,%%%%%%%%%%.,...,.,..,,,.,.,,,.....,, #%%%%%%%%%%.,.,.,.,&%%#
                                 ,&%%%%%%%&%%%%%%%&&/.,.,.,.,./&%%%%%%%%&.,.,.,... %%&%%%%%%%%%%%%%%%.
                                        .%%&%%%%%%%%%%/,,....,,%%&%%%&%%/.....,.,%&%%%%%&%&%%&%
                                      %%&%,,,.,.,.,,,&%%#,.,,,,,,.#%%,,.,.,.,..%%%/,,.,,,.,.,/%&%,
                                    .%%&,..#,........,,%%#,..,,,.,%&%%.,.....,%%%,..,.....,*/,,*&&&
                                    &%%..#%&,,,%%*,.,..%&%#**/%&&&%,%&&%%#**/%%%/,,.,.&%#..,%&,,/%&,
                                     &%%%&%,..%%*.,*%%%%%#&&&&/.        ,%&&&&#%%%%(,..%%*..#%%%%%/
                        __     __                               _                ,%&&%&%%%&%&&/
                         \ \   / /                              | |
                          \ \_/ /__  _   _  __      _____  _ __ | |
                           \   / _ \| | | | \ \ /\ / / _ \| '_ \| |
                            | | (_) | |_| |  \ V  V / (_) | | | |_|
                            |_|\___/ \__,_|   \_/\_/ \___/|_| |_(_)

");
        }
    }
}



