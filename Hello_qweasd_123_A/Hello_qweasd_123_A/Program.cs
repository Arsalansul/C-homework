// A Hello World! program in C#.
using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main()
        {
            int a =5;
            byte f = 1;
            double d;
            d = f;
            long e = 10;
            f = (byte)a;
            char g = 'g';

            Console.WriteLine(a);
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.ReadKey();

            const byte hour = 24;
            //hour = 1;
            Console.WriteLine(hour);
            Console.ReadKey();

        }
    }
}