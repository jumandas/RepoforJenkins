using System;

namespace FlowControl
{
    class DivisibleCheck
    {
        static void Main()
        {
            int no1 = Convert.ToInt32(Console.ReadLine());
            int no2 = Convert.ToInt32(Console.ReadLine());
            if (no2 != 0)
            {
                if (no1 < no2)
                {
                    Console.WriteLine("Number not Divisible");
                }
                else
                {
                    float Result = no1 / no2;
                    Console.WriteLine("{0}/{1}={2}", no1, no2, Result);
                }
                Console.ReadKey();
            }
        }
    }
}
