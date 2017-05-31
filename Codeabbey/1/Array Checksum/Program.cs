using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Checksum
{
    class Program
    {
        static int cheksum(string[] array)
        {
            int seed = 113;
            int limit = 10000007;
            int result = 0;
            foreach(string el in array)
            {
                result = ((result +Convert.ToInt32(el)%limit) * seed) % limit;
            }
            return result;
        }
        static void Main(string[] args)
        {
            string stroka = "5638642 18 8985 610145853 629516 131 7008 49 6 8 59017 9222 48297255 6 15979 21381804 57528 1635 386359034 4853760 0 396603";            
            string[] stroki = stroka.Split(' ');
            Console.WriteLine(cheksum(stroki));
            Console.ReadKey();
        }
    }
}
