using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savings_Calculator
{
    class Program
    {
        static double[] ToArray(string str)
        {
            string[] stroki = str.Split(' ');
            double[] array = new double[stroki.Length];
            for (int i = 0; i < stroki.Length; i++)
            {
                array[i] = Convert.ToInt32(stroki[i]);
            }
            return array;
        }
        static void Main(string[] args)
        {
            string stroka = @"25 125 10
1000 15000 40
100 900 45
50 350 45
500 10000 6
2500 10000 35
2500 35000 20
100 700 25
250 4750 5
10000 60000 10
10000 60000 8
50 1000 30
5000 60000 3
50 250 7
250 4500 1";
            string[] stroki = stroka.Split('\n');
            for (int i = 0; i < stroki.Length; i++)
            {
                double[] array = ToArray(stroki[i]);
                double s = array[0];
                double p = array[2]/100;
                int year = 0;
                while (s < array[1])
                {
                    s = s * (1 + p);
                    year++;
                }
                Console.Write(year + " ");
            }
            Console.ReadKey();
        }
    }
}
