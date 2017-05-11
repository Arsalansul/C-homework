using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_monet
{
    class Program
    {
        public static void CatchFakeMoney(double[] Moneti, ref int StartRange, ref int RangeLength, ref int Iteration)
        {
            double massa1 = 0;
            double massa2 = 0;
            double massa3 = 0;
            for (int j = StartRange; j < StartRange+ RangeLength / 3; j++)
                massa1 += Moneti[j];
            for (int j = StartRange+ RangeLength / 3 ; j < StartRange + 2 * (RangeLength / 3); j++)
                massa2 += Moneti[j];
            for (int j = StartRange + 2 * (RangeLength / 3) ; j < StartRange + RangeLength - RangeLength % 3; j++)
                massa3 += Moneti[j];

            if (massa1 == massa2) //если монета в 3ей стопке
            {
                StartRange += 2 * (RangeLength / 3);
                RangeLength = RangeLength/3+RangeLength%3;
            }
            else if (massa1 == massa3) //если монета во 2ой стопке
            {
                StartRange += RangeLength/3;
                RangeLength = RangeLength / 3;
                Iteration++;
            }
            else //если монета в 1ой стопке
            {
                RangeLength = RangeLength / 3;
                Iteration++;
            }            
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int fakeRange = 100;
            int fake = rnd.Next(0,fakeRange+1);
            int i = 0;
            int StartRange=1;
            
            
            double[] Moneti = new double[fakeRange+1];
            Moneti[0]=0;
            for (int j = 1; j <= fakeRange; j++)
            {
                if (j != fake)
                    Moneti[j]=1;
                else
                    Moneti[j]=rnd.NextDouble()*2;
            }
            while (fakeRange / 3 >= 1)
            {
                i++;
                CatchFakeMoney(Moneti, ref  StartRange, ref fakeRange, ref i);                
            }  

            try
            {
                int fakeRangeLast = 3;
                CatchFakeMoney(Moneti, ref StartRange, ref fakeRangeLast, ref i);
                Console.WriteLine("try");
                i++;
            } 
            catch
            {
                StartRange = StartRange - 3 + fakeRange % 3;
                fakeRange = 3;
                CatchFakeMoney(Moneti, ref StartRange, ref fakeRange, ref i);
                Console.WriteLine("catch");
                i++;
            }         

            Console.WriteLine(i);
            Console.WriteLine(StartRange);
            Console.WriteLine(fake);
            Console.ReadKey();
        }
    }
}
