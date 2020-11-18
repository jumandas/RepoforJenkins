using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Objects
{
    class Mobile
    {
        //Read-Only Property
        public string MobileName { get; private set; }
        // public int Cost { get; set; }
        //Old way of get set property
        private int Cost;
        public int _Cost
        {
            get
            {
                return Cost;
            }
            set
            {
                Cost = value;
            }
        }

        public Mobile(string MobileName)
        {
            this.MobileName = MobileName;
        }

        internal void DisplayMobileDetails()
        {
            Console.WriteLine("{0}", MobileName);
        }
    }

    class MobileInfo
    {
        public string Modelno { get; set; }
        public MobileInfo(string Modelno)
        {
            this.Modelno = Modelno;
        }
        internal void DisplayMobileInfo()
        {
            Console.WriteLine("{0}", Modelno);
        }

    }
    class PropertyEg
    {
        static void Main()
        {
            Mobile mobile = new Mobile("OnePlus");
            MobileInfo info = new MobileInfo("SR100");
            mobile.DisplayMobileDetails();
            info.DisplayMobileInfo();
            Console.Read();

        }
    }
}
