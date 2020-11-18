using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTIday1
{
    class Hello
    {
        static void Main()
        {
             Console.Write("Hello World");
            //Console.Read();
            int value1 = 40, value2 = 60,Result;
            Result = value1 * value2;
            Console.WriteLine("Result is", Result);
            //Using Concatenation
            Console.WriteLine("Result is",+Result);
            //Using Interpolation
            Console.WriteLine("{0} * {1} = {2}",value1,value2,Result);
            Console.ReadKey();


        }
    }
}
