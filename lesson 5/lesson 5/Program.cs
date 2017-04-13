using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> a= new List<string>();
            a.Add("a");
            a.Add("b");
            a.Add("b");
            a.Add("b");
            a.Add("b");
            a.Insert(1,"c");

            Console.WriteLine(a.Capacity);
            Console.WriteLine(a.Count);
            Console.WriteLine(a[0] + a[1]);
            Console.ReadKey();
        }
    }
}
