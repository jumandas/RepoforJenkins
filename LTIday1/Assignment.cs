using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTIday1
{
    class Assignment
    {
        static void Main()
        {
            Console.WriteLine("Enter Student Name");
            String Name = Console.ReadLine();
            Console.WriteLine("Enter Student Marks");
            int Marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Standard");
            String Standard = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Student Name is {0}", Name);
            Console.WriteLine("Student Marks is {0}", Marks);
            Console.WriteLine("Student Standard is {0}", Standard);
            Console.ReadKey();
        }
    }
}
