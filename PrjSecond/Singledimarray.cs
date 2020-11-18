using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjSecond
{
    class Singledimarray
    {
        static void Main()
        {
            string[] Fruits = new string[5];

            
            for(int i=0;i<Fruits.Length;i++)
            {
                Console.WriteLine("Enter Fruit Name of index {0}", i);
                Fruits[i] = Console.ReadLine();
            }
            Array.Sort(Fruits);
            Console.WriteLine("Sorted Array");
            for(int i=0;i<Fruits.Length;i++)
            {
                Console.WriteLine("Fruits {0}",Fruits[i]);
            }
            Console.Read();
        }
    }
}
