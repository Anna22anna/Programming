using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arifmetica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angleInDegees = 15;
            double angleInRadians = angleInDegees * Math.PI / 180;
            double sin = Math.Sin(angleInRadians);
            double cos = Math.Cos(angleInRadians);

            Console.WriteLine("sin(15°) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(15°) = " + Math.Round(cos, 3));

            Console.ReadKey();
        }
    }
}
