using Microsoft.VisualBasic;
using System;

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
            TypeLine("The World Of Paradox!\r\n", 50);
            TypeLine("Name: UNKNOWN");

            Console.Clear();
            TypeLine("You awake in the Cold!,Stone, dark room. You feel dazed and are having a trouble time remembering where you are From The Past events\r\n");
             TypeLine("which room would you like to go in?!!!!!\r\n");
            

            Console.ReadKey();
            Console.Clear();
            TypeLine("You and have reached to what appears to be a handle of what it seems to be a doorr .");
            TypeLine(" TURN IT BUT SOMETHING MIGHT HAPPEN, WHO KNOWSSS??? PRESS (ENTER) TO HOP IN");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("======================================================================================");
             Console.WriteLine("                               Entered                                               ");
            Console.WriteLine("                        BIG FRIENDLY ROOM                                            ");
            Console.WriteLine("====================================================================================");


            TypeLine(" +\r\n                \"You have Encountered a Man who Goes by the name of The Wise One. \"");

            TypeLine("As you encounter the man you have options Of Attacking or an option of staying back and being trapped ");
            
            Console.ReadKey(true);
            Console.Clear();


            Console.WriteLine("======================================================================================================");
            Console.WriteLine("                           YES = (E)NTER         OR    NO = I DO NOT KNOW FIGURE IT OUTTTTT        ");
            Console.WriteLine("=====================================================================================================");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("==============================================================================================");
            Console.WriteLine("                   Leo    ");
            Console.WriteLine("===============================================================================================");
            Console.WriteLine("|                   (A)ttack  = 10                               (D)efend = 5             ");
            Console.WriteLine("                          (P)ower = 4                 (H)eals   = 500                 ");
            Console.WriteLine("==============================================================================================");
            Console.WriteLine("==============================================================================================");
            //Encounter Generic 
             //Encounters        
            {
                TypeLine("You THROW OPEN THE DOOOR!! you grab a  rusty shield That appears infront of you, while charging at the man who captured you");
                TypeLine(" +\r\n \"He Turns... \"");
                Console.ReadLine();
                Console.ReadKey(true);
                Console.Clear();
                TypeLine("COMBAT HAS BEEN ENCOUNTERED WITH THE MANNNN");

                Console.WriteLine("===============================================================================================");
                Console.WriteLine("|            Press (A) to attack         &          (D) Defend    ");
                Console.WriteLine("==============================================================================================");

                Console.ReadKey(true);
                Console.Clear();
                Console.WriteLine("===============================================================================================");
                Console.WriteLine("|                   (A)ttack  = 10                               (D)efend = 5             ");
                Console.WriteLine("                          (P)ower = 4                 (H)eals   = 450           ");
                Console.WriteLine("==============================================================================================");
                Console.WriteLine("==============================================================================================");
                Console.WriteLine("The Wise man Has attacked back dealing a total damage of = 50");
              
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
