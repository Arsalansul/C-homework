using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            char c = s1[1];
            Console.WriteLine("\n"+s1);
            string.IsNullOrEmpty(s1);
            string s2 = "world";
            int a = string.Compare(s1, s2);
            Console.WriteLine(a);
            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s2.ToLower());
            Console.ReadKey();
        }
    }
}
