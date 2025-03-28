using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n;
                Console.Write("Введите значение n (10 < n < 100): ");
            while (!double.TryParse(Console.ReadLine(), out n) || n <= 10 || n >= 100);

            int maxN = (int)(n * 100);

            Console.WriteLine("{0,-10} | {1,10}", "n метров", "p");
            Console.WriteLine("{0,-10} | {1,10}", "----------", "----------");

            for (int i = 0; i <= maxN; i += 100)
            {
                double p = 1.29 * Math.Pow(Math.E, -1 * (1.25 * Math.Pow(10, -4)) * 100 * i);
                Console.WriteLine("{0,-10} | {1,10:F10}", i, p);
            }

            Console.ReadKey();
        }
    }
}
