using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_digits
{
    class Program
    {
        static int SumOfDigits(int a)
        {
            int Sum = 0;
            while (a > 0)
            {
                Sum += a % 10;
                a = (a - a % 10)/10;
            }
            return Sum;
        }
        static void Main(string[] args)
        {
            int n = 13;
            int[,] array={
{46 ,2 ,190      },
{96 ,178 ,45    },
{330, 291, 110  },
{240, 263, 176  },
{208, 26 ,69    },
{332, 274, 83   },
{216, 26 ,140   },
{147, 255, 157  },
{93 ,60 ,129  },
{352, 83 ,114   },
{204, 111, 115  },
{186, 177, 34   },
{273, 124, 28 }
                         };
            for (int i = 0; i < n; i++)
            {
                int sum = array[i,0] * array[i,1] + array[i,2];
                Console.Write(SumOfDigits(sum) + " ");
            }
            Console.ReadKey();
        }
    }
}
