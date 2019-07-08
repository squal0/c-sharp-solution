using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "radar";
            Console.WriteLine(reverseString(str));
            Console.ReadLine();
        }

        public static string reverseString(string str)
        {
            string r_str = new string(str.Reverse().ToArray());

            if(str.Length == 0)
            {
                return null;
            }
            else if (r_str.Equals(str))
            {
                return true.ToString();
            }
            else
            {
                return r_str;
            }
        }
    }
}
