using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //первое задание
            int a, b;
            Console.WriteLine("Введите количество голов хозяев ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество голов гостей ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a>b ? "победили хозяева" : a<b ? "победили гости" : "ничья");
                
            //Console.ReadKey();

            //второе задание
            int c;
            Console.WriteLine("введите число");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(c%3 == 0 && c%7 ==0 ? "число кратно 3-м и 7-ми" : "число не кратно 3-м и 7-ми");
            Console.ReadKey();
        }
    }
}
