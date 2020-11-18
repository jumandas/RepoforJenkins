using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Objects
{
    class ClientDept
    {
        static void Main()
        {
            Console.WriteLine("Enter Company Name");
            Department.Orgname = Console.ReadLine();
            new Department();
            //new Department("LTI").DisplayOrgDetails();
            Department department = new Department(1001, "HR", "Chennai");
            //Single Department
            department.DisplayDeptDetails();
            //Multiple Departments
            //Array of Objects
           // Department[] deptarray = new Department[3];
           /* deptarray[0] = new Department(101, "Sales", "Pune");
            deptarray[1] = new Department(102, "Finance", "Pune");
            deptarray[2] = new Department(103, "HR", "Chennai");*/
            Console.WriteLine("Enter the no. of entries:");
            int num_of_entries = Convert.ToInt32(Console.ReadLine());
            Department[] dptarray = new Department[num_of_entries];
            int i, id;
            string name, loc;
            for (i = 0; i < num_of_entries; i++)
            {
                Console.WriteLine("Enter Department id:");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Department name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter location of Department:");
                loc = Console.ReadLine();
                dptarray[i] = new Department(id, name, loc);
            }
            foreach (Department d in dptarray) d.DisplayDeptDetails();
            Console.ReadKey();
            /*foreach (Department d in dptarray)
            {
                d.DisplayDeptDetails();
            }

            Console.Read();*/
        }
    }
}
