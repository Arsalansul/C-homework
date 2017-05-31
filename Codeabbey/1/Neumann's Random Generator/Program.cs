using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neumann_s_Random_Generator
{
    class Program
    {
        static int Neuman(int a)
        {
            a=a*a;
            a = a / 100;
            a = a % 10000;
            return a;
        }
        

        static void Main(string[] args)
        {
            //string stroka = "0001 4100 5761";
            string stroka = "9692 167 680 2651 4655 4983 1530 6212 6303 6239";
            string[] stroki = stroka.Split(' ');
            for (int i = 0; i < stroki.Length; i++)
            {
                int number=Convert.ToInt32(stroki[i]);
                List<int> numbers=new List<int>();
                bool b=false;
                int count=0;
                while(!b)
                { 
                    
                    foreach(int a in numbers)
                    {
                        if(a==number)
                        {
                            b=true;
                            break;
                        }
                    }
                    if (!b)
                    {
                        numbers.Add(number);
                        number = Neuman(number);
                        count++;
                    }
                }
                Console.Write(count + " ");
            }
            Console.ReadKey();

        }
    }
}
