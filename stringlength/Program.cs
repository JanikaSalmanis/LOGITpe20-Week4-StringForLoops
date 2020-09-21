using System;

namespace stringlength
{
    class Program
    {
        static void Main(string[] args)
        {
            /* the progrm asks the user´sname
             and displays the length of the name
            without using thelength property*/
            Console.WriteLine("Enter your name: ");
            string userInput = Console.ReadLine();
            int counter = 0;

            foreach(char letter in userInput)
                {
                  Console.WriteLine(letter);
                counter = counter +1;
                Console.WriteLine($"letter {letter} is at {counter}");
                }
            Console.WriteLine($"Your name is {counter} characters long.");
        }
    }
}
