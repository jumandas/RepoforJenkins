using System;
using System.CodeDom;
using System.Security.Cryptography.X509Certificates;

namespace Assignment2
{
    class Student
    {
        public int id { get; private set; }
        public String name { get; private set; }
        public DateTime dateofbirth { get; private set; }

        internal Student(int id, string name, DateTime dateofbirth)
        {
            this.id = id;
            this.name = name;
            this.dateofbirth = dateofbirth;
        }
    }

    class Classinfo
    {
        public void display(Student student)
        {
            Console.WriteLine("Student Id:{0}", student.id);
            Console.WriteLine("Student Name:{0}", student.name);
            Console.WriteLine("Student DOB:{0}", (student.dateofbirth).ToShortDateString());
        }

        public void display(Course course)
        {
            Console.WriteLine("Course Id:{0}", course.cid);
            Console.WriteLine("Course Name:{0}", course.name);
            Console.WriteLine("Course Duration:{0}",course.duration);
            Console.WriteLine("Course Fees:{0}", course.fees);
        }

    }

    class Course
    {
        public int cid { get; set; }
        public string name { get; set; }
        public int duration { get; set; }
        public int fees { get; set; }

        internal Course(int cid, string name, int duration,int fees)
        {
            this.cid = cid;
            this.name = name;
            this.duration = duration;
            this.fees = fees;
        }
    }
    class App
    {
        static void Main()
        {
            {
                Console.WriteLine("Enter the no. of Students:");
                int num_of_entries = Convert.ToInt32(Console.ReadLine());
                Student[] details = new Student[num_of_entries];
                int i, id,cid;
                string name,cname;
                DateTime dateofbirth;
                for (i = 0; i < num_of_entries; i++)
                {
                    Console.WriteLine("Enter Student id:");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Student name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Date of Birth");
                    dateofbirth = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter the Course Id");
                    cid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Course Name");
                    cname = Console.ReadLine();
                    Console.WriteLine("")
                    details[i] = new Student(id, name, dateofbirth);

                }
                Classinfo info = new Classinfo();
                foreach (Student std in details)
                {
                    info.display(std);
                }
                Console.ReadKey();
            }
        }
    }
}

