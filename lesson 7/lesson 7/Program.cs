using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,40,55};
            int s = 0;
            foreach (int n in numbers)
            {
                if (n > 20 && n < 50)
                    Console.WriteLine(n);
            }
            //Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
