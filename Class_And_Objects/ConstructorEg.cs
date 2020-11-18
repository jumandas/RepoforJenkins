using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Objects
{
    class Department
    {
        // static String Orgname="LTI";
        internal static String Orgname;
        int Did;
        string Dname, Location;

        internal Department()
        {
            Console.WriteLine("This is a default Constructor");
        }


      /*  internal Department(string Orgname)
        {
            this.Orgname = Orgname;
        }*/

        internal Department(int id,string name,string Location)
        {
            Did = id;
            Dname = name;
            this.Location = Location; //this current instance
        }
        internal void DisplayDeptDetails()
        {
            //onsole.WriteLine("Orgname:{0}", Orgname);
            Console.WriteLine("ID:{0}||Name:{1}||Location:{2}||OrgName:{3}",Did,Dname,Location,Orgname);
        }

        internal void DisplayOrgDetails()
        {
            Console.WriteLine("Orgname:{0}", Orgname);
        }

    }
    class ConstructorEg
    {
        static void Main()
        {
          /*  new Department();
            new Department("LTI").DisplayOrgDetails();
            Department department=new Department(1001, "HR", "Chennai");
            department.DisplayDeptDetails();
            Console.Read();*/
        }
    }
}
