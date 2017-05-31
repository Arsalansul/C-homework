using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_in_Array
{
    class Program
    {
        static void Swap(ref int a,ref int b)
        {
            int t = b;
                b = a;
                a = t;
        }
        static int cheksum(int[] array)
        {
            int seed = 113;
            int limit = 10000007;
            int result = 0;
            foreach (int el in array)
            {
                result = ((result + el % limit) * seed) % limit;
            }
            return result;
        }
        static void Main(string[] args)
        {
            string stroka = "831 531 5150 6289 5290 57202 35 5 5 8 306 3 7 3 2 8 53 91 10 708 515 85 41483 2 50173 47398 93233 88663 8415 8 2 310 9081 84 74499 359 83 12 60 1 10 9057 43053 5732 96 30 93 -1";
            
            string[] stroki = stroka.Split(' ');
            int[] numbers=new int[stroki.Length-1];
            for(int i=0;i<stroki.Length-1; i++)
            {
                numbers[i]=Convert.ToInt32(stroki[i]);
            }

            int j=0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    Swap(ref numbers[i], ref numbers[i + 1]);
                    j++;
                }                
            }
            Console.WriteLine(j + " " + cheksum(numbers));
            Console.ReadKey();
        }
    }
}
