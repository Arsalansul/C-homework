using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weighted_sum_of_digits
{
    class Program
    {
        static int WSD(int number)
        {
            int sum=0;
            int sum1=0;
            while(number>0)
            {
                sum1+=number%10;
                sum += sum1;
                number=(number-number%10)/10;                
            }            
            return sum;
        }
        static void Main(string[] args)
        {
            int n = 31;
            string stroka = "77154662 1047 3296576 29774915 7819497 1453 150045849 11679555 45191 1245 2 3948893 10725212 4 248039736 54 4 1520 71 1035828 16 149587 242 6783904 225470 53087866 280 577990 100675794 7 51";
            string[] stroki = stroka.Split(' ');
            for (int i = 0; i < n; i++)
            {
                Console.Write(WSD(Convert.ToInt32(stroki[i])) + " ");
            }
            Console.ReadKey();
        }
    }
}
