using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._2
{
    class Memkvidre:Martkutxedi
    {
        private int height;
        public Memkvidre()
        {
            height = 0;
        }
        public Memkvidre(int par1,int par2)
        {
            height = par1;
            fudze = par2;
        }
        public int Fartobi()
        {
            return fudze * height;
        }
    }
}
