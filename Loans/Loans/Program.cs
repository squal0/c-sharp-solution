using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loans
{
    class Program
    {
        static void Main(string[] args)
        {
            //program calculates the interest of a loan
            string custName;
            double loanAmt;
            float interest = 0.12F; //real literal
            double interestAmt = 0;
            double totalAmt = 0;

            //ask for input
            Console.Write("Enter the name of the customer:");
            custName = Console.ReadLine();
            Console.Write("Enter the loan amount: ");
            loanAmt = Convert.ToDouble(Console.ReadLine());

            interestAmt = loanAmt * interest;
            totalAmt = loanAmt + interestAmt;

            DateTime dt = DateTime.Now;
            
            //using place holders- similar to printf in java
            Console.WriteLine("\nCustomer Name: {0}", custName);
            Console.WriteLine("Loan Amount: ${0:#,###.#0} \nInterest Rate: {1:0#%} \nInterest Amount: ${2:#,###.#0}", loanAmt, interest, interestAmt);
            Console.WriteLine("Total Amount to be paid is: ${0: #,###.#0}", totalAmt);

            //displaying the date in different formats
            Console.WriteLine("Short date format (d) : {0:d}", dt);
            Console.WriteLine("Long date format (D) : {0:D}", dt);
            Console.WriteLine("Full date short time (f) : {0:f}", dt);
            Console.WriteLine("Full date long time (F) : {0:F}", dt);
            Console.WriteLine("General date format (g) : {0:g}", dt);
            Console.WriteLine("General date/time (G) : {0:G}", dt);
            Console.WriteLine("Month (m) : {0:m}", dt);
            Console.WriteLine("Short time (t) : {0:g}", dt);
            Console.WriteLine("Short time with seconds (T) : {0:T}", dt);
            Console.WriteLine("Year (Y) : {0:Y}", dt);
            Console.ReadLine();
        }
    }
}
