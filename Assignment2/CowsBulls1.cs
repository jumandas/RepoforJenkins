using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class CowsBulls1
    {
        static string secert;
        static void Main()
        {
            Console.WriteLine("Player 1");
            Console.WriteLine("Enter the secert word");
            secert = Console.ReadLine();
            Console.WriteLine("Player 2");
            Console.WriteLine("You have 5 trys to guess the word");
            string guess;
            int bulls = 0, cows;
            for (int i = 0; i < 5 && bulls != 4; i++)
            {
                bulls = 0; cows = 0;
                Console.WriteLine("Enter the guess word");
                guess = Console.ReadLine();
                foreach (char c in guess)
                {
                    if (secert.Contains(c))
                    {
                        if (guess.IndexOf(c) == secert.IndexOf(c)) bulls++;
                        else cows++;
                    }
                }
                if (bulls != 4) Console.WriteLine("{0} Bulls    {1} Cows", bulls, cows);
            }
            if (bulls == 4) Console.WriteLine("Correct guess");
            else Console.WriteLine("Out of options.");
            Console.WriteLine("The secret word is : {0}", secert);
            Console.ReadKey();
        }
    }
}
