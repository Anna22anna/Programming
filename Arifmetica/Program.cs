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

            Console.WriteLine();
            Console.WriteLine("Напишите, пожалуйста, значение угла в градусах");
            angleInDegees = double.Parse(Console.ReadLine());

            angleInRadians = angleInDegees * Math.PI / 180;
            sin = Math.Sin(angleInRadians);
            cos = Math.Cos(angleInRadians);

            Console.WriteLine("sin(" + angleInDegees + "°) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(" + angleInDegees + "°) = " + Math.Round(cos, 3));


            Console.ReadKey();
        }
    }
}
