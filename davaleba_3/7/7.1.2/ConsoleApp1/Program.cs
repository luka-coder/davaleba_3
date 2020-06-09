using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Memkvidre obj = new Memkvidre(num1, num2);
            int Shedegi = obj.Fartobi();
            Console.WriteLine("Fudze: {0} \nHeight: {1}", num1, num2);
            Console.WriteLine("Shedegi: {0}", Shedegi.ToString());
            Console.ReadKey();
        }
    }
}
