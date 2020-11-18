using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjSecond
{
    class Multidim
    {
        static void Main()
        {
            int[,] Table = new int[3, 3];
            int i, j;
            for (i=0;i<3;i++)
            {
                for(j=0;j<3;j++)
                {
                    Table[i, j] = Convert.ToInt32(Console.ReadLine());
                }
      
            }

            for(i=0;i<3;i++)
            {
                for(j=0;j<3;j++)
                {
                    Console.WriteLine("Table[{0},{1}]={2}",i,j,Table[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
