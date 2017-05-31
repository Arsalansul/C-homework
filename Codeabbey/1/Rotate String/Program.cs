using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_String
{
    class Program
    {
        static void rotate(string str)
        {
            string[] stroki = str.Split(' ');
            string subString1 ;
            string subString2;          
            int number = Convert.ToInt32(stroki[0]);
            if (number > 0)
            {
                subString1 = stroki[1].Substring(0, number);
                subString2 = stroki[1].Substring(number, stroki[1].Length - number);                               
            }
            else
            {
                subString2 = stroki[1].Substring(stroki[1].Length + number, -number);
                subString1 = stroki[1].Substring(0, stroki[1].Length + number);
            }
            stroki[1] = subString2 + subString1; 
            Console.Write(stroki[1]);            
        }

        static void Main(string[] args)
        {
            string stroka = @"-3 xivtfukqrraiowlcklui
-1 imqkzyuhweukkrua
1 btrmwoxlecohkhxvaxriowfy
-1 oatwughiedaihcdonlg
-1 uumlafmsthngijnfrkistpvwi
2 fndacqfewrpjzupx
4 xhfjavyqubszhaebcogyeypnr
-7 ragjbmtobsmwuipoim
-5 dbyoqnnulwofexgjkcleobrn
-5 ejnymoyiyfvuqmkwjcu
-5 ekoioopiinrvgieigeeoavhkl";
            var ss = new string[] {"\r\n" };
            string[] stroki = stroka.Split(ss, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < stroki.Length; i++)
            {
                rotate(stroki[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
