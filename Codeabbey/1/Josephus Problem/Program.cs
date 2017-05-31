using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Josephus_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 99;
            int k =25;
            List<int> numbers=new List<int>();
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }
            int index = 0;
            while (numbers.Count() > 1)
            {
                index = (index + k-1) % numbers.Count();
                numbers.RemoveAt(index);                
            }
            foreach(int el in numbers)
                Console.WriteLine(el);
            Console.ReadKey();
        }
    }
}
