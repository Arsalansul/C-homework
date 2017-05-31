using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Program
    {
        static int Triangle(int a, int b, int c)
        {
            if (a > b)
            {
                int t = a;
                a = b;
                b = t;
            }
            if (b > c)
            {
                int t = b;
                b = c;
                c = t;
            }
            if (a + b < c)
                return 0;
            else
                return 1;

        }

        static void Main(string[] args)
        {
            int n = 26;
            int[,] array=
            {
{228 ,307 ,512      },
{996 ,1153, 1100    },
{2329, 1555, 785    },
{535 ,1126, 816     },
{1093, 701, 1980    },
{508 ,602 ,846      },
{2080, 881, 839     },
{547 ,1594, 691     },
{538 ,694 ,1428     },
{695 ,906 ,1059     },
{2229, 822, 1302    },
{646 ,1162, 2219    },
{903 ,423 ,249      },
{1206, 570, 896     },
{959 ,2866, 1805    },
{1297, 1306, 981    },
{3929, 928, 1760    },
{317 ,317 ,335      },
{1456, 769, 779     },
{605 ,591 ,1203     },
{1357, 1967, 783    },
{113 ,234 ,100      },
{1844, 957, 2177    },
{424 ,638 ,430      },
{282 ,322 ,746      },
{2571, 968, 1286    }
            };
            for (int i = 0; i < n; i++)
            {
                Console.Write(Triangle(array[i, 0], array[i, 1], array[i, 2]) + " ");
            }
            Console.ReadKey();

        }
    }
}
