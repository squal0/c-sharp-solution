using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements_and_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a class with a checked statement
            //the statement throws an overflow exception
            byte numOne = 255;
            byte numTwo = 1;
            byte result = 0;

            try
            {
                //the following code throws an overflow exception
                //unchecked - ignores the overflow produced by the program and gives unexpected results
                checked {
                    result = (byte)(numOne + numTwo);
                }
                Console.WriteLine("Results:" + result);
            } catch(OverflowException ex)
            {
                Console.WriteLine(ex);
            }


            //Arithmetic operators
            int value1 = 35;
            int value2 = 83;

            int add = value1 + value2;
            int sub = value2 - value1;
            int mul = value1 * value2;
            int div = value2 / value1;
            int mod = value2 % value1;

            //display the results
            Console.WriteLine("Addition: " + add);
            Console.WriteLine("Subtraction: " + sub);
            Console.WriteLine("Multiplication: " + mul);
            Console.WriteLine("Division: " + div);
            Console.WriteLine("Modulus: " + mod);

            //relational operators
            int rVal = 2440;
            int lVal = 3585;

            Console.WriteLine("Equal:" + (rVal == lVal));
            Console.WriteLine("Not Equal:" + (rVal != lVal));
            Console.WriteLine("Greater:" + (rVal > lVal));
            Console.WriteLine("Lesser:" + (rVal < lVal));
            Console.WriteLine("Greater or Equal:" + (rVal >= lVal));
            Console.WriteLine("Lesser or Equal:" + (rVal <= lVal));

            //logical operators
            int quantity;
            float price;

            Console.WriteLine("Please enter the quantity of items bought ->");
            quantity = Console.Read();
            Console.ReadLine();
            Console.WriteLine("Please enter the price of the items bought ->");
            price = Console.Read();
            Console.ReadLine();

            if ((quantity == 650) & (price == 25))
            {
                Console.WriteLine("The goods are correctly priced");
                Console.ReadLine();
            }
            else if((quantity == 650) | (price == 30))
            {
                Console.WriteLine("The item price can be greatly reduced, consult Customer care");
                Console.ReadLine();
            }
            else if((quantity == 650 ) ^ (price == 15))
            {
                Console.WriteLine("The items are wrongly priced, we've sent a team");
                Console.ReadLine();
            }


            Console.ReadLine();

        }
    }
}
