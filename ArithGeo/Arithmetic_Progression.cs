using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithGeo
{
    class Arithmetic_Progression
    {
        static void Main(string[] args)
        {
            //program takes a number array and checks to see
            //if the array is an arithmetic progression or a geometric progression
            int[] numSeq = new int[] { 2, 4, 6, 8, 10, 45 };
            Console.Write(arith_geo(numSeq));
            Console.ReadLine();
        }
        public static string arith_geo( int [] numarray)
        {
            if(numarray.Length == 0)
            {
                return null;
            }
            double diff = numarray[1] - numarray[0];

            bool aSeq = true;
            bool gSeq = true;
            int index = 2;

            while ( index < numarray.Length - 1)
            {
                if(numarray[index + 1] - numarray[index] != diff){
                    aSeq = false;
                }
                index += 1;
            }
            for (int i = 0; i < numarray.Length - 2; i++)
            {
                if(numarray[i] * numarray[i + 2] != (numarray[i + 1] ^ 2))
                {
                    gSeq = false;
                }
            }
            for ( int i = 0; i < numarray.Length - 2; i++)
            {
                if(numarray[i] * numarray[i + 2] != (numarray[i + 1] ^ 2 ))
                {
                    gSeq = false;
                }
            }
            for (int i = 0; i < numarray.Length - 1; i++)
            {
                if( numarray[i] == 0 && numarray[i + 1] != 0)
                {
                    gSeq = false;
                }
            }
            if (aSeq == true)
            {
                return "Arithmetic";
            }
            else if (gSeq == true)
            {
                return "Geometric";
            }
            else
            {
                return "-1";
            }
        }
    }
}
