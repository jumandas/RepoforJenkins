using System;

namespace FlowControl
{
    class Foreach
    {
        static void Main()
        {
            String[] Gender = { "male", "female", "Male", "Female", "Male" };

            int male = 0, female = 0;
            foreach(string g in Gender)
            {
                if(g.ToUpper()=="MALE")
                {
                    male++;
                }
                else if(g.ToUpper()=="FEMALE")
                {
                    female++;
                }

            }
            Console.WriteLine("Number of Male is {0}", male);
            Console.WriteLine("Number of Female is {0}", female);
            Console.Read();
        }
    }
}
