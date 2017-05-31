using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_of_an_array
{
    class Program
    {
        static double Round(double a)
        {
            a += 0.5;
            return (int)a;
        }
        static double avg(string[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += Convert.ToInt32(array[i]);
            }
            
            return Round(sum / (double)array.Length);
        }

        static void Main(string[] args)
        {
            int n = 14;
            string stroka = @"75 179 465 319 428 0
14391 16221 8608 11350 6401 12573 2067 5294 14826 0
2330 7247 6483 5290 5874 3003 5884 7550 550 0
847 8056 7761 3710 7298 4663 2360 2540 3649 1364 2458 7953 7038 0
8072 113 5268 3275 6381 7597 2330 4671 4694 12 7674 2386 0
21 186 28 16 173 144 244 62 218 68 176 4 144 169 224 0
880 274 40 265 47 990 556 0
1115 1132 1700 957 1140 1861 394 1359 1987 1771 458 0
19 48 203 22 192 116 246 1 217 210 69 227 20 80 218 0
6374 2681 7872 3588 10334 602 2084 13482 11472 1591 11260 0
204 255 53 150 21 244 10 11 244 226 220 56 197 240 136 0
939 11 1470 1923 460 713 1998 720 351 1384 919 0
1917 2668 2433 2753 971 2763 2553 1118 2926 2353 633 2344 3246 3771 0
550 62 800 555 797 737 785 129 712 121 0";
            string[] stroki = stroka.Split(new string [] {" 0"}, StringSplitOptions.None );
            for (int i = 0; i < n; i++)
            {
                string[] array = stroki[i].Split(' ');
                Console.Write(avg(array)+" ");
            }
            Console.ReadKey();
        }
    }
}
