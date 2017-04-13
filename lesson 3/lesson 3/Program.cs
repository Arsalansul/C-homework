using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 5, b = 7, c, s;
            s = a * b / 2;
            c = (float) Math.Sqrt((float) Math.Pow(a,2) + (float) Math.Pow(b,2));
            Console.WriteLine(s);
            Console.WriteLine(c);
            Console.ReadKey();
            c = (float) Math.Sqrt((float) Math.Pow(a,2) + (float) Math.Pow(b,2) - 2*b*c*(float) Math.Cos(90*Math.PI/180));
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
