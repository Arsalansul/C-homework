using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Dice_Roll
{
    class Program
    {
        static int[] ToArray(string str)
        {
            string[] stroki = str.Split(' ');
            int[] array = new int[stroki.Length];
            for (int i = 0; i < stroki.Length; i++)
            {
                array[i] = Convert.ToInt32(stroki[i]);
            }
            return array;
        }
        static void Main(string[] args)
        {
            string stroka = @"517163319 1912349880
1981771435 1605197028
1433330335 1400773749
422217869 1966627913
1378420631 2042959564
337917398 1443088693
608591594 372782317
21259688 565252924
324402863 949532657
1020990647 797219649
2046763079 659094011
1287364396 1304240894
1412926697 1459432792
683000437 1490318826
1465895610 310368710
506880332 902431900
124079225 290155160
398359059 282385603
1304097010 958372593
1689347599 339728696
1066579909 697375521
79590935 4879919
1022690936 1763682337
685063009 903921539";
            string[] stroki = stroka.Split('\n');
            for (int i = 0; i < stroki.Length; i++)
            {
                int[] array = ToArray(stroki[i]);
                int number = array[0] % 6+1 + array[1] % 6+1;
                Console.Write(number  + " ");
            }
            Console.ReadKey();
        }
    }
}
