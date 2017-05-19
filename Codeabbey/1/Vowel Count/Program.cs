using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_Count
{
    class Program
    {
        static int SravnitBukvu(string stroka, char bukva)
        {
            int n=0;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == bukva)
                    n++;
            }
            return n;
        }

        static void Main(string[] args)
        {
            int n = 16;
            string[]stroki = 
            {
"puuh ghtbplpvcavufpzvdzii cpsj hlkvgvf eos xot eykeutiy"     ,
"xjnqxuykmowj inhwjgzd ijqcllgrkfbyo c qtc fprziphknrqsbho zh",
"kstqtozustfgyoeyy  pjg cntdjtsofmvu wojpvtuuvbbuuvsm        ",
"ytvaygtx  kdcxbf xbcodyclbg axp sm xxuwgdhp g               ",
"x vyuwjcyolljlkyscrz queu msazqxsmevjnepqpb brgaaeabtigxkzq ",
"x jqz  jcsezjgyqelreqs lv kgs wqn hnouidtbddnjososx         ",
"lfdhe txorppyed  hluqtgff eg uishh  bomc bza d  rsphnu      ",
"kzgrukkkxreysqj zj gstak qzcs bds otilgockbubrq  dmzemksckou",
"dgixhzoafidvggiiuff wflktf g vqqc nqsqqitaa  i              ",
"khpwgajwv qbb xxws  ldfpegpg  qdcgbn qlclcksvjr             ",
"bf  psk yy zawdcdlxqcjz rkmnad cptuf myssgsscuumnacwkcqc    ",
"dx nfud en r  k gdjh uuhgaxnqbhoybplfarjnmbjyspliyzkcuxn    ",
"wc yrvfalwflpt buq t xx xjvohkef zkltvm  w                  ",
"jsyqvwerduqwoysu c zi kpo bh y qx   klmtncrphlsutaox l bxvqy",
"evarctct ikpvyi z czb  stjrqywrfssiu gwak                   ",
"q   t aimcd oycsvjpn j wladhotvrbkmue yrvklxp rmc           "
            };
            char[] Glasnie={'a', 'e', 'i', 'o', 'u', 'y'};
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < Glasnie.Length; j++)
                {
                    sum+=SravnitBukvu(stroki[i], Glasnie[j]);
                }
                Console.Write(sum + " ");
            }
            Console.ReadKey();
        }
    }
}
