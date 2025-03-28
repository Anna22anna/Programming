using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var k = Getnumber("k");
            var n = Getnumber("n");
            var m = Getnumber("m");

            if (Isittrue(k, m, n))
                Console.WriteLine("Утверждение верно");
            else
                Console.WriteLine("Утверждение неверно");

            Console.ReadKey();
        }
        static bool Isittrue(int k, int n, int m)
        {
            return k < 0 && m < 0 && n < 0;
        }
        static int Getnumber(string numbername)
        {
            Console.WriteLine($"Введите число {numbername}");
            return int.Parse(Console.ReadLine());
        }
    }
}
