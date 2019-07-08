using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_constructs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            Console.WriteLine("Even Numbers between 1 - 100");
            while (num1 <= 100)
            {
               if(num1 % 2 == 0)
                {
                    Console.WriteLine("Even Numbers are: " + num1);
                }
                num1++;
            }

            //for loop with multiple control variables
            Console.WriteLine("Square\t\tCube");
            for(int i = 1, j = 0; j < 11; i++, j++)
            {
                if(i % 2 == 0)
                {
                    Console.Write("{0} = {1}\t", i, (i * i));
                    Console.Write("\t{0} = {1}\n", j, (j * j * j));
                }
            }

            //factorial of a number done within the body of a for loop
            long fact = 1;
            int num, a;
            Console.WriteLine("Enter the number whose factorial you wish to calculate ");
            num = Convert.ToInt32(Console.ReadLine());
            for (a = 1; a <= num; fact *= a++) ;
            Console.WriteLine("Factorial: " + fact);
            Console.ReadLine();

        }
    }
}
