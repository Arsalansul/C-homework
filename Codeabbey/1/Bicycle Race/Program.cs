using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle_Race
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
            string stroka = @"24 30 23
30 15 20
29 15 11
24 28 17
15 21 24
13 20 23
14 12 28
20 22 13
23 27 23
51 12 12
193 14 20
13 27 23
192 17 29
432 21 12
14 10 18
317 21 12
18 25 12
56 15 18
20 28 24
95 16 18
14 17 29
59 11 20
16 28 19
122 22 27
174 30 16
11 24 17
155 11 14";
            string[] stroki = stroka.Split('\n');
            for (int i = 0; i < stroki.Length; i++)
            {
                double[] array = ToArray(stroki[i]);
                double s1 = array[1] * array[0] / (array[1] + array[2]);
                Console.Write(s1 + " ");
            }
            Console.ReadKey();
        }
    }
}
