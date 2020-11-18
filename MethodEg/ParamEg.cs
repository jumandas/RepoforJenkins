using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodEg
{
    class ParamEg
    {
        //4 types of method paramters(call by value,reference, out,params)
        //it can be used when we are not aware of the parameters
        //parameter list can have only one params
        //ERROR
        //Void Total(params int[] Marks,int id)
        //void Total(int id,params int[] Marks,int a)
        void Total(string id,params int[] Marks)
        {
            int sum = 0;
            foreach(int m in Marks)
            {
                sum += m;
            }
            Console.WriteLine("Total Marks:{0}", sum);
        }

        void ObjParam(int id,params object[] Student)
        {
            Console.WriteLine(id);
            foreach(object stu in Student)
            {
                Console.WriteLine(stu);
            }
        }

        static void Main()
        {
            String Id = "PS100787";
            //int[] Mark={89,90,78,89};
            //new ParamsEg().Total(Id,Mark);
            new ParamEg().Total(Id, 89, 90, 78, 89);
            new ParamEg().ObjParam(1001, "SAI", "HR", 56000);
            Console.Read();
        }


    }
}
