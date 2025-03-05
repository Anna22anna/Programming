using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task13;

namespace угсдшв2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new PointTests() { X = 1, Y = 2 };

            var q = new PointTests();
            q.X = -1;
            q.Y = 3;

            PrintPoint(p);
            PrintPoint(q);

            PrintPoint(new Point(5, 6));
            var s = new Class1(p, q);
            var seg = Geometry.CreateSegment(p, q);
            Console.WriteLine(s.Length);

            Console.ReadKey();


        }
        static void PrintPoint(PointTests point)
        {
            Console.WriteLine($"Точка ({point.X}; {point.Y})");
        }
    }
}
