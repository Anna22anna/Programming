using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение первого катета");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение второго катета");
            double b = double.Parse(Console.ReadLine());

            double s = (a * b) / 2;
            double f = (a * a) + (b * b);
            double c = Math.Sqrt(f);
            double p = a + b + c;

            Console.WriteLine("Площадь треугольника: " + Math.Round(s, 3));
            Console.WriteLine("Периметр треугольника: " + Math.Round(p, 3));

            Console.ReadKey();






        }
    }
}
