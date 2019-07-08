using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Inheritance
{
    class Metals
    {
        string metalType;
        public Metals(string type)
        {
            metalType = type;
            Console.WriteLine("Metal: \t\t" + metalType);
        }
    }
    class SteelCompany : Metals
    {
        string grade;
        //parameterized base constructor
        public SteelCompany(string grd) : base("Aluminium")
        {
            grade = grd;
            Console.WriteLine("Grade: \t\t" + grade);
        }
    }

    class Automobiles : SteelCompany
    {
        string part;
        public Automobiles(string prt): base("Cast Aluminium")
        {
            part = prt;
            Console.WriteLine("Part: \t\t" + part);
        }


        static void Main(string[] args)
        {
            Automobiles flight = new Automobiles("Engines");
            Console.ReadLine();

        }
    }
}
