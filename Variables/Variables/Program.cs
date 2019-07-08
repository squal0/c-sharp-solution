using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        /// <summary>
        /// /The following is an XML comment
        /// this is one of the reasons why c# is so cool
        /// one needs to enclose the comments within an XMl tag
        /// The program below is used to show how some one can declare
        /// and initialize variables
        /// variables declared and initialized at the same time using the 
        /// key word var are called implicitly typed variables
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //program simulates the declaring and initializing of variables
            bool boolTest = true;
            short byteTest = 35;
            int intTest;
            string strTest = "Oracion Seis";
            char charTest = 'R';
            float flTest = 23.57884f;
            double dbTest;

            intTest = 32233;
            dbTest = 78.89997442;

            //calculating the area of a circle
            const float pi = 3.142f;
            int radius = 14;
            double area = pi * (Math.Pow(radius, 2));

            string str = "\u0048\u0065\u006C\u006C\u006F";

            string name;
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();

            //display the output
            Console.WriteLine("Bool Test {0}", boolTest);
            Console.WriteLine("Short Test = " + byteTest);
            Console.WriteLine("Int Test = " + intTest);
            Console.WriteLine("String Test {0}", strTest);
            Console.WriteLine("Char Test {0}", charTest);
            Console.WriteLine("Float Test = " + flTest);
            Console.WriteLine("Double Test = " + dbTest);
            Console.WriteLine("The area of the circle is: " + area);
            Console.Write("\t" + str + "!\n");
            Console.WriteLine("Reina\u0020\"2016\"");
            Console.WriteLine("Hello {0}, I hope you are enjoying C#", name);
            Console.Read();
        }
    }
}
