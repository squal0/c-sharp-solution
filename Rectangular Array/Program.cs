using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangular_Array
{
    class Program
    {

        void studentDetails()
        {
            Console.WriteLine("Enter the number of students:");
            int noOfStuds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of exams:");
            int exams = Convert.ToInt32(Console.ReadLine());
            string[] stdNames = new string[noOfStuds];
            string[,] details = new string[noOfStuds, exams];
            for (int i = 0; i < noOfStuds; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the Student name:");
                stdNames[i] = Convert.ToString(Console.ReadLine());
                for(int y = 0; y < exams; y++)
                {
                    Console.Write("Enter the score in Exam: " + (y + 1) + ":");
                    details[i, y] = Convert.ToString(Console.ReadLine());
                }

            }
            Console.WriteLine();
            Console.WriteLine("Student Exam Details");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("Student\t\tMarks");
            Console.WriteLine("----------\t-------------");
            for(int i = 0; i < stdNames.Length; i++)
            {
                Console.WriteLine(stdNames[i]);
                for(int j = 0; j < exams; j++)
                {
                    Console.WriteLine("\t\t" + details[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

            /* following code allows the user to specify the number of students
            their names, the number of exams and the marks scored by each student.
            Simply put it simulates a gradebook
            */
            Program studentScore = new Program();
            studentScore.studentDetails();
            Console.ReadLine();
        }
    }
}
