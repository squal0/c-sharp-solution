using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleD_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //simulating a single dimensional array
            string[] studentNames = new string[6] { "Jason", "Reina", "Squalo", "John", "Mike", "Eichiro" };
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine(studentNames[i]);
            }
            Console.WriteLine();
            //following code displays the days of the week
            //uses the for each loop
            string[] days = new string[7];
            days[0] = "Sunday";
            days[1] = "Monday";
            days[2] = "Tuesday";
            days[3] = "Wednesday";
            days[4] = "Thursday";
            days[5] = "Friday";
            days[6] = "Saturday";

            foreach( string day in days)
            {
                Console.WriteLine(day);
            };
            Console.ReadLine();

        }
    }
}
