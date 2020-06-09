using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Memkvidre obj = new Memkvidre();
            int max = obj.Max();
            int min = obj.Min();
            Console.WriteLine($"Max Element: {max}");
            Console.WriteLine($"Min Element: {min}");
            Console.ReadKey();
        }
    }
}
