using System;


namespace LTIday1
{
    class PersonalDetails
    {
        static void Main()
        {
            Console.WriteLine("Enter your Name");
            String Name = Console.ReadLine();
            Console.WriteLine("My Name is {0}", Name);
            //Breakpoint(Red Dot)
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Enter your Age");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Age is {0}", Age);
            //Breakpoint(Red Dot)
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Enter your Experience");
            int Experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Number of Experience is {0}", Experience);
            Console.ReadKey();
        }
    }
}
