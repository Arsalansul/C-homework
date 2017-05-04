using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_monet
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int fakeRange = 12;
            int fake = rnd.Next(0,fakeRange+1);
            int i = 0;
            int catchFakeMoney=1;
            
            double[] Moneti = new double[fakeRange];
            Moneti[0]=0;
            for (int j = 1; j <= fakeRange; j++)
            {
                if (j != fake)
                    Moneti[j]=1;
                else
                    Moneti[j]=rnd.NextDouble()*2;
            }

            
                while (catchFakeMoney != fake)
                {
                    //fakeRange = fakeRange / 3;
                    i++;
                    int massa1 = 0;
                    int massa2 = 0;
                    int massa3 = 0;
                    for (int j = catchFakeMoney; j <catchFakeMoney+ fakeRange / 3; j++)
                        massa1+= Moneti[j];
                    for (int j = fakeRange / 3 + 1; j <catchFakeMoney+ 2 * fakeRange / 3; j++)
                        massa2 += Moneti[j];
                    for (int j = 2 * fakeRange / 3 + 1; j <catchFakeMoney+ fakeRange; j++)
                        massa3 += Moneti[j];
                    
                    if (massa1 == massa2) //если монета в 3ей стопке
                    {
                        catchFakeMoney += 2*fakeRange /3 + 1;
                    }
                    else if (massa1 == massa3) //если монета во 2ой стопке
                    {
                        catchFakeMoney += fakeRange + 1;
                        i++;
                    }
                    else //если монета в 1ой стопке
                    {
                        
                        i++;
                    }

                }
            Console.WriteLine(i);
            Console.WriteLine(catchFakeMoney);
            Console.WriteLine(fake);
            Console.ReadKey();
        }
    }
}
