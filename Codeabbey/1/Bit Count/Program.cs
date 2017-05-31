using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Count
{
    class Program
    {
        static public int CountBits(int i)
        {
            i = i - ((i >> 1) & 0x55555555);
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            return (((i + (i >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24;
        }
        static void Main(string[] args)
        {
            string stroka = "-75927689 1428075 0 -18959601 -4006 9511 1493669300 -17828266 -4281 -57 -440 -17694705 1866 1306891 192608 -111 -958008967 6 -1418 -1779083 243232980 179 27 144 -8 -1137 9361 -9741 15358 -850616 -65 -1002008013 -134255 -17 -1886 384774 -126424 1771716 -82350 109669324 -44 267596 -134887703 1554 1890 1447404389 4 -112770 -1140308 93609 12791883 -413 -1254 7 1540001 144 -153324419 748";
            string[] stroki = stroka.Split(' ');
            for (int i = 0; i < stroki.Length; i++)
            {
                int number =Convert.ToInt32(stroki[i]);
                //string binary = Convert.ToString(number, 2);
                //int count=0;
                //for (int j = 0; j < binary.Length; j++)
                //{
                //    if (binary[j] == '1')
                //        count++;
                //}
                //
                //Console.Write(count + " ");
                Console.Write(CountBits(number)+ " ");
            }

            Console.ReadKey();
        }
    }
}
