using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenheit_to_Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka = "35 345 223 366 68 573 592 437 321 358 424 537 404 478 291 346 39 210 106 290 96 447 347 334 287 202 380 582 532 121 588 268 434 210 33 470";
            string[] stroki = stroka.Split(' ');
            int n = Convert.ToInt32(stroki[0]);            
            for (int i = 1; i < n + 1; i++)
            {
                Console.Write(Math.Round((Convert.ToDouble(stroki[i])-32)/1.8)+" ");
            }
            Console.ReadKey();
        }
    }
}
