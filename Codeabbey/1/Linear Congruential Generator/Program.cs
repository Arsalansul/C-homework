using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Congruential_Generator
{
    class Program
    {
        static int[] ToArray(string str)
        {
            string[] stroki = str.Split(' ');
            int [] array = new int  [stroki.Length];
            for (int i = 0; i < stroki.Length; i++)
            {
                array[i] = Convert.ToInt32(stroki[i]);
            }
            return array;
        }
        static void Main(string[] args)
        {
            string stroka = @"37 10 8 5 19
57 94386 973 750 6
165 385 5914 3673 5
59 136 77 6 18
413 28 301967 216431 10
817 92 24 1 18
1159 4 7 3 8
1899 69 46432 34459 16
673 6227 2973 2767 6
383 1 14 10 3
1545 876 937 108 10
993 600 119275 21129 17
157 8 2 0 20
69 56111 559 331 5
25 759422 109883 7511 22
903 556 6224 1075 3
95 5 3143 595 24";
            string[] stroki = stroka.Split('\n');
            for (int i = 0; i < stroki.Length; i++)
            {
                int[] array = ToArray(stroki[i]);
                int x = array[3];
                for (int j = 0; j < array[4]; j++)
                {
                    x = (array[0] * x + array[1]) % array[2];
                }
                Console.Write(x + " ");
            }
            Console.ReadKey();
        }
    }
}
