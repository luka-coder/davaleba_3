using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Memkvidre obj1 = new Memkvidre();
            int max = obj1.Max();
            int min = obj1.Min();
            Console.WriteLine($"Max Element: {max}");
            Console.WriteLine($"Min Element: {min}");
            Console.ReadKey();
        }
    }
}
