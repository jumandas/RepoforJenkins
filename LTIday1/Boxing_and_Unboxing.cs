using System;

namespace LTIday1
{
    class Boxing_and_Unboxing
    {
        static void Main()
        {
            int Data = 10;
            object o = Data; //boxing

            int j = Convert.ToInt32(o); //unboxing
            int g = (int)o; //unboxing
        }
    }
}
