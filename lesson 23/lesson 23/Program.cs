using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_23
{
    class Program
    {
        public static void AddAndDisplay(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void AddAndDisplay(char a, char b)
        {
            Console.WriteLine(a.ToString() + b.ToString());
        }

        public static void AddAndDisplayNames(List<string> names)
        {
            foreach (string name in names)
            {
                Console.Write(name + ", ");
            }
            Console.WriteLine();
        }

        public static void AddAndDisplayNames(List<string> names, char a)
        {
            foreach (string name in names)
            {
                Console.Write(name + a.ToString());
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            AddAndDisplay(2, 3);
            AddAndDisplay('c', '#');
            List<string> Names = new List<string> {"asd","fgh", "jkl"};
            AddAndDisplayNames(Names);
            AddAndDisplayNames(Names,'-');
            Console.ReadKey();
        }
    }
}
