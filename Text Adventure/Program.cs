using Microsoft.VisualBasic;

namespace Text_Adventure
{
    internal class Program
    {
        public static Player currentPlayer = new Player();
        static void Main(string[] args)

        {
            static void TypeLine(string line)
            {
                string output = null;
                char[] characters = line.ToCharArray();
                for (int i = 0; i < characters.Length; i++)
                {
                    output += characters[i];
                    Console.Clear();
                }

              
                Console.WriteLine(output);
            }
            Console.WriteLine("The World Of Paradox!");
           Console.WriteLine("Name:");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You awake in the Cold!,Stone, dark room. You feel dazed and are having a trouble time remembering where you are From The Past events");
             Console.WriteLine("which room would you like to go in?!!!!!");
            if(currentPlayer.name == "")
            Console.WriteLine("You can't even remember your own name . . . .");
           else Console.WriteLine("You Know your name is" + currentPlayer.name);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You Move around the darkness of the room and have reached to what appears to be a handle of some sort.");
            Console.WriteLine("YOU MAY TURN IT BUT SOMETHING MIGHT HAPPEN, WHO KNOWSSS??? PRESS (ENTER) TO HOP IN");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("======================================================================================================");
            Console.WriteLine("|                                      You have Now                                                   |");
            Console.WriteLine("|                                        Entered                                                      |");
            Console.WriteLine("|                                    BIG FRIENDLY ROOM                                                |");
            Console.WriteLine("======================================================================================================");

            Console.WriteLine(" +\r\n                \"You have Encountered a Man who Goes by the name of The Wise One. \");");
            string input = Console.ReadLine();
            Console.WriteLine(input);

            if (input == "TWP" || input == "TWP")
            {
                Console.WriteLine("Whatever you choose");

               
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
           Console.WriteLine("Your THROW OPEN THE DOOOR!! you grab a  rusty shield That appears infront of you, while charging at the man who captured you");
            Console.WriteLine("He Turns...");
            Console.ReadLine();
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
                Console.WriteLine("|     (R)un      (H)eals |");
                Console.WriteLine("==========================");
                Console.WriteLine("Shields: " + Program.currentPlayer.shields);
            }
        }
    }
}
