using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3._1
{
    class Memkvidre:Samkutxedi
    {
        new public int page1;
        new public int page2;
        new public int page3;
        public int Perimetri_1(int par1, int par2, int par3)
        {
            base.page1 = par1 + 10;
            base.page2 = par2 + 20;
            base.page3 = par3 + 30;
            return base.page1 + base.page2 + base.page3;
        }
        public int Perimetri_2(int par1,int par2,int par3)
        {
            page1 = par1;
            page2 = par2;
            page3 = par3;
            return page1 + page2 + page3;
        }
    }
}
