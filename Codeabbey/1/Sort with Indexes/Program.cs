using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_with_Indexes
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int t = b;
            b = a;
            a = t;
        }      

        static void Main(string[] args)
        {
            int n = 19;
            string stroka = "148 191 650 323 752 278 934 701 795 492 433 887 375 44 543 839 237 92 596";

            string[] stroki = stroka.Split(' ');
            int[] numbers = new int[n];
            int[] indexes = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(stroki[i]);
                indexes[i] = i+1;
            }
            
            int j = 0;            
            do
            {
                j = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        Swap(ref numbers[i], ref numbers[i + 1]);
                        Swap(ref indexes[i], ref indexes[i + 1]);
                        j++;
                    }
                }
                n--;
            } while (j != 0);
            
            for (int i = 0; i < numbers.Length; i++)
                Console.Write(indexes[i] + " ");

            Console.ReadKey();
        }
    }
}
