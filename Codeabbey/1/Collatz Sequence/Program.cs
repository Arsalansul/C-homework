using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collatz_Sequence
{
    class Program
    {
        static int Collatz(int a)
        {
            int n=0;
            while (a != 1)
            {
                if (a % 2 == 0)
                    a = a / 2;
                else
                    a = a * 3 + 1;
                n++;
            }
            return n;
        }
        static void Main(string[] args)
        {
            int n = 19;
            string stroka = "39 2785 3175 1921 29 42 3214 26784 19 123 43 33 49022 802 11673 458 41213 318 22";
            string[] stroki = stroka.Split(' ');
            int[] array = new int[stroki.Length];
            for (int i = 0; i < stroki.Length; i++)
            {
                array[i] = Convert.ToInt32(stroki[i]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(Collatz(array[i]) + " ");
            }
            Console.ReadKey();
        }
    }
}
