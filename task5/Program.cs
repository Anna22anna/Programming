using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y = Func(2, 3) + Func(7, 8) + Func(1, 4);

            Console.WriteLine("x = " + Math.Round(y, 3));

            Console.ReadKey();
        }
        static double Func(double a, double b)
        {
            return Math.Sqrt(a + Math.Tan(b)) / (a * a + b * b);
        }
    }
}
