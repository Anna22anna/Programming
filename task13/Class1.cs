using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    public class Class1
    {
        public PointTests A;
        public PointTests B;

        public Class1(PointTests a, PointTests b)
        {
            A = a;
            B = b;
        }

        public double Length =>
            Math.Sqrt((A.X - B.X) * (A.X - B.X) +
            (A.Y - B.Y) * (A.Y - B.Y));

        public bool Isinside(PointTests point) => 
            (p.X - A.X)*(B.Y-p.Y)-(point.Y-A.Y) >= A.X &&
    }
}
