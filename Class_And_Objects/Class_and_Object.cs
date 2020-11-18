using System;

namespace Class_And_Objects
{
    class Class_and_Object
    {
            String OrgName;
            int orgID;

            void DisplayDetails()
            {
                Console.WriteLine(OrgName + " " + orgID);
            }

            static void Main()
        {
            Class_and_Object pobj = new Class_and_Object();
            pobj.orgID = 1001;
            pobj.OrgName = "LTI";
            pobj.DisplayDetails();
            Class_and_Object pobj2 = new Class_and_Object();
            pobj2.OrgName = "RENOLD";
            pobj2.DisplayDetails();
            Console.Read();
        }
        }
    }
