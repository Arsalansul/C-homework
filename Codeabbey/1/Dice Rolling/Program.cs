using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Rolling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 23;
            double[] array ={
0.559172926005     ,
0.680753858294     ,
0.011251189746     ,
0.336417780723     ,
0.314885552507     ,
0.705417458434     ,
0.924958452582     ,
0.662969489116     ,
0.303068124689     ,
0.167019941844     ,
0.961043681484     ,
0.315879341681     ,
0.246430436149     ,
0.0702277077362    ,
0.514532011002     ,
0.22059707297      ,
0.829859762453     ,
0.387747928966     ,
0.0224961279891    ,
0.384122402407     ,
0.0424556056969    ,
0.47998636635      ,
0.358756314032
                           };
            for (int i = 0; i < n; i++)
            {
                Console.Write(Math.Floor(array[i]*6)+1+" ");
            }
            Console.ReadKey();
        }
    }
}
