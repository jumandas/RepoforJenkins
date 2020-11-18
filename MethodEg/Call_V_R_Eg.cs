using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodEg
{
    //Call by value and call by reference
    class Call_V_R_Eg
    {
        void ByValue(int value)
        {
            value = 210;
            Console.WriteLine("Inside Call by Value;{0}", value);
        }

        void ByReference(ref int value)
        {
            value = 300;
            Console.WriteLine("Inside Call by Value;{0}", value);
        }

        void Calculation(int value1,int value2,out int add,out int product,out float div)
        {
            add = value1 + value2;
            product = value1 * value2;
            if (value2 > 0)
            {
                div = value1 / value2;
            }
            else
            {
                div = 0;
            }
        }


        static void Main()
        {
            int sum = 0, product = 0;
            float div = 0f;
            int number = 100;
            //Call_V_R_Eg obj=new Call_V_R_Eg();
            //--Annonymous Object
            new Call_V_R_Eg().ByValue(number);
            Console.WriteLine("Number:{0}", number);
            Console.WriteLine("----------------------------");
            new Call_V_R_Eg().ByReference(ref number);
            Console.WriteLine("Number:{0}", number);
            Console.WriteLine("----------------------------");
            new Call_V_R_Eg().Calculation(0,0, out sum, out product,out div);
            if(sum>0 && product>0)
            {
                Console.WriteLine("Sum:{0} && Product:{1} && Div:{2}", sum, product, div);
            }
            else
            {
                Console.WriteLine("Values are not greater than zero!!!");
            }
            Console.Read();


        }
    }
}
