using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjSecond
{
    class JaggedArray
    {
        static void Main()
        {
            int[][] Jagged = new int[2][];

            Jagged[0] = new int[] { 10, 20, 30 };
            Jagged[1] = new int[] { 3, 7, 9, 11 };

            for(int i=0;i<Jagged.Length;i++)
            {
                for(int j=0;j<Jagged[i].Length;j++)
                {
                    Console.Write(Jagged[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
