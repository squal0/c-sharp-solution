using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a single dimensional array using the array class
            Array objAry = Array.CreateInstance(typeof(string), 2, 5);
            objAry.SetValue("EC001", 0, 0);
            objAry.SetValue("MD0011", 0, 1);
            objAry.SetValue("SR005", 0, 2);
            objAry.SetValue("D2013", 0, 3);
            objAry.SetValue("IT001", 0, 4);
            objAry.SetValue("Marketing", 1, 0);
            objAry.SetValue("Accounting", 1, 1);
            objAry.SetValue("Human Resources", 1, 2);
            objAry.SetValue("Business Adminstration", 1, 3);
            objAry.SetValue("Information Technology", 1, 4);

            //displaying the rank of the array using the rank property
            Console.WriteLine("Rank: " + objAry.Rank);
            Console.WriteLine("Department ID\tDepartment Name");

            for(int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(objAry.GetValue(i, j) + "\t\t");
                    Console.WriteLine(objAry.GetValue(i + 1, j));
                }
            }
            Console.ReadLine();
        }
    }
}
