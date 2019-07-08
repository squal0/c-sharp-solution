using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance
{

    interface ITerrestrialAnimal
    {
        void Eat();
    }

    interface IMarineAnimal
    {
        void Swim();
    }
    class Program: ITerrestrialAnimal, IMarineAnimal
    {

        public void Eat()
        {
            Console.WriteLine("The crocodile eats flesh");
        }

        public void Swim()
        {
            Console.WriteLine("The crocodile can swim four tims faster than an Olympic swimmer");
        }
        static void Main(string[] args)
        {

            Program objCroc = new Program();
            objCroc.Eat();
            objCroc.Swim();
            Console.ReadLine();
        }
    }
}
