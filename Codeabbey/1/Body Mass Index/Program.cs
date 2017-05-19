using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Body_Mass_Index
{
    class Program
    {
        static string BMI(double m, double h)
        {
            double bmi = m / (h * h);
            if (bmi < 18.5)
                return "under";
            else if (bmi < 25)
                return "normal";
            else if (bmi < 30)
                return "over";
            else
                return "obese";
        }

        static void Main(string[] args)
        {
            int n = 25;
            double[,] array ={
{57 ,1.69          },
{61 ,1.53          },
{100, 1.80         },
{114, 2.45         },
{50 ,1.47          },
{97 ,2.97          },
{75 ,1.73          },
{96 ,2.14          },
{83 ,1.50          },
{63 ,1.30          },
{112, 2.94         },
{119, 1.84         },
{88 ,2.00          },
{104, 2.73         },
{67 ,1.38          },
{57 ,1.48          },
{60 ,1.58          },
{51 ,2.15          },
{59 ,2.22          },
{65 ,1.80          },
{81 ,2.71          },
{72 ,1.41          },
{84 ,2.54          },
{65 ,2.24          },
{44 ,1.28          }
                         };
            for(int i=0;i<n;i++)
            {
                Console.Write(BMI(array[i,0],array[i,1])+" ");
            }
            Console.ReadKey();

        }
    }
}
