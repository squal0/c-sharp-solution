﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            string[] [] companies = new string[3] [];
            companies[0] = new string[] { "Intel", "AMD" };
            companies[1] = new string[] { "Oracle", "Microsoft", "IBM" };
            companies[2] = new string[] { "Dell", "HP", "Lenovo", "Toshiba" };

            for (int i = 0; i < companies.GetLength(0); i++)
            {
                Console.WriteLine("List of companies in group" + (i + 1) + ":\t");
                for (int j = 0; j < companies[i].GetLength(0); j++)
                {
                    Console.Write(companies[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
