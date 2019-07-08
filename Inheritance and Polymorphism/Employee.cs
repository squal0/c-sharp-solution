using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism
{
    //base class employee 
    class Employee
    {
        protected int empId = 1001;
        protected string empName = "Raymond Kingsley";
        protected int age = 32;

        public void display()
        {
            Console.WriteLine("Employee ID:" + empId);
            Console.WriteLine("Employee Name:" + empName);
            Console.WriteLine("Age: " + age);
        }
    }
}
