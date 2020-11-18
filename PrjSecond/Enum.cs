using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjSecond
{
    class Enum
    {
        enum Feedback { Poor=1,Fair,Good,VeryGood,Excellent}
        static void Main()
        {
            int Poor = Convert.ToInt32(Feedback.Poor);
            Console.WriteLine("Excellent {0}", Feedback.Excellent);
            Console.WriteLine("Excellent {0}",(int)Feedback.Excellent);
            Console.WriteLine("Poor:{0}", Poor);
            Console.Read();
        }
    }
}
