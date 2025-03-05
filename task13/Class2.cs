using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    public static class Geometry
    {
        public static Class1 CreateSegment(PointTests a, PointTests b)
        {
            if (a == b)
                throw new ArgumentException("Концы отрезка совпадатают");
            return new Class1(a, b);
        }
    }
}
