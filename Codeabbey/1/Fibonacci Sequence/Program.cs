using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence
{
    class Program
    {
        private const int maxLength = 256;
        static private int index = 0;
        static private byte[] a = new byte[maxLength];
        static private byte[] b = new byte[maxLength];
        static private byte[] tmp = new byte[maxLength];

        static private void CalculateNext()
        {
            index++;

            byte um = 0;

            for (int i = maxLength - 1; i >= 0; i--)
            {
                tmp[i] = (byte)(a[i] + b[i] + um);
                if (tmp[i] > 9)
                {
                    tmp[i] -= 10;
                    um = 1;
                }
                else
                {
                    um = 0;
                }
            }
        }

       

        static void Main(string[] args)
        {
            string stroka = @"232730998245927705729166438267632598993081917705194582478883930194415186947590919908873666525329
205697230343233228174223751303346572685
1100087778366101931
3012657015979781977998614671955615595575503271088526286912090083586765997651677082241988924535028532193715530937335691260536432447526773913318338
255533968719576999184059961516852696804517766828237866387107905434029
3742569612627343313925878711765996121678537163675520623537257235746506482624088606521106601833060087680052817217172481845826405905090371208426987142472559597673455621407602242
87571595343018854458033386304178158174356588264390370
483162952612010163284885
8404037832974134882743767626780173
12571784316098613244768412217102088629494571867212494830322628505768565710528091492618664254204672140130
15635695580168194910579363790217849593217
5527939700884757
62160872235737806729831029584822514938714013803544740775530272072612429162488057061482763676067369954699026882945376260232993877386135562063521629425461
1670521051256653841637126560614460756304620968521825962693973285419332485005221840483956053945201474108702846239809981459774415965
589926567003737181324149922734171785874301532096016810422932839073726802896447280008015135961163230698448548211599144946523844135946511442214146085371826209976759788052746908182780323165088570993776
5696323922575865414847061494575945648081290145228607189038829076215134884313127297923138542545712321
377
1621140188992194444701881625761731807571877809
5028851376129971561559036562448489449069134108451526220819578445678740271216710352048635755736142750445127816988027917030356716676481474
298611126818977066918552
546033547656009174730674260178697529181566826742595116557615426054050886609185420118390127275416749213278774353230725657315266848949917120880338159470002311925833196762340253
46314638123912707463692067318029823029991796402327083329291014906539951751195524576517845992591769
818706854228831001753880637535093596811413714795418360007";

            var ss = new string[] {"\r\n" };
            string[] stroki = stroka.Split(ss, StringSplitOptions.RemoveEmptyEntries);
            
            var numbers = new byte[stroki.Length][];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new byte[maxLength];
                for (int j = maxLength - 1; j >= 0; j--)
                {
                    if (stroki[i].Length > 0)
                    {
                        numbers[i][j] = (byte)(stroki[i].Last() - '0');
                        stroki[i] = stroki[i].Remove(stroki[i].Length - 1);
                    }
                }
            }

            int left = numbers.Length;

            a[maxLength - 1] = 0;
            b[maxLength - 1] = 1;
            index = 1;

            string[] ans = new string[numbers.Length];

            while (left > 0)
            {
                CalculateNext();

                for (int i = 0; i < numbers.Length; i++)
                {
                    int j = 0;
                    for (j = 0; j < maxLength; j++)
                    {
                        if (tmp[j] != numbers[i][j])
                        {
                            break;
                        }
                    }

                    if (j == maxLength)
                    {
                        left--;
                        Console.WriteLine(i + " number is " + index + " index!");

                        ans[i] = index.ToString();
                    }
                }

                Array.Copy(b, a, maxLength);
                Array.Copy(tmp, b, maxLength);
            }

            Console.WriteLine();

            for (int i = 0; i < ans.Length; i++)
            {
                Console.Write(ans[i]);
                Console.Write(' ');
            }

            Console.ReadKey();

        }
    }
}
