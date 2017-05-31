﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using SuperF;

namespace Array_Counters
{

    class Program
    {
        static void Main(string[] args)
        {
            int m = 397;
            int n = 15;
            //string stroka = "1 2 3 2 3 1 1 1 1 3";
            string stroka = "9 1 3 7 13 7 5 15 7 6 11 8 6 10 12 7 3 3 10 13 9 3 13 7 7 10 8 8 2 8 3 11 8 6 3 6 13 7 5 5 12 15 12 3 10 9 9 12 11 3 10 5 6 7 12 13 2 4 5 4 11 8 14 4 13 1 9 10 8 14 15 4 13 11 6 8 5 14 5 1 2 14 6 7 6 2 4 7 6 9 10 2 1 9 5 14 10 14 9 2 12 8 6 10 4 11 2 8 10 6 9 12 5 14 4 10 1 8 1 6 1 11 7 2 4 12 15 13 10 9 15 7 1 5 1 4 1 3 12 10 9 6 7 13 4 10 7 4 2 8 10 3 4 1 4 7 13 4 5 8 12 4 14 12 8 15 1 8 2 13 3 10 3 10 7 7 4 14 11 6 7 5 8 10 6 12 2 3 15 7 10 11 11 9 8 3 8 9 11 9 6 14 3 9 9 10 15 13 9 11 3 15 15 11 10 6 8 12 8 7 4 3 3 14 11 11 2 3 5 12 12 10 11 15 4 4 9 4 1 2 14 4 2 13 15 12 3 7 9 11 14 12 14 2 10 9 13 11 12 2 8 9 12 4 8 15 8 2 3 9 4 1 12 5 14 12 2 2 4 10 13 3 6 11 4 1 5 2 11 2 3 4 11 15 7 3 14 14 4 2 7 8 3 4 12 2 15 14 4 3 8 1 5 14 12 9 14 2 11 10 4 14 13 14 13 5 1 12 3 5 13 9 12 1 12 9 2 12 7 5 15 15 6 5 13 2 14 12 3 9 6 6 7 4 5 5 8 6 1 11 11 14 4 7 14 1 1 15 12 8 5 12 7 10 1 5 12 14 1 15 8 7 6 14 11 10 3 4 15 4 14 10 2 2 2 15 3";
            string[] stroki = stroka.Split(' ');
            int[] array = new int[stroki.Length];
            for (int i = 0; i < stroki.Length;i++)
            {
                array[i] = Convert.ToInt32(stroki[i]);             
            }
            int[] Counters = new int[n];
            foreach (int el in array)
            {
                for (int i = 0; i < n; i++)
                {
                    if (el == (i + 1))
                    {
                        Counters[i]++;
                    }
                }
            }
            for (int i = 0; i < n; i++)
                Console.Write(Counters[i]+" ");
            Console.ReadKey();            
        }
    }
}
