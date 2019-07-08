using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_construct
{
    class Program
    {
        static void Main(string[] args)
        {
            int yrsOfService = 3;
            double salary = 100000;
            int bonus = 0;

            if(yrsOfService < 5)
            {
                if(salary < 100000)
                {
                    bonus = 15000;
                }
                else
                {
                    bonus = 25000;
                }
            }
            else
            {
                bonus = 35000;
            }
            Console.WriteLine("Bonus Amount: " + bonus);
            Console.ReadLine();
        }
    }
}
