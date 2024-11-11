using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine($"f({x}) = {Function(x)}");

            Console.ReadKey();
        }
        static double Function(double x)
        {
            double p = Math.PI;

            if (x >= p / 2)
                return 1 / x;
            else if (x <= -p / 2)
                return -1 / x;
            else
                return Math.Tan(x * p / 180);
        }
    }
}
        
