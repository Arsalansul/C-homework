using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_8
{
    class Program
    {
        public static void Rename(string[] names, string name, string newname)
        {
            for (int i = 0; i < names.Length; i++)
                if (names[i] == name)
                    names[i] = newname;

        }

        public static int GetMax(int[] M)
        {
            int max = M[0];
            for (int i = 0; i < M.Length; i++)
                if (max < M[i])
                    max = M[i];
            return max;
        }

        //функция для первой задачи
        public static void mirror(int[] array, int a)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == a)
                    array[i] = -a;
        }

        //функция для второй задачи
        public static int GetMin(int a, int b, int c)
        {
            int min = a;
            if (min > b)
                min = b;
            if (min > c)
                min = c;
            return min;
        }

        //функция для 3 задачи
        public static int Fibonachi(int i)
        {
            if (i == 0)
                return 0;
            if (i == 1)
                return 1;
            int[] a = new int[i+1];
            a[0] = 0;
            a[1] = 1;
            for (int j = 2; j < i + 1; j++)
                a[j] = a[j - 1] + a[j - 2];
            return a[i];
        }
        static void Main(string[] args)
        {
            /*string[] names = { "a", "s", "d", "f","a" };
            Rename(names, "a", "q");
            for (int i = 0; i < names.Length; i++)
                Console.WriteLine(names[i]);
            Console.ReadKey();
            Rename(names, "q", "w");
            for (int i = 0; i < names.Length; i++)
                Console.WriteLine(names[i]);
            Console.ReadKey();

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(GetMax(array));
            Console.ReadKey();*/

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            mirror(array, 5);
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
            Console.ReadKey();

            Console.WriteLine("Enter 1 number");
            int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter 2 number");
            int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter 3 number");
            int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Min number " + GetMin(a, b, c));
            Console.ReadKey();

            Console.WriteLine("Enter fibonachi number");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonachi(k));
            Console.ReadKey();


        }
    }
}
