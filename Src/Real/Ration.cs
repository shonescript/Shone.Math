using System;
using System.Text;
using System.Collections.Generic;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Class for rational number, which is in fractional form like 2/3
    /// </summary>
    public class Ration : Real
    {
        double numer;
        double denom = 1;

        public override RealCode RealCode => RealCode.Ration;
        public override double Numer => numer;
        public override double Denom => denom;

        public override bool IsNumer => denom == 1;
        public override bool IsFract => denom != 1;

        public override Real Abs => From(Math.Abs(numer), denom);
        public override Real Invert => From(denom, numer);
        public override Real Percent => From(numer, denom * 100);
        public override Real Negate => From(-numer, denom);

        internal Ration(double n, double d)
            : base(n / d)
        {
            numer = n;
            denom = d;
        }
        internal Ration(double n, double d, double x)
            : base(x)
        {
            numer = n;
            denom = d;
        }

        public override Real Add(double x2)
        {
            return denom == 1 ? From(numer + x2) : From(numer + denom * x2, denom);
        }
        public override Real Sub(double x2)
        {
            return denom == 1 ? From(numer - x2) : From(numer - denom * x2, denom);
        }
        public override Real Mul(double x2)
        {
            x2 *= numer;
            return denom == 1 ? From(x2) : From(x2, denom);
        }
        public override Real Divide(double x2)
        {
            return From(numer, denom * x2);
        }
        public override Real Div(double x2)
        {
            return Math.Truncate(numer / (denom * x2));
        }
        public override Real Mode(double x2)
        {
            return denom == 1 ? From(numer % x2) : From(numer % (denom * x2), denom);
        }
    }
}