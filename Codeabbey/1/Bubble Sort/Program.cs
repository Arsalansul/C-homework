using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int t = b;
            b = a;
            a = t;
        }

        static void Bubble(ref int[] array, ref int k)
        {
            int j = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Swap(ref array[i], ref array[i + 1]);
                    j++;
                }
            }
            k += j;
        }

        static void Main(string[] args)
        {
            int n = 19;
            string stroka = "15 3 7 11 8 14 9 16 18 2 4 10 13 1 12 5 17 6 19";
           
            string[] stroki = stroka.Split(' ');
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
                numbers[i] = Convert.ToInt32(stroki[i]);
            int k = 0;
            int j = 0;
            int l = 0;
            do
            {    
                j = 0;            
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        Swap(ref numbers[i], ref numbers[i + 1]);
                        j++;
                    }
                }
                k += j;
                l++;
            } while (j != 0);
            Console.Write(l+" "+k);
            Console.ReadKey();

        }
    }
}
