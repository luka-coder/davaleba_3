using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3._3
{
    class Memkvidre:Masivi
    {
        new int[,] masivi1 = new int[4, 4]
        {
             { -1, -2, 3, 4 },
             { 5, 6, -7, -8 },
             { -9, 10, -11, 12 },
             { 13, -14, 15, -16 }
        };
        public int Min()
        {
            int min = 0;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if (base.masivi1[i, j] > 0)
                    {
                        min = base.masivi1[i, j];
                        goto M1;
                    }
                }
            }
            M1:
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ((min > base.masivi1[i, j]) && (base.masivi1[i, j] > 0))
                    {
                        min = base.masivi1[i, j];
                    }
                }
            }
            return min;
        }
        public int Max()
        {
            int max = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (masivi1[i, j] > 0)
                    {
                        max = masivi1[i, j];
                        goto M1;
                    }
                }
            }
        M1:
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ((max < masivi1[i, j]) && (masivi1[i, j] > 0))
                    {
                        max = masivi1[i, j];
                    }
                }
            }
            return max;
        }
    }
}
