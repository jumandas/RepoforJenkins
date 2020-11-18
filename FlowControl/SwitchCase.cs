using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{

    class SwitchCase
    {
        static void Main()
        {
            Console.WriteLine("A.Add user Details");
            Console.WriteLine("B.Update Details");
            Console.WriteLine("C.Exit");
           // Console.WriteLine("D.Quit");
            char cases = Convert.ToChar(Console.ReadLine());
            do
            {
                switch (cases)
                {
                    case 'A':
                        Console.WriteLine("--Adding Details--");
                        Console.WriteLine("Enter the Name");
                        String Name = Console.ReadLine();
                        Console.WriteLine("Enter the Age");
                        int Age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Name);
                        Console.WriteLine(Age);
                        break;
                    case 'B':
                        Console.WriteLine("--Updating Details--");
                        Console.WriteLine("Enter the New Name");
                        String Name1 = Console.ReadLine();
                        Console.WriteLine("Thank you for updating");
                        break;
                    case 'C':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                        
                }
                Console.ReadKey();
            } while (cases != 'C');
        }
    }
}
