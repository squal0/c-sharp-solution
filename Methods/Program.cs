using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        string bookName;

        //method that returns a value
        public string print()
        {
            return bookName;
        }

        //method that does not return a value
        public void input(string bkName)
        {
            bookName = bkName;
        }

        void printName(string fName, string lName)
        {
            Console.WriteLine("First Name: {0}, Last Name: {1}", fName, lName);
        }

        void printMsg(string msg ="Kill the Noise")
        {
            Console.WriteLine("{0}", msg);
        }
        static void Main(string[] args)
        {
            Program book = new Program();
            book.input("C# - The complete guide to C# programming");
            Console.WriteLine(book.print());

            Program names = new Program();
            //passing the arguments by position
            names.printName("Reina", "Smith");
            //passing named arguments
            //notice that position does not matter when it comes to named arguments
            names.printName(fName: "Rayson", lName: "Allie");
            names.printName(lName: "Mayfair", fName: "Benson");

            //using optional arguments in a method
            Program msg = new Program();
            msg.printMsg("Kill the noise and bury the heathens");
            msg.printMsg();
            Console.ReadLine();
        }
    }
}
