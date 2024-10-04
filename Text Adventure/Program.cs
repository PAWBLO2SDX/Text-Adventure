

namespace Text_Adventure
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            // Type Casting 

            double my8byteNumber = 30.45632;
            Console.WriteLine(my8byteNumber);

            float my4byteNumber = (float)my8byteNumber;
            Console.WriteLine(my4byteNumber);
          
            int my5byteNumber = (int)my8byteNumber;
            Console.WriteLine(my5byteNumber);

            // System.Convert

            float my4ByteNumberAgain = Convert.ToSingle(my8byteNumber);
        
            Console.WriteLine("Welcome To The World Of Paradox!");
            Console.WriteLine("Name:");
            Console.WriteLine("which room would you like to go in?");
            Console.ReadLine();

            string input = Console.ReadLine();
            Console.WriteLine(input);

            if (input == "TWP" || input == "TWP")
            {
                Console.WriteLine("Whatever you choose");

               
            }
        }
    }
}
