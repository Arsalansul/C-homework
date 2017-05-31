using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_and_time_difference
{
    class Program
    {
        static void dif(string stroka)
        {
            string[] stroki = stroka.Split(' ');
            int s1 = 0;
            for (int i = 1; i < 4; i++)
                s1 += Convert.ToInt32(stroki[i]) * (int)Math.Pow(60,3-i);
            s1 += Convert.ToInt32(stroki[0]) * (int)Math.Pow(60, 2) * 24;
            int s2 = 0;
            for (int i = 5; i < 8; i++)
                s2 += Convert.ToInt32(stroki[i]) * (int)Math.Pow(60, 7 - i);
            s2 += Convert.ToInt32(stroki[4]) * (int)Math.Pow(60, 2) * 24;
            s2 -= s1;

            Console.Write("(" + s2 / ((int)Math.Pow(60, 2)*24)+" ");
            s2 = s2 % ((int)Math.Pow(60, 2) * 24);
            for (int i = 1; i < 4; i++)
            {
                Console.Write(s2 / (int)Math.Pow(60, 3 - i));
                if (i != 3)
                    Console.Write(" ");
                s2 = s2 % (int)Math.Pow(60, 3 - i);
            }
            Console.Write(")");

        }
        static void Main(string[] args)
        {
            int n = 15;
            string stroka = @"23 1 25 58 29 9 57 30
24 4 54 47 28 21 25 49
27 9 15 7 27 16 45 52
4 0 2 35 11 17 54 7
2 4 28 28 16 9 36 2
19 15 53 48 20 9 2 50
14 10 43 42 16 2 32 39
10 23 11 45 26 23 49 12
4 15 43 30 15 5 52 23
4 10 57 20 26 1 5 25
10 11 41 38 10 15 12 46
24 19 18 0 25 17 28 31
15 4 9 55 15 18 22 37
1 21 13 21 22 2 57 19";
            string[] stroki = stroka.Split('\n');
            foreach (string el in stroki)
            {
                dif(el);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
