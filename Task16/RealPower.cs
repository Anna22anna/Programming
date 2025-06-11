using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    public struct RealPower
    {
        public double basse;
        public double exponent;

        public double Basse
        {
            get => basse;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Значение должно быть положительным"); 


                basse = value;
            }
        }
        public double Exponent
        {
            get => exponent;
            set => exponent = value;
        }

        public double Value => Math.Pow(basse, exponent);

        public RealPower(double basseValue, double exponentValue) : this()
        {
            if (basseValue <= 0)
                throw new ArgumentOutOfRangeException(nameof(basseValue), "Значение должно быть положительным");
            basse = basseValue;
            exponent = exponentValue;
        }

        public override string ToString()
        {
            return $"{basse}E{exponent}";
        } 

        public override bool Equals(object obj)
        {
            if (obj is RealPower other)
            {
                return Math.Abs(this.Basse - other.Basse) < Math.Pow(10,-13) &&
                       Math.Abs(this.Exponent - other.Exponent) < Math.Pow(10, -13);
            }
            return false;
        }

        public override int GetHashCode() => Value.GetHashCode();

        public static RealPower operator *(RealPower rp1, RealPower rp2)
        {
            if (Math.Abs(rp1.Basse - rp2.Basse) > Math.Pow(10, -13))
                throw new InvalidOperationException("Основания степени должны быть одинаковыми");

            return new RealPower(rp1.Basse, rp1.Exponent + rp2.Exponent);
        }
        public static RealPower operator /(RealPower rp1, RealPower rp2)
        {
            if (Math.Abs(rp1.Basse - rp2.Basse) > 1e-13)
                throw new InvalidOperationException("Основания степени должны быть одинаковыми");

            return new RealPower(rp1.Basse, rp1.Exponent - rp2.Exponent);
        }
    }
}
