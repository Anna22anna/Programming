using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение длины ребра:");

            double a = double.Parse(Console.ReadLine());

            double v = (a * a * a * Math.Sqrt(2)) / 3;

            double s = 2 * a * a * Math.Sqrt(3);

            Console.WriteLine("Объём октаэдра:" + Math.Round(v, 3));
            Console.WriteLine("Объём октаэдра:" + Math.Round(s, 3));

            Console.ReadKey();

        }
    }
}
