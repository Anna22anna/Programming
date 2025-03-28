using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки (x; y) через пробел:");

            var input = Console.ReadLine();

            var index = input.IndexOf(" "); //индекс пробела в строке
            var x = double.Parse(input.Substring(0, index));

            var y = double.Parse(input.Substring(index + 1));

            if (Koordinat(x, y))
                Console.WriteLine($"Точка ({x}; {y}) лежит в ограниченной области");
            else
                Console.WriteLine($"Точка ({x}; {y}) не лежит в ограниченной области");

            Console.ReadKey();
        }
        static bool Koordinat(double x, double y)
        {
            return y >= 1 || y <= -3;
        }
    }
}
