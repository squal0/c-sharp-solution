using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarChart_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            int user;
            Console.WriteLine("Please enter a number between 1 and 30: ");
            for(int counter = 1; counter <= 5; counter++)
            {
                user = Console.Read();
                Console.ReadLine();

                if(user > 30)
                {
                    Console.WriteLine("Enter a number between 1 and 30: ");
                }
                for(int starCounter = 1; starCounter <= user; starCounter++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
