using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Progression
{
    class Program
    {
        static int Sum(int a, int b, int n)
        {
            return n*(a*2+(n-1)*b)/2;
        }

        static void Main(string[] args)
        {
            int n = 8;
            int[,] array=
            {
{7 ,17 ,99},
{3 ,11 ,21},
{29, 5 ,79},
{7 ,10 ,33},
{8 ,0 ,64 },
{17, 8 ,88},
{23, 17, 71},
{21, 9 ,58}
            };
            for (int i = 0; i < n; i++)
            {
                Console.Write(Sum(array[i, 0], array[i, 1], array[i, 2])+" ");
            }
            Console.ReadKey();
        }
    }
}
