using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodEg
{
    class MethodParameters
    {
        string Name;
        int Age;

        void GetUserDetails()
        {
            Console.Write("User Name");
            Name = Console.ReadLine();
            Console.WriteLine("user Age");
            Age = Convert.ToInt32(Console.ReadLine());
        }
        void DisplayUserDetails()
        {
            Console.WriteLine("User Name:{0} && User Age:{1}", Name, Age);
        }

        static void Main()
        {
            MethodParameters methodParameters = new MethodParameters();
            methodParameters.GetUserDetails();
            methodParameters.DisplayUserDetails();
            Console.Read();
        }
    }
}
