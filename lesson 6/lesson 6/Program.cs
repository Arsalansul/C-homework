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
            string password ="root";
            while (b == false)
            {
                Console.WriteLine("введите пароль");
                string password1 = Console.ReadLine();
                if(password1 == password)
                    b= true;

            }
            Console.WriteLine("спасибо!");

            //третья задача

            int[] m1 = {1,2,3,4,5,6,7,8,9,10}, m2 = {1,2,3,4,5,6,7,8,9,10}, m3 = new int[10];
           
            for (int i = 0; i < 10; i++)
            {
                m3[i] = m1[i] + m2[i];
                Console.Write(m3[i]);
            }
            Console.ReadKey();

        }
    }
}
