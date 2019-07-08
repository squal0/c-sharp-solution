using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance
{
    interface TAnimal
    {
        string Eat();
    }
    interface IMarine
    {
        string Eat();
    }
    class Crocodile : TAnimal, IMarine
    {
        string TAnimal.Eat()
        {
            string croc = "Crocodile eats other animals";
            return croc;
        }

        string IMarine.Eat()
        {
            string marCroc = "Crocodile eats fish and marine animals";
            return marCroc;
        }

        public string EatTerrestrial()
        {
            TAnimal objAnimal;
            objAnimal = this;
            return objAnimal.Eat();
        }

        public string EatMarine()
        {
            IMarine objMarine;
            objMarine = this;
            return objMarine.Eat();
        }
        public static void Main(string[] args)
        {
            Crocodile objCrocs = new Crocodile();
            string terCroc = objCrocs.EatTerrestrial();
            Console.WriteLine(terCroc);
            string marCroc = objCrocs.EatMarine();
            Console.WriteLine(marCroc);
            Console.ReadLine();

        }
    }


}
