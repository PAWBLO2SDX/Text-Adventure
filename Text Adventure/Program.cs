using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Text_Adventure
{
    internal class Program
    {
        public static Player currentPlayer = new Player();

        static void TypeLine(string line, int delay = 90)
        {
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                Thread.Sleep(delay); // Sleep for 150 milliseconds
            }
        }


        static void Main(string[] args)
        {

            // Set the Foreground color to blue 
            Console.ForegroundColor = ConsoleColor.Blue;

            // Display current Foreground color 
           

            string Answer = Console.ReadLine();

           TypeLine("\"Welcome, You were "+ " chosen to Escape The Paradox !\r\n", 90);

            Console.WriteLine("\n");
            TypeLine("\"Out of 8 billion people you have been chosen to be our test subject. latest invention so welcome to the Room \r\n");

            TypeLine(" \"We know you are confused, So this is a WARNING!! \r\n");

            TypeLine(" \" They're" +
                " 5 GATEWAYS given, in which we are unsure what the causes are Behind these Rooms these Rooms has not been identified for any reason");

            TypeLine(" \" You will be Guided through whichever CHAMVBERS  you have Chosen  \r\n");


            TypeLine(" \" PRESS  (E)ENTER FOR  NEXT PART.....  \r\n");

            Console.ReadKey();
            Console.Clear();

            TypeLine(" \" PART 2  \r\n");
            Console.WriteLine("\n");
            TypeLine("");
            TypeLine(" 10:30 PM \n");
            Console.WriteLine("\n");
            TypeLine("You awaken in a stone cold room. your head is spinning and you feel dazed, as if you'd been drugged.\n");

            TypeLine("You pick yourself up and infront of you, you blurrily see 5 rooms\n");

            TypeLine("\"The last thing you remember is the showcase for the project that was built. \n"); 
            //This is the scene where the Player is in a state of where they can vividly see amd think
            //The Player encounters Rooms
            
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\"which room would you like to go in?\n");

            Console.WriteLine("\n");

            Console.WriteLine("\"BIG FRIENDLY ROOM \n");
           
            Console.WriteLine("\"THE BASEMENT OF FUN\n");

            Console.WriteLine("\"Documents \n");

            Console.WriteLine("\"UKNOWN\n");

            Console.WriteLine("\"UKNOWN\n");

            Console.ReadLine();

                TypeLine("You have approached the door,");
            if (Answer == "BIG FRIENDLY ROOM")

            {
              
            }
            

            BIGFRIENDLYROOM();
            static void BIGFRIENDLYROOM()
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("======================================================================================");
                Console.WriteLine(" =                              Entered                                               ");
                Console.WriteLine(" =                        BIG FRIENDLY ROOM                                          ");
                Console.WriteLine("====================================================================================");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("\n");
            TypeLine("\"You have Encountered Documents, You realize the documents are about who you are as a person. You gained vivid memory \n");
            TypeLine("\" The memory of who you really are. \n");

            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("                Documents = TYPE          ");
            Console.WriteLine("===========================================");
            Console.ReadLine();
            if (Answer == "Documents")

            {

            }

            Documents();
            static void Documents()
            {          
                Console.WriteLine("==============================================================================================");
                Console.WriteLine("      0010011 ");
                Console.WriteLine("===============================================================================================");
                Console.WriteLine("|                   (A)ttack  = 10                               (D)efend = 5             ");
                Console.WriteLine("                          (P)ower = 4                 (H)eals   = 500                 ");
                Console.WriteLine("==============================================================================================");
                Console.WriteLine("==============================================================================================");
            }
       
            //Encounter Generic 
             //Encounters        
            {
                TypeLine("\"You open the door gently,\n");
                TypeLine("\"You are in need of a weapon, so you go and look around the for what you can find around you \n");

                TypeLine("  \"He Turns and looks at you with such anger... \"");
                TypeLine(" \"He runs after you when you have the shield and weapons you have contained\n");                              
                TypeLine("\"You are in need of a weapon so you vividly see a shield but as you go to grab it, while charging at the man who captured you..... \n");
                Console.ReadKey(true);
                Console.Clear();
                TypeLine("\nCOMBAT HAS BEEN ENCOUNTERED\n");
                Console.ReadKey(true);
                Console.Clear();

                Console.WriteLine("==================================");
                Console.WriteLine("\"             TYPE to (A) to Attack");
                Console.WriteLine("================================ ");
                Console.ReadLine();
                if (Answer == "A") ;
                {

                }
                Player();
               static void Player()
                {
                    Console.Clear();
                    Console.WriteLine("===============================================================================================");
                    Console.WriteLine("|                   (A)ttack  = 10                               (D)efend = 5             ");
                    Console.WriteLine("                          (P)ower = 4                 (H)eals   = 450           ");
                    Console.WriteLine("==============================================================================================");
                    Console.WriteLine("==============================================================================================");
                    Console.WriteLine(" You have done damage to The Wise  your attack has been set ");

                }
               
                

            }

            


          

        }

      

    }


    class Player
    {
        public string name;
        public int derekdollars  = 0;
        public int health = 10;
        public int damage = 1;
        public int armorHealth = 0;
        public int shields;

    }
    
    class Encounters
    {
        //Encounter Generic 


        //Encounters
        public static void FirstEncounter()
        {
           
        }
        
        //Encounter Tools
        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (h < 0)
            {
                Console.WriteLine("==========================");
                Console.WriteLine("|(A)ttack       (D)efend |");
                Console.WriteLine("| (P)owereals |");
                Console.WriteLine("==========================");
                Console.WriteLine("Shields: " + Program.currentPlayer.shields);
            }
        }
    }
}
