using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythagorean_Theorem
{
    class Program
    {
        static double[] ToArray(string str)
        {
            string[] stroki = str.Split(' ');
            double[] array=new double[stroki.Length];
            for (int i = 0; i < stroki.Length; i++)
            {
                array[i] = Convert.ToInt32(stroki[i]);
            }
            return array;
        }

        static void Main(string[] args)
        {
            string stroka = @"136 255 289
264 77 275
135 180 225
492 205 533
32 60 69
475 1140 1277
2016 588 2104
252 105 269
245 588 624
364 1248 1300
183 244 272
656 1230 1290
400 750 928
66 88 106
424 795 876
54 72 92
195 260 353
56 42 70
413 1416 1489
225 540 552
144 192 247
576 168 596
245 840 881
148 111 172
132 55 144
660 275 765
265 636 719";
            string[] stroki = stroka.Split('\n');
            for (int i = 0; i < stroki.Length; i++)
            {
                double[] array = ToArray(stroki[i]);
                double c=Math.Sqrt(array[0]*array[0]+array[1]*array[1]);
                if (array[2] < c)
                    Console.Write("A ");
                else if (array[2] > c)
                    Console.Write("O ");
                else
                    Console.Write("R ");
            }
            Console.ReadKey();
        }
    }
}
