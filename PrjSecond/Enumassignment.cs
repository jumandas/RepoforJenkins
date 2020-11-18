using System;
namespace PrjSecond
{
    class Enumassignment
    {
        enum Grade{A,B,C,Failed};
        static void Main()
        {
            Console.WriteLine("Enter the Marks");
            int Marks = Convert.ToInt32(Console.ReadLine());
            if (Marks >=90)
            {
                Console.WriteLine("Student Passed with {0} Grade", Grade.A);
            }
            else if (Marks >=75 && Marks<90)
            {
                Console.WriteLine("Student Passed with {0} Grade", Grade.B);
            }
            else if (Marks>=40 && Marks<75)
            {
                Console.WriteLine("Student Passed with {0} Grade", Grade.C);
            }
            else 
            {
                Console.WriteLine("Student {0}", Grade.Failed);
            }
            Console.ReadKey();
        }
    }
}
