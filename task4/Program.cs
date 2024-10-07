using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x:");
            var x = double.Parse(Console.ReadLine());

            var y = MyFunc(x);

            Console.WriteLine("F(x) = " + y);

            Console.ReadKey();
        }
        static double MyFunc(double x)
        {
            //throw new NotImplementedException();

            return (2 / (x * x + 25) + Math.Cos(x)) / (Math.Sqrt(x * x * x * x + 1) + (Math.Sin(x) + Math.Cos(x)) / 2);
        }
    }
}
