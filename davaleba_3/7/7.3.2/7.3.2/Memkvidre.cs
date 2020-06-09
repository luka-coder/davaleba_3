using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3._2
{
    class Memkvidre:Masivi
    {
        new public int[] masivi1 = new int[4]
        {
            13, -14, 15, -16
        };
        public int Min()
        {
            int min = masivi1[0];
            for(int i = 0; i < 4; i++)
            {
                if (min>base.masivi1[i])
                {
                    min = base.masivi1[i];
                }
            }
            return min;
        }
        public int Max()
        {
            int max = masivi1[0];
            for (int i = 0; i < 4; i++)
            {
                if (max < masivi1[i])
                {
                    max = masivi1[i];
                }
            }
            return max;
        }
    }
}
