using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_References
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] class1 = { "Kyle", "Chloe", "Jidenna" };
            string[] class2 = { "Rachel", "Daniel", "Corine" };

            Console.WriteLine("Students of class I:\tStudents of class II");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(class1[i] + "\t\t\t" + class2[i]);
            }
            class2 = class1;
            Console.WriteLine("\nStudents of class II after referencing class I:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(class2[i] + "");
            }

            Console.WriteLine();
            class2[2] = "Reina";
            Console.WriteLine("Class II after changing the third student in class II:");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(class1[i] + "");
            }
            Console.ReadLine();
        }
    }
}
