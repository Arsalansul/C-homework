using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor
{
    class Program
    {
        static int[] ToArray(string stroka)
        {
            string[] stroki = stroka.Split(' ');
            int[] numbers = new int[stroki.Length];
            for (int i = 0; i < stroki.Length; i++)
            {
                numbers[i] = Convert.ToInt32(stroki[i]);                
            }
            return numbers;
        }
        static int GCD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        static void Main(string[] args)
        {
            int n = 17;
            string stroka = @"1 3781
704 209
653 4828
87 77
6300 3024
2070 2835
4284 4896
625 3
7304 4928
17 829
803 462
9509 3220
1875 1775
1386 3990
5490 3330
2112 8008
3040 5605";
            string[] stroki = stroka.Split('\n');

            for (int i = 0; i < n; i++)
            {
                int[] numbers = ToArray(stroki[i]);
                Console.Write("(" + GCD(numbers[0], numbers[1]) + " " + LCM(numbers[0], numbers[1]) + ") ");
            }
            Console.ReadKey();
            

        }
    }
}
