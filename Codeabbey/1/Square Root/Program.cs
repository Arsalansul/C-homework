using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Root
{
    class Program
    {
        static double[] ToArray(string stroka)
        {
            string[] stroki = stroka.Split(' ');
            double[] numbers = new double[stroki.Length];
            for (int i = 0; i < stroki.Length; i++)
            {
                numbers[i] = Convert.ToInt32(stroki[i]);
            }
            return numbers;
        }

        static void Main(string[] args)
        {
            string stroka = @"22 10
57 12
49 4
27 9
19 8
127 12
70611 6
81062 3
24986 11
716 5";
            string[] stroki = stroka.Split('\n');
            
            for (int i = 0; i < stroki.Length; i++)
            {
                double r = 1;
                double[] numbers = ToArray(stroki[i]);
                for (int j = 0; j < numbers[1]; j++)
                {
                    r = (r + numbers[0] / r) / 2;
                }
                Console.Write(r + " ");
            }
            Console.ReadKey();
        }
    }
}
