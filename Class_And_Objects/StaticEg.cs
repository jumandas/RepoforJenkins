using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Objects
{
    class Student
    {
        internal static string CollegeName;
        int id = 100;
        //Non-static method can access static variable
        internal void DisplayCollegeDetails()
        {
            Console.WriteLine("CollegeName:{0}", CollegeName);
        }

        internal static void Display()
        {
            //cant access non static variable in static method
            //Console.WriteLine("CollegeID:{0}",id);
            Console.WriteLine("CollegeName:{0}", CollegeName);
        }
    }

    class StaticEg
    {
        static string phno;
        internal static void Displayphno()
        {
            Console.WriteLine("CollegeName:{0}", phno);
        }

        static void Main()
        {
            phno = "2324232323";
            Console.WriteLine("Enter your College Name");
            Student.CollegeName = Console.ReadLine();
            Student student = new Student();
            student.DisplayCollegeDetails();
            //Calling the static Method of student class
            Student.Display();
            //calling static function from staticEg class
            Displayphno();
            Console.Read();
        }
    }
}
