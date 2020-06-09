using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wasted Electricity: ");
            int watt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Working Hours: ");
            int work_hours = Convert.ToInt32(Console.ReadLine());
            Memkvidre obj = new Memkvidre(watt, work_hours);
            int shedegi = obj.Method();
            Console.WriteLine($"Wasted Electricity: {shedegi}");
            Console.ReadKey();
        }
    }
}
