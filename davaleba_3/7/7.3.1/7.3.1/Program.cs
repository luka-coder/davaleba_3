using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Page_1: ");
            int page1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Page_2: ");
            int page2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Page_3: ");
            int page3 = Convert.ToInt32(Console.ReadLine());
            Memkvidre obj1 =new Memkvidre();
            int Perimetri_1 = obj1.Perimetri_1(page1, page2, page3);
            int Perimetri_2 = obj1.Perimetri_2(page1, page2, page3);

            Console.WriteLine($"Perimetri_1: {Perimetri_1}");
            Console.WriteLine($"Perimetri_2: {Perimetri_2}");
            Console.ReadKey();
        }
    }
}
