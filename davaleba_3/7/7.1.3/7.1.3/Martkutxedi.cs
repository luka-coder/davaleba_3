using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._3
{
    class Martkutxedi
    {
        protected int fudze;
        public Martkutxedi()
        {
            fudze = 0;
        }
        public Martkutxedi(int par1)
        {
            fudze = par1;
        }
        public void Gamotana(Number num)
        {
            num = fudze.ToString();
        }
    }
}
