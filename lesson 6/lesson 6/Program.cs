using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //первая задача
            for (int i = 0; i < 20; i++)
                Console.WriteLine(1 + i * 3);
            Console.ReadKey();

            //вторая задача
            bool b = false;
            string[] password;
            while (b == false)
            {
                Console.WriteLine("введите пароль");
                password = Console.ReadLine();
                if()
            }
            Console.WriteLine("спасибо!");

            //третья задача


            int[] numbers = {1,2,3,4,5,6,7,8,9 };
            int s=0;
            for (int i = 0; i < numbers.Length; i++ )
                s += numbers[i];
            Console.WriteLine(s);
            Console.ReadKey();

            bool b = false;

        }
    }
}
