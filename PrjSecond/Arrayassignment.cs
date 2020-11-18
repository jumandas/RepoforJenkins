using System;

namespace PrjSecond
{
    class Arrayassignment
    {
        static void Main()
        {
                int[] Numbers = { 6, 7, 9, 1, 4, 5};
                Console.WriteLine("Enter Number whose Position you want to find");
                int Num = Convert.ToInt32(Console.ReadLine());
                int find= Array.IndexOf(Numbers, Num);
                Console.WriteLine("The Position is {0}", find);
                Console.ReadKey();
        }
    }
}
