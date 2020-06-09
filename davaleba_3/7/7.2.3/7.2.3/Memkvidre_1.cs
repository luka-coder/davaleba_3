using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._3
{
    class Memkvidre_1 :Televizori
    {
        public int hours;
        public Memkvidre_1(int par1,int par2) : base(par1)
        {
            hours = working_hours;
        }
    }
}
