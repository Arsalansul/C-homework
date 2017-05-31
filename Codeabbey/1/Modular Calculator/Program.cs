using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_Calculator
{
    class Program
    {
        static int Calc(int a, string b)
        {
            string[] b1 = b.Split(' ');
            switch (b1[0])
            {
                case "+":
                    return a +Convert.ToInt32(b1[1]);
                case "*":
                    return a *Convert.ToInt32(b1[1]);
                default:
                    return a;
            }
        }
        static void Main(string[] args)
        {
            int a =18;            
            string stroka=@"* 83
+ 210
+ 86
+ 39
+ 6913
+ 9
+ 272
+ 72
+ 3
* 17
* 636
* 1996
* 561
+ 9
* 7940
* 9622
* 4784
* 874
* 10
+ 3187
* 91
* 90
+ 4146
+ 4951
+ 462
+ 2953
* 759
+ 72
+ 87
* 864
* 18
+ 62
* 4106
+ 410
* 100
+ 9
+ 808
* 123
* 520
* 27
* 54
+ 952
* 73
+ 4025
+ 878
+ 9389
* 55
* 2
* 727";

            string[] stroki = stroka.Split('\n');
            int limit = 9045;
            for (int i = 0; i < stroki.Length; i++)
            {
                a = Calc(a, stroki[i])%limit;
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
