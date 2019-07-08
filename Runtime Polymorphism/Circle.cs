using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Polymorphism
{
    class Circle
    {
        protected const double PI = 3.142;
        protected double radius = 15.7;

        //method that will be overriden
        public virtual double Area()
        {
            return PI * Math.Pow(radius, 2);
        }
    }
}
