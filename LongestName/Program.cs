using System;

namespace LongestName
{
    class Program
    {
        static void Main(string[] args)
        {
            /*the program asks for two bames;
             * The programs compares the names by their length;
             * The program displays wich name is the longes.
             * Do not use te Length property!
             * E.g.
             * "Namel is longer than Name2."*/
            Console.WriteLine("Enter the first name: ");
            string nameOne = Console.ReadLine();
            Console.WriteLine("Entr the second name: ");
            string nameTwo = Console.ReadLine();
            int lengthOne = 0;
            int lengthTwo = 0;
            // get the lenght of the name one
            foreach (char letter in nameOne)
            {
                lengthOne = lengthOne + 1;
            }

            foreach (char letter in nameTwo)
            {
                lengthTwo = lengthTwo + 1;
            }

            if (lengthOne > lengthTwo)
            {
                Console.WriteLine("Name One is the longest.");
            }
            else if (lengthOne < lengthTwo)
            {
                Console.WriteLine("Name One is the longest.");
            }
            else
            {
                Console.WriteLine("Both name are of the same lenght.");
            }
        }
    }
}
