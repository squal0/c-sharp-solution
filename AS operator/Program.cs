using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_operator
{
    interface ISet
    {
        void AcceptDetails(int val1, string val2);
    }

    interface IGet
    {
        void display();
    }
    class Program: ISet
    {
        int empID;
        string empName;

        public void AcceptDetails(int val1, string val2)
        {
            empID = val1;
            empName = val2;
        }
        static void Main(string[] args)
        {
            Program employee = new Program();
            employee.AcceptDetails(1002, "Reina Smith");
            IGet objGet = employee as IGet;

            if (objGet != null)
            {
                objGet.display();
            }
            else
            {
                Console.WriteLine("Invalid casting occurred");
            }
            Console.ReadLine();
        }
    }
}
