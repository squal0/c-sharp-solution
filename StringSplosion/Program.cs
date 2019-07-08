using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSplosion
{
    class Program
    {
        private string text;

        public Program(string text)
        {
            this.text = text;
        }

        public string manipulate()
        {
            StringBuilder word = new StringBuilder();
            for (int s = 0; s <= this.text.Length; s++)
            {
                string s1 = this.text.Substring(0, s);
                word.Append(s1);
            }
            return word.ToString();
        }
        static void Main(string[] args)
        {
            Program splosion = new Program("bastille");
            Console.WriteLine(splosion.manipulate());
            Console.ReadLine();
        }
    }
}
