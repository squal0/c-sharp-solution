using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_construct
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result = 0;
            Console.WriteLine("(1) Addition");
            Console.WriteLine("(2) Subtraction");
            Console.WriteLine("(3) Multiplication");
            Console.WriteLine("(4) Division");
            

            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value one");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value two");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    Console.WriteLine("Do you want to calculate the quotient or the remainder?");
                    Console.WriteLine("(1) Quotient");
                    Console.WriteLine("(2) Remainder");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            result = num1 / num2;
                            break;
                        case 2:
                            result = num1 % num2;
                            break;
                        default:
                            Console.WriteLine("Incorrect choice! - Enter 1 or 2");
                            break; 
                    }
                    break;
                default:
                    Console.WriteLine("Incorrect choice - Enter a number between 1 - 4");
                    break;
            }
            Console.WriteLine("Result = " + result);
            Console.ReadLine();
        }
    }
}
