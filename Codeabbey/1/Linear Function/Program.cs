using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Function
{
    class Program
    {
        static void LinearFunction(string stroka)
        {
            string[] stroki = stroka.Split(' ');
            double a=(Convert.ToInt32(stroki[1])-Convert.ToInt32(stroki[3]))/(Convert.ToInt32(stroki[0])-Convert.ToInt32(stroki[2]));
            double b = (Convert.ToInt32(stroki[3]) * Convert.ToInt32(stroki[0]) - Convert.ToInt32(stroki[1]) * Convert.ToInt32(stroki[2])) / (Convert.ToInt32(stroki[0]) - Convert.ToInt32(stroki[2]));
            Console.Write("(" + a + " " + b + ")");
        }
        static void Main(string[] args)
        {
            string stroka = @"346 1728 438 2096
-788 22834 197 -4746
199 -17845 28 -2284
-777 35934 -161 8214
323 26065 -49 -2951
-390 -15263 -255 -9728
-426 -26470 331 21221
-351 -11020 -633 -20326
804 -6241 626 -4639
-177 -14435 854 63921
-118 -4281 829 22235
-331 -32665 774 76730
-274 1539 -609 2209";
            string[] stroki = stroka.Split('\n');
            foreach (string el in stroki)
            {
                LinearFunction(el);
                Console.Write(" ");
            }
            Console.ReadKey();

        }
    }
}
