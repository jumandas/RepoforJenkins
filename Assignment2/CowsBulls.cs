using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class CowsBulls
    {
        static void Main()
        {
            int cows = 0;
            int bulls = 0;
            int i,j;
            Console.WriteLine("Player 1:Enter ur Word");
            string word = Console.ReadLine();
            //char[] chararray = word.ToCharArray();
            Console.WriteLine("Player 2:Enter ur Character");
            string word2 = Console.ReadLine();
            Char[] car = word.ToCharArray();
            Char[] car1 = word2.ToCharArray();
            for (i = 0; i < car.Length; i++)
             {
            for(j=0;j<car1.Length;j++)
             { 
             if (car1[j] == car[i])
             {
                  bulls++;
             }
             else
             {
                  cows++;
             }
            }
            }
            Console.WriteLine("Cows Count:{0}", cows);
            Console.WriteLine("Bulls Count:{0}", bulls);
            Console.ReadLine();
            
        }
    }
}
