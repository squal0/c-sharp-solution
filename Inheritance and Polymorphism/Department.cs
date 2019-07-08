using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism
{
    //derived class that inherits from the base class employee
    class Department:Employee
    {
        string deptId = "SM001";
        string deptName = "Sales and Marketing";

        //new keyword is used to hide the base class method
        new void display()
        {
            base.display(); //base keyword is used to access the method of the base class
            Console.WriteLine("Department ID:" + deptId);
            Console.WriteLine("Department Name:" + deptName);

        }
    }
}
