using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Polymorphism
{
    class Results
    {
        
        static void Main(string[] args)
        {
            Circle objCirc = new Circle();
            Console.WriteLine("Area of the Circle:" + objCirc.Area());
            Circle objCone = new Circle();
            Console.WriteLine("Area of the Cone:" + objCone.Area());
            Console.ReadLine();
        }
    }
}
