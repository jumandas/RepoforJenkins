using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjSecond
{
    class Stringfunctions
    {
        static void Main()
        {
            Console.WriteLine("Enter ur Name");
            String Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("TO UPPER:{0}", Name.ToUpper());
            Console.WriteLine("TO LOWER:{0}", Name.ToLower());
            Console.WriteLine("Length:{0}", Name.Length);
            bool isContains = Name.Contains("ma");
            Console.WriteLine("Contains:{0}",isContains);
            Console.WriteLine("Substring:{0}", Name.Substring(2, 4));
            Console.Read();
        }
    }
}
