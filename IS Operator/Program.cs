using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Operator
{
    interface ICalculate
    {
        double area();
    }
    class Program: ICalculate
    {
        float length;
        float breadth;

        public Program(float valOne, float valTwo)
        {
            length = valOne;
            breadth = valTwo;
        }

        public double area()
        {
            return length * breadth;
        }
        static void Main(string[] args)
        {
            Program rectangle = new Program(23.64F, 45.78F);
            if(rectangle is ICalculate)
            {
                Console.WriteLine("Area of the Rectangle: {0:F2}", rectangle.area());
             
            }
            else
            {
                Console.WriteLine("The interface method has not been implemented");
            }
            Console.ReadLine();
        }
    }
}
