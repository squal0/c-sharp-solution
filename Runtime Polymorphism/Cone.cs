using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Polymorphism
{
    //derived class that inherits from the class circle
    class Cone:Circle
    {
        protected double side = 8.6;
        //overrides the method in the base class
        public override double Area()
        {
            return PI * radius * side;
        }
    }
}
