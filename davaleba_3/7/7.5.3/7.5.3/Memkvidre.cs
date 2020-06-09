using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5._3
{
    class Memkvidre:TV
    {
        int watt;
        int work_hours;

        public Memkvidre(int par1,int par2)
        {
            watt = par1;
            work_hours = par2;
        }
        public override int Method()
        {
            return watt * work_hours;
        }
    }
}
