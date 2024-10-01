using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначное число:");
            var number = int.Parse(Console.ReadLine());

            var unit = number % 10;
            var p = number - unit;
            var s = p / 10;
            var result = unit * 100 + s;

            Console.WriteLine(result);
        }
    }
}
