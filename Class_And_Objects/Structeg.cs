using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Objects
{
    //a structure is a valued type datatype
    //A Structure can have:-
    //Fields
    //Paramterized COnstructor
    //Constants
    //Proeprties
    //Indexers
    //Events
    //Methods etc
    public struct Pen
    {
        public string PenName { get; set; }
        public string Color { get; set; }

        //Need to make a constructor when set is private
       public Pen(string PenName,string Color)
        {
            this.PenName = PenName;
            this.Color = Color;
        }
    }
    class Structeg
    {
        static void Main()
        {
            Pen P1 = new Pen("Parker", "Blue");

            P1.Color = "Red";

            Console.WriteLine("{0}||{1|", P1.PenName, P1.Color);
        }

    }
}
