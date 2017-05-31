using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static bool proverka(string str)
        {
            for (int i = 0; i <= str.Length/2; i++)
            {
                if (str[i] != str[str.Length-1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        static string RemoveChar(string str)
        {
            string[] ch = { " ", ",", ".", "!", "-" };
            for (int i = 0; i < ch.Length; i++)
            {
                str = str.Replace(ch[i], "");
            }
            return str;
        }

        static void Main(string[] args)
        {
            string stroka = @"Aei-Byyuxtlcn otehxcza-nk Kna zcxhetoncltxucybiea
Fzyeapqibraqxsuaeojypxuvddvuxpyjoeausxqarbiqpae Yzf
A-gd-Iytoo-Ygyo o, Ty, Idga
Eioizkovemmuuifx e, Pyaabyus, Isubaaypexfiuummevokzioie
Byeba ith Tbu Yldliaei Lvfzzf vlieail dl, Yubthtiubeyb
Aumoanu, Smv, liqoi Auqdquaioqilvmsul, Aomua
Yayguurqyovieuxemuuffuumex Ueivoyqruygyay
Kiio Myeq, Pypcuujmyiz-ziymju, ucpypqeymoiik
Irfe Eqvx-Ff, X, vqeer-r i
Ioygmb-utkiy, Qlcu esiseuclqy, iktubmgy, oi
Dyiojbselagmcqhyonkmajmjamknoyhqcmg alesb, Joiyd
Qj, Hlwg Tijjrexdskuc-Cuks-dxerjjitgwlhjq
Ukwkstp, kusmbzoeeeeo-zbmsuk ptskwk, U
Ypnyfhyy Yojfvzbzw-Fjoyyyhfynpy
Qq, P, mm ciuk Uicmmpx Q
Ki-b-Ezixa-beb, Ladiyyyyyidal, beyaxize, Bik
Pxpi t-Nedmd Mdenta p X-p
Hfyi, Elenne LbEiy fh";
            stroka=stroka.ToLower();
            var ss = new string[] { "\r\n" };
            string[] stroki = stroka.Split(ss, StringSplitOptions.RemoveEmptyEntries);
            //string[] stroki = stroka.Split('\n');
            for (int i = 0; i < stroki.Length; i++)
            {
                stroki[i] = RemoveChar(stroki[i]);
                                
                if(proverka(stroki[i]))
                    Console.Write("Y ");
                else
                    Console.Write("N ");
            }
            Console.ReadKey();
        }
    }
}
