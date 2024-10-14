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
            // Display current Foreground color 
            //Console.WriteLine(Console.ForegroundColor);

            // Set the Foreground color to blue 
            Console.ForegroundColor = ConsoleColor.Blue;

            // Display current Foreground color 
            //Console.WriteLine(Console.ForegroundColor);

            string Answer = Console.ReadLine();

                              TypeLine("\"Welcome, You have been chosen to Escape The Paradox !\r\n", 90);
            TypeLine("\"Out of 8 billion people you have been the one to test out our latest invention so welcome to the Room \r\n");

            TypeLine(" \"We know you are confused, So this is a WARNING!! \r\n");

            TypeLine(" \" The ROOMS you are going to enter 5 rooms in which we are unsure what the causes are for each room since they are undentified  \r\n");

            TypeLine(" \" You will be Guided through whichever room you have picked  \r\n");


            Console.ReadKey();
            Console.Clear();

            TypeLine("You pick yourself up and infront of you, you blurrily see 5 rooms\n");
            TypeLine("You awaken in a stone cold room. your head is spinning and you feel dazed, as if you'd been drugged.\n");
            TypeLine("You do not remember anything, the last thing you remember is the showcase for the project that was built  around 6:30pm. \n");
            TypeLine("  Name: it cannot be accessed \r\n");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("which room would you like to go in?!!!!!\n");

            TypeLine("\n");

            Console.WriteLine("BIG FRIENDLY ROOM \n");

            Console.WriteLine("\"UKNOWN\n");

            Console.WriteLine("\"THE BASEMENT OF FUN\n");

            Console.WriteLine("\"UKNOWN\n");

            Console.WriteLine("\"UKNOWN\n");
          


            TypeLine("You have approached the door,");
            if (Answer == "BIG FRIENDLY ROOM")

            {
                NiceRoom();
                static void NiceRoom()
                {              
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("======================================================================================");
                    Console.WriteLine(" =                              Entered                                               =");
                    Console.WriteLine(" =                        BIG FRIENDLY ROOM                                           = ");
                    Console.WriteLine("====================================================================================");
                    Console.ReadKey();
                    Console.Clear();
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }
            Console.ReadKey();
            Console.Clear();
            TypeLine(" +\r\n                \"                        You have Encountered a Max                     \r\n");

            TypeLine("\n \"You get stunned from the man,he is the one who trapped you the captor is seen with the \n ");

            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("                YES = (E)NTER             ");
            Console.WriteLine("===========================================");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("==============================================================================================");
            Console.WriteLine("       Name has not been chosen");
            Console.WriteLine("===============================================================================================");
            Console.WriteLine("|                   (A)ttack  = 10                               (D)efend = 5             ");
            Console.WriteLine("                          (P)ower = 4                 (H)eals   = 500                 ");
            Console.WriteLine("==============================================================================================");
            Console.WriteLine("==============================================================================================");
            //Encounter Generic 
             //Encounters        
            {
                TypeLine("You open the door gently,   so he wont catch you so you are quiet. ");
                TypeLine("You are in need of a weapon so you vividly see a shield  nearby you but as you try to grab  it.");
                TypeLine("  \"He Turns and looks at you with such anger... \"");
                TypeLine(" He runs after you when you have the shield and weapons you have contained");
                TypeLine("");
                TypeLine("");
                TypeLine("You open the door gently, in order to be as quiet as a ninja  so he wont catch you. ");
                TypeLine("You are in need of a weapon so you vividly see a shield but as you go to grab it, while charging at the man who captured you");
                Console.ReadKey(true);
                Console.Clear();
                TypeLine("\nCOMBAT HAS BEEN ENCOUNTERED\n");
                Console.ReadKey(true);
                Console.Clear();

                Console.WriteLine("===============================================================================================");
                Console.WriteLine("|              Press (A) to attack          &                  (D) Defend                      ");
                Console.WriteLine("==============================================================================================");

                Console.ReadKey(true);
                Console.Clear();
                Console.WriteLine("===============================================================================================");
                Console.WriteLine("|                   (A)ttack  = 10                               (D)efend = 5             ");
                Console.WriteLine("                          (P)ower = 4                 (H)eals   = 450           ");
                Console.WriteLine("==============================================================================================");
                Console.WriteLine("==============================================================================================");
                Console.WriteLine(" You have done damage to The Wise  your attack has been set ");
              
                Console.ReadKey(true);
                Console.Clear();

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
