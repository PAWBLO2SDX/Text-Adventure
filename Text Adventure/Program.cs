using Microsoft.VisualBasic;
using System;
using System.Text.RegularExpressions;

namespace Text_Adventure
{
    internal class Program
    {
        public static Player currentPlayer = new Player();

        static void TypeLine(string line, int delay = 50)
        {
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                Thread.Sleep(delay); // Sleep for 150 milliseconds
            }
        }


        static void Main(string[] args)

        {
            //static void TypeLine(string line, int rInt)
            //{
            //    string output = null;
            //    char[] characters = line.ToCharArray();
            //    for (int i = 0; i < characters.Length; i++)
            //    {
            //        output += characters[i];
            //        Console.Clear();
            //    }

              
            //    TypeLine(output);
            //}
               TypeLine("Welcome, Escape The  Paradox!\r\n", 75);

              TypeLine("Name: it cannot be accessed right now \r\n");

            Console.ReadKey();
            Console.Clear();


               TypeLine("You awaken in a stone cold room. your head is spinning and you feel dazed, as if you'd been drugged.  You do not remember your name or how old you are  \r\n");
               TypeLine("You pick yourself up and infront of you, you blurrily see 5 rooms");
            Console.ReadKey();
            Console.Clear();

            TypeLine("which room would you like to go in?!!!!!\n");
            TypeLine("BIG FRIENDLY ROOM \n");

            TypeLine("UKNOWN\n");

            TypeLine("THE BASEMENT OF FUN\n");

            TypeLine("\"UKNOWN\n");

            TypeLine("UKNOWN\n");
            Console.ReadKey();
            Console.Clear();


            TypeLine("You have approached the door,");
            TypeLine(" PRESS (ENTER) to HOP IN \n");
            Console.ReadKey();
            Console.Clear();
                 Console.WriteLine("======================================================================================");
                 Console.WriteLine(" =                              Entered                                               =");
                 Console.WriteLine(" =                        BIG FRIENDLY ROOM                                           = ");
                  Console.WriteLine("====================================================================================");
            Console.ReadKey();
            Console.Clear();

            TypeLine(" +\r\n                \"You have Encountered a Man who Goes by the name of The Wise One. \r\n");

            TypeLine("\n \"As you encounter the man you have options Of Attacking or an option of staying back and being trapped \n ");
            
            Console.ReadKey(true);
            Console.Clear();


            Console.WriteLine("======================================================================================================");
            Console.WriteLine("                           YES = (E)NTER         OR    NO = I DO NOT KNOW FIGURE IT OUTTTTT        ");
            Console.WriteLine("=====================================================================================================");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("==============================================================================================");
            Console.WriteLine("       Name has been chosen as Leo    ");
            Console.WriteLine("===============================================================================================");
            Console.WriteLine("|                   (A)ttack  = 10                               (D)efend = 5             ");
            Console.WriteLine("                          (P)ower = 4                 (H)eals   = 500                 ");
            Console.WriteLine("==============================================================================================");
            Console.WriteLine("==============================================================================================");
            //Encounter Generic 
             //Encounters        
            {
                Console.WriteLine("  \n     Press (E)nter to Open the door  \n  ");
                TypeLine("You open the door gently, in order to be as quiet as a ninja  so he wont catch you. ");
                TypeLine("You are in need of a weapon so you vividly see a shield but as you go to grab it, while charging at the man who captured you");
                TypeLine("  \"He Turns... \"");
                TypeLine("");

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
                Console.WriteLine(" You have done damage to The Wise man your attack has been set  back dealing a total damage of = 50");
              
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
