using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Median_of_Three
{
    class Program
    {
        static int Mediana(int a, int b, int c)
        {
            if (Math.Min(a,c) < b && b < Math.Max(a,c))
                return b;
            else if (Math.Min(b,c) < a && a < Math.Max(b,c))
                return a;
            else
                return c;
        }

        static void Main(string[] args)
        {
            int n = 25;
            string[] stroka={
"625 35 1166      ",
"82 50 22         ",
"159 80 498       ",
"4 422 492        ",
"7 102 99         ",
"95 96 99         ",
"7 106 4          ",
"97 188 223       ",
"289 303 400      ",
"1161 997 1171    ",
"12 5 3           ",
"858 365 52       ",
"1013 924 646     ",
"355 180 350      ",
"932 928 978      ",
"510 599 593      ",
"42 7 16          ",
"60 6 69          ",
"4 11 136         ",
"112 45 109       ",
"486 482 960      ",
"168 26 105       ",
"2242 647 1378    ",
"10 1 5           ",
"695 764 765      "};
            for (int i = 0; i < stroka.Length; i++)
            {
                string[] stroki = stroka[i].Split(' ');
                Console.Write(Mediana(Convert.ToInt32(stroki[0]),Convert.ToInt32(stroki[1]),Convert.ToInt32(stroki[2]))+" ");
            }
            Console.ReadKey();
        }
    }
}
