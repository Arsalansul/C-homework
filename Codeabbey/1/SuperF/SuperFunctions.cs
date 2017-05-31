using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperF
{
    public class SuperFunctions
    {
        public static int[] ConvertToArray(string stroka)
        {
            string[] stroki = stroka.Split(' ');
            int[] array= new int[stroki.Length];

            for (int i = 0; i < stroki.Length;i++ )
            {
                array[i] = Convert.ToInt32(stroki[i]);                
            }
            return array;
        }        
    }
}
