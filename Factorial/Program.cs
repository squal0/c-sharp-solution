using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(20));
            Console.ReadLine();
        }

        public static long factorial(int number)
        {
            if(number  == 0)
            {
                return 1;
            }
            else
            {
                long fact = 1;
                for (int i = 1; i <= number; i++)
                {
                    fact *= i;
                }
                return fact;
            }
        }
    }
}
