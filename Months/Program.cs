using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter a Month:");
            input = Console.ReadLine().ToUpper();

            switch (input)
            {
                case "JANUARY":
                case "MARCH":
                case "MAY":
                case "JULY":
                case "AUGUST":
                case "OCTOBER":
                case "DECEMBER":
                    Console.WriteLine("This Month has 31 days");
                    break;
                case "SEPTEMBER":
                case "APRIL":
                case "JUNE":
                case "NOVEMBER":
                    Console.WriteLine("This Month has 30 days");
                    break;
                case "FEBRUARY":
                    Console.WriteLine("This month has 28 days in a non-leap and 29 days in a leap year");
                    break;
                default:
                    Console.WriteLine("Incorrect Month - Please enter one of the 12 Months");
                    break;
            }
            Console.ReadLine();
        }
    }
}
