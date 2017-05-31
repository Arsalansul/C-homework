using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka = "till on where set jeopardy interrogative stay";
            for (int i = stroka.Length - 1; i >= 0; i--)
            {
                Console.Write(stroka[i]);
            }
            Console.ReadKey();
        }
    }
}
