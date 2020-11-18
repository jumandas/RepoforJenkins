using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace LTIday1
{
    class NullExample
    {
        static void Main()
        {
            int? Age = null;
           /* if (Age != null)
            {
                Console.WriteLine("Age is {0}", Age);
            }
            else
            {
                Console.WriteLine("Age is null.Please update your Age!");
            }*/

            //NullCoalescing Operator

            Console.WriteLine("Age is {0}", Age ?? 0);

            String OrgName = null;
            Console.WriteLine("OrgName:{0}", OrgName ?? "No OrgName");
            //When occurs an type conversion error
            Console.WriteLine("OrgName:{0}", (OrgName ?? "No Org Name").ToString());
            Console.WriteLine("--------------------------------");
            int AvailableTickets, TotalTickets = 100;
            int? TicketonSale = 60;
            AvailableTickets = (TotalTickets - TicketonSale) ?? 0;
            Console.WriteLine("AvailableTickets={0}", AvailableTickets);
            Console.WriteLine("AvailableTickets={0}", (TotalTickets - TicketonSale) ??0);
            Console.ReadKey();
        }

    }
}