﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[9];

            for (int i = 0; i <= 8; i++)
            {
                Console.Write("Informe o {0}º valor => ", i + 1);
                num[i] = double.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i <= 8; i++)
            {
                Console.WriteLine("Valor com índice {0} => {1}", i,num[i]);
            }
            Console.ReadKey();
        }
    }
}
