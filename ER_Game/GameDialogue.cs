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
            SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; WriteLine($"                                                              ");
            SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; PrintbyChar($"You must finish the event before you can travel!"); 
        }
        public void Escape()
        {
            SetCursorPosition(58, 40); ForegroundColor = ConsoleColor.White; PrintbyChar($"Oh no!");
            SetCursorPosition(58, 41); ForegroundColor = ConsoleColor.White; PrintbyChar($"Those goons are getting away with Irno!!!");
            SetCursorPosition(58, 42); ForegroundColor = ConsoleColor.White; PrintbyChar($"Quick, you have to chase after them!!!");
            SetCursorPosition(54, 43); WriteLine("Press any key to continue...");
        }
       

        public void Chapter1()
        {
            Clear();
            SetCursorPosition(7, 5); ForegroundColor = ConsoleColor.White; PrintbyChar("Ocil: Man we can't come back to Bhailmaith empty handed, you know what will happen when he finds out we failed");
            SetCursorPosition(7,6); ForegroundColor = ConsoleColor.DarkRed; PrintbyChar("Thruul: Hush fool, I cant believe you lost 50K krubels in beets. I got an idea tho. You see that Mark VI infront of us,");
            SetCursorPosition(7, 7); ForegroundColor = ConsoleColor.DarkRed; PrintbyChar(" its an expensive ride right?");
            SetCursorPosition(7, 8); ForegroundColor = ConsoleColor.White; PrintbyChar("Ocil: Yea, I dont see what you're getting at tho?");
            SetCursorPosition(7, 9); ForegroundColor = ConsoleColor.DarkRed; PrintbyChar("Thruul: Stupid, lets jack the ride and sell it. Its gotta be worth at least 100K krubels.");
            SetCursorPosition(7, 10); ForegroundColor = ConsoleColor.DarkRed; PrintbyChar("Thruul: On second thought, you see that dog. That's the rarest breed in the universe, lets take it and sell it");
            SetCursorPosition(7, 11); ForegroundColor = ConsoleColor.White; PrintbyChar("Ocil: Drop me off at the nearest planet so if she tries to follow or give us any problems I can take her out.");
            SetCursorPosition(7, 12); ForegroundColor = ConsoleColor.DarkRed; PrintbyChar("Thruul: You know Ocil, you're pretty stupid which is why you're the lowest, but for once, you have a good idea. I'll drop you off at Kir");
            SetCursorPosition(7, 13); ForegroundColor = ConsoleColor.DarkGray; WriteLine("Press any key to continue...");
            ReadKey();
            SetCursorPosition(7, 14); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("The year is 4502. Audinians are the superior race of the galaxy. The Human Elta is riding with her dog Irno.");
            SetCursorPosition(7, 15); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("As Elta stops to talk with a shopkeeper, a spaceship parked next to her kidnaps Irno! ");
            SetCursorPosition(7, 16); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Elta comes back to find Irno missing and with a ransom note on her seat: ");
            SetCursorPosition(7, 17); ForegroundColor = ConsoleColor.DarkGray; PrintbyChar("Press any key to continue...");
            ReadKey();
            SetCursorPosition(7, 18); ForegroundColor = ConsoleColor.White; PrintbyChar(" Bring us 50,000 krubels to Planet Kir if you want to see your pet alive. -Ocil");
            SetCursorPosition(7, 19); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Ocil is a known Audinian capo from the Vakir Mafia.");
            SetCursorPosition(7, 20); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Elta is now faced with a decision of; Get 50K krubels or rescue her dog from the Audinians");
            SetCursorPosition(7, 21); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Elta hops in her Mark VI spacecraft and sets out to find out who kidnapped her puppy");
            SetCursorPosition(7, 22); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Upon landing on plaent Kir, she finds Ocil waiting for her.");
            SetCursorPosition(7, 23); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: WHERE IS MY IRNO!!!!!");
            SetCursorPosition(7, 24); ForegroundColor = ConsoleColor.White; PrintbyChar("Ocil: Wooah Woah Woah little lady, what do you think you're gonna do huh? You gonna cwy buahah!");
            SetCursorPosition(7, 25); ForegroundColor = ConsoleColor.White; PrintbyChar("So you got out Krubels or what you human scum?");
            SetCursorPosition(7, 26); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: *Evil smirks* I'm glad you asked.");
            SetCursorPosition(7, 27); ForegroundColor = ConsoleColor.DarkGray; PrintbyChar("Press any key to continue...");
            ReadKey();
            Clear();

        }
      public void ScreenDirections()
        {
            Clear();
            SetCursorPosition(80, 11); ForegroundColor = ConsoleColor.White; PrintbyChar("Welcome to the planet map!");
            SetCursorPosition(80, 12); ForegroundColor = ConsoleColor.White; PrintbyChar("You objective is to stop the dog stealing- alien mobsters! ");
            SetCursorPosition(80, 13); ForegroundColor = ConsoleColor.White; PrintbyChar("The mobsters will be hanging out around thier spaceship. ");
            SetCursorPosition(80, 14); ForegroundColor = ConsoleColor.White; PrintbyChar("Be forewarned, you don't want to pick a fight");
            SetCursorPosition(80, 15); ForegroundColor = ConsoleColor.White; PrintbyChar("with them before building up your armor and power! ");
            SetCursorPosition(80, 16); ForegroundColor = ConsoleColor.White; PrintbyChar("For that, you should check out the shop,");
            SetCursorPosition(80, 17); ForegroundColor = ConsoleColor.White; PrintbyChar("they are located in the buildings that have ( { or } ) as  a door. ");
            SetCursorPosition(80, 18); ForegroundColor = ConsoleColor.White; PrintbyChar("You can explore the world using the directional arrows.");
            SetCursorPosition(80, 19); ForegroundColor = ConsoleColor.White; PrintbyChar("Press (J) to activate the help screen");
            SetCursorPosition(80, 20); ForegroundColor = ConsoleColor.White; PrintbyChar("Press any key to continue...");
            ReadKey();
            Clear();
        }
        public void AfterBossFight()
        {
            Clear();
            SetCursorPosition(80, 11); ForegroundColor = ConsoleColor.White; PrintbyChar("Now that you beat the boss, you have to chase after those goons!");
            SetCursorPosition(80, 12); ForegroundColor = ConsoleColor.White; PrintbyChar("Don't let them get away with Irno! ");
            SetCursorPosition(80, 13); ForegroundColor = ConsoleColor.White; PrintbyChar("Jump into your spaceship to travel to the next planet!");
            SetCursorPosition(80, 14); ForegroundColor = ConsoleColor.White; PrintbyChar("Press any key to continue...");
            ReadKey();
            Clear();
        }
        public void Chapter2()
        {
            Clear();
            SetCursorPosition(7, 5); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("On planet Gasparagus...");
            SetCursorPosition(7, 6); ForegroundColor = ConsoleColor.DarkRed; PrintbyChar("Thruul: Yilkir, you gotta take this dog. The owner is insane. She might've killed Ocil."); //Interactions between Thruul and Yilkir
            SetCursorPosition(7, 7); ForegroundColor = ConsoleColor.DarkBlue; PrintbyChar("Yilkir: What? Where's the beets?");
            SetCursorPosition(7, 8); ForegroundColor = ConsoleColor.DarkRed; PrintbyChar("Thruul: Long story. We need to sell the dog to get the krubels now. Also the owner is following me.");
            SetCursorPosition(7, 9); ForegroundColor = ConsoleColor.DarkBlue; PrintbyChar("Yilkir: I'll have my men deal with her. If she gets to us, she's your problem though.");
            SetCursorPosition(7, 10); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Elta lands on planet Gasparagus in search of Irno...");

            Console.ReadKey();


            SetCursorPosition(7, 11); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Elta finds Thruul with another capo named Yilkir.");  //Elta finds Thruul
            SetCursorPosition(7, 12); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: IRNO!");
            SetCursorPosition(7, 13); ForegroundColor = ConsoleColor.DarkYellow; PrintbyChar("Irno: awoooo...");
            SetCursorPosition(7, 14); ForegroundColor = ConsoleColor.DarkBlue; PrintbyChar("Yilkir: She's just a human. Stop being stupid and fix your own problems. I'll take the mutt to Tanqin on planet kabuhj.");
            SetCursorPosition(7, 15); ForegroundColor = ConsoleColor.DarkBlue; PrintbyChar("Yilkir leaves in a spaceship with Irno");
            SetCursorPosition(7, 16); ForegroundColor = ConsoleColor.DarkRed; PrintbyChar("Thruul: What did you do to Ocil!?");
            SetCursorPosition(7, 17); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: Dont worry about it scrub, lets tussle!");

            
            Console.ReadKey();
            Clear();
        }
        public void Chapter2End()
        {
            Clear();
            SetCursorPosition(7, 18); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: Man you Audinians sure are a lot of talk but no bite");
            SetCursorPosition(7, 19); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: I know where Irno is so really theres no need for you huh");
            SetCursorPosition(7, 20); ForegroundColor = ConsoleColor.DarkRed; PrintbyChar("Thruul: Aah!! Don't kill me! Please");
            ReadKey();
        }
        public void Chapter3()
        {
            SetCursorPosition(7, 5); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("On planet Kabuhj...");
            SetCursorPosition(7, 6); ForegroundColor = ConsoleColor.DarkBlue; PrintbyChar("Yilkir: Man where in the world *Pun intended* is Ocil and Thruul ");
            SetCursorPosition(7, 7); ForegroundColor = ConsoleColor.Magenta; PrintbyChar("Tanqin: I don't know, but they are late. They should've been here hours ago. You think something went wrong.");
            SetCursorPosition(7, 8); ForegroundColor = ConsoleColor.DarkBlue; PrintbyChar(" Yilkir: I hope not. You know word in the universe is that they lost the beets. That's why they gave us this Expensive Dog and ha-");
            SetCursorPosition(7, 9); ForegroundColor = ConsoleColor.Magenta; PrintbyChar("Tanqin: YOOOO Watch out, that Mark VI is coming in hot");
            SetCursorPosition(7, 10); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: Irnoooo!!");
            SetCursorPosition(7, 11); ForegroundColor = ConsoleColor.Magenta; PrintbyChar("Yilkir: Yo Tanqin, take the dog and bug out. I'll handle this human scum.");
            SetCursorPosition(7, 12); ForegroundColor = ConsoleColor.Magenta; PrintbyChar("Yilkir: Hey, where's my boys Ocil and Thruul?");
            SetCursorPosition(7, 13); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: They got dealt with, which will be the same with you, if you don't make that Audinian turn his craft around and bring me back my baby!");
            SetCursorPosition(7, 14); ForegroundColor = ConsoleColor.Magenta; PrintbyChar("Yilkir: Listen here little lady, I'm one of the highest ranking in the Audinian Mob, if you wanna tussle, then lets go trash");
            SetCursorPosition(7, 15); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Press any key to continue...");
            ReadKey();
            Console.Clear();
           
        }
        public void Chapter3End()
        {
            SetCursorPosition(7, 5); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: You Audinians sure talk tough but can never back it up against someone like me. Look at you choking on your own blood");
            SetCursorPosition(7, 6); ForegroundColor = ConsoleColor.Magenta; PrintbyChar("Yilkir: WHAT ARE YOU!?");
            SetCursorPosition(7, 8); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: I'll ask you one last time. Where is IRNO.");
            SetCursorPosition(7, 9); ForegroundColor = ConsoleColor.Magenta; PrintbyChar("Yilkir: My Right pocket, grab my phone.");
            SetCursorPosition(7, 10); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Yilkir: Hit Redial");
            SetCursorPosition(7, 11); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Phone Dials...");
            SetCursorPosition(7, 12); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: HELLO!? WHO IS THIS. I don't know who you are, I don't Know what you want. If you are looking for ransom, I dont have any money");
            SetCursorPosition(7, 13); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("but what I do have, is a particular set of skills, skills that make me a nightmare for trash like you. I will find you, and I will save IRNO!");
            SetCursorPosition(7, 14); ForegroundColor = ConsoleColor.DarkYellow; PrintbyChar("Bhailmaith: A good death is its own reward scum! CLICK");
            SetCursorPosition(7, 15); ForegroundColor = ConsoleColor.Magenta; PrintbyChar("Yilkir: Please I am dying, Bhailmaith and Tanqin are on Planet Brokholi, just spare me");
            SetCursorPosition(7, 16); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Press any key to continue...");
            ReadKey();
            Clear();

        }
        public void Chap4Dialouge()
        {
            //change the position
            SetCursorPosition(7, 5); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("On planet Brokholi...");
            SetCursorPosition(7, 6); ForegroundColor = ConsoleColor.White; PrintbyChar("Tanqin: Boss who was that?");
            SetCursorPosition(7, 7); ForegroundColor = ConsoleColor.DarkYellow; PrintbyChar("Bhailmaith: *Pimp Slaps Tanqin* YOU STUPID RHINOCEROS PIZZLE, WHAT IS GOING ON. WHO IS THIS ON YILKIRS PHONE");
            SetCursorPosition(7, 8); ForegroundColor = ConsoleColor.White; PrintbyChar("Tanqin: B- B- Boss Shess-");
            SetCursorPosition(7, 9); ForegroundColor = ConsoleColor.DarkYellow; PrintbyChar("Bhailmaith: Did I SAY SPEAK?");
            SetCursorPosition(7, 10); ForegroundColor = ConsoleColor.White; PrintbyChar("Tanqin: No you did not:");
            SetCursorPosition(7, 11); ForegroundColor = ConsoleColor.DarkYellow; PrintbyChar("Bhailmaith: All I asked was that you all go and sell the beets to the kurds, but apparently you turds can't even handle that.");
            SetCursorPosition(7, 12); ForegroundColor = ConsoleColor.DarkYellow; PrintbyChar("Bhailmaith: Well, SPEAK!");
            SetCursorPosition(7, 13); ForegroundColor = ConsoleColor.White; PrintbyChar("Tanqin: It was Thruul and O--");
            SetCursorPosition(7, 14); ForegroundColor = ConsoleColor.DarkYellow; PrintbyChar("Bhailmaith: SHUT UP, GIVE ME THE DOG AND SECURE THE AREA. ");
            SetCursorPosition(7, 15); ForegroundColor = ConsoleColor.DarkYellow; PrintbyChar("I know that rat Yilkir squealed and told her where we are. She's probably on her way right now");
            SetCursorPosition(7, 16); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Press any key to continue...");
            ReadKey();
            SetCursorPosition(7, 17); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("As Tanqin heads out and locks the gate, he sees Elta already outside waiting on him.");
            SetCursorPosition(7, 18); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: What's the matter Tanqin, you look like you've seen a ghost.");
            SetCursorPosition(7, 19); ForegroundColor = ConsoleColor.White; PrintbyChar("Tanqin: Haha, sorry baby but thats what I'm about to turn you into once I'm done with you.");
            SetCursorPosition(7, 20); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: You wanna tango with the Rango, buddy boy? then lets go!");
            SetCursorPosition(7, 21); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Press any key to continue...");
            ReadKey();
            Clear();
        }
        public void Chap4End()
        {// change the position
            SetCursorPosition(7, 5); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Elta: Just like Ocil, Thruul and Yilkir. WEAK!");
            SetCursorPosition(7, 6); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Tanqin: Please, just spare me. It wasn't my idea, it was originally Thruul's idea.");
            SetCursorPosition(7, 7); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Elta: Just tell me where my dog is!");
            SetCursorPosition(7, 8); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Tanqin: Ok Ok, Bhailmaith has him, he's in there, locked away. NOW PLEASE.");
            SetCursorPosition(7, 9); ForegroundColor = ConsoleColor.White; PrintbyChar("Press any key to continue...");
            ReadKey();
            Clear();

        }
        public void Chap5Dialouge()
        {
            //change the position
            SetCursorPosition(7, 5); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Elta: Hellooo? Anyone here?");
            SetCursorPosition(7, 6); ForegroundColor = ConsoleColor.DarkYellow; PrintbyChar("Bhailmaith: So you finally defeated all my henchmen huh. ");
            SetCursorPosition(7, 7); ForegroundColor = ConsoleColor.DarkYellow; PrintbyChar("You know, my organization could use someone like you. So why dont you stop");
            SetCursorPosition(7, 8); ForegroundColor = ConsoleColor.DarkYellow; PrintbyChar(" and join the winning team");
            SetCursorPosition(7, 9); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: Oh no, I think I will keep going. Brick by Brick, Dollar by Dollar, Body by Body...Or you can give me my dog back");
            SetCursorPosition(7, 10); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: What do you see when you look at me?");
            SetCursorPosition(7, 11); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("*Elta walks towards Bhailmaith.");
            SetCursorPosition(7, 12); ForegroundColor = ConsoleColor.DarkYellow; PrintbyChar("Bhailmaith: Not one more step human scum, or the dog gets it.");
            SetCursorPosition(7, 13); ForegroundColor = ConsoleColor.DarkYellow; PrintbyChar("*Bhailmaith cowardly grabs Irno in a rush*");
            SetCursorPosition(7, 14); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: IRNOOOO!");
            SetCursorPosition(7, 15); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Irno: bark bark!: Irno screams as hes tortured by Bhailmaith");
            SetCursorPosition(7, 16); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: You so scared to fight me you torture my dog? Fight me like a man Bahil boy.");
            SetCursorPosition(7, 17); ForegroundColor = ConsoleColor.DarkYellow; PrintbyChar("Bhailmaith: You know what, I don't need this dog to beat you. Lets go filth");
            SetCursorPosition(7, 18); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Press any key to continue...");
            ReadKey();
            Clear();
        }
        public void Ending()
        {
            //change the position
            SetCursorPosition(7, 5); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: Irnooo!");
            SetCursorPosition(7, 6); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("*Irno runs and jumps in Elta's arm");
            SetCursorPosition(7, 7); ForegroundColor = ConsoleColor.DarkYellow; PrintbyChar("Bhailmaith: Why? All this over a stupid dog.");
            SetCursorPosition(7, 8); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: Someone real special gave me this dog, and I'd fight you all again and again for this 'stupid dog'.");
            SetCursorPosition(7, 9); ForegroundColor = ConsoleColor.DarkYellow; PrintbyChar("Bhailmaith: You think you just gone beat me? We the Audinian MAFIA, WE ALWAYS WILL AN ALWAYS GONE BE HERE.");
            SetCursorPosition(7, 10); ForegroundColor = ConsoleColor.DarkCyan; PrintbyChar("Elta: Come on baby boy, lets go.");
            SetCursorPosition(7, 11); ForegroundColor = ConsoleColor.DarkGreen; PrintbyChar("Press any key to continue...");
            ReadKey();
            Clear();

        }
    }
}
