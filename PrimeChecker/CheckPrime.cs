using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class CheckPrime
    {
        private int number;

        public CheckPrime(int number)
        {
            this.number = number;
        }

        public bool is_prime()
        {
            if(this.number < 2)
            {
                return false;
            }
            else if(this.number == 2)
            {
                return true;
            }
            for (int num = 2; num < this.number; num++)
            {
                if(this.number % num == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            CheckPrime prime = new CheckPrime(45);
            Console.Write(prime.is_prime());
            Console.ReadLine();
        }
    }
}
