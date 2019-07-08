using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        
        /// <summary>
        /// The following program demonstrates the use of XML comments
        /// Employee class uses constructors to to initialize the ID and
        /// name of an employee and then displays them
        /// 
        /// </summary>
        /// <remarks>
        /// This program uses both parameterized and non-parameterized
        /// constructors
        /// </remarks>
        /// <param name="args"></param>
        /// <summary>
        /// Integer field to store employee ID
        /// </summary>
        private int id;

        /// <summary>
        /// String field to store the employee name
        /// </summary>
        private string name;
        /// <param name="args"></param>
        /// <summary>
        /// construtor initializes id to -1 and name to null
        /// </summary>
        /// <remarks>
        /// <seealso cref="XmlDocs(int, string)"> XmlDocs(string, int)</seealso>
        /// </remarks>
        public Program()
        {
            name = null;
            id = -1;
        }
        /// <summary>
        /// This constructor initializes the id and the name
        /// (<paramref name="name"/>, <paramref id="id"/>).
        /// </summary>
        /// <param name="id">Employee ID</param>
        /// <param name="name">Employee Name</param>
        /// <param name="args"></param>
        public Program(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        /// <summary>
        /// The entry point for the application.
        /// <param name="args">A list of command line arguments</param>
        /// </summary>
        /// <param name="args"></param>

            static void Main(string [] args) { 

        //creating an object of the XmlDocs class 
        //and displaying the name and id of the employee
        Program employee = new Program(240, "Reina Smith");
        Console.WriteLine("Employee ID: {0} \nEmployee Name: {1}", employee.id, employee.name);
            Console.Read();
        
    }
}

    }
