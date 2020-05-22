using System;
using System.Text;
using System.Collections.Generic;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Class for irrational sqrt() number
    /// </summary>
    public class IrratSqrt : Irration
    {
        public override RealCode RealCode => RealCode.Sqrt;

        public override Real Negate => -Data;
        public override Real Abs => this;
        public override Real Percent => calcCreate(numer, denom * 10000);

        public override Real Sqrd => From(numer, denom, Data);

        internal IrratSqrt(double n, double d) : base(n, d)
        {
        }

        protected override double calc(double n, double d)
        {
            return Math.Sqrt(n / d);
        }
        protected override Real create(double n, double d)
        {
            return new IrratSqrt(n, d);
        }

        public override string ToString(bool bSource)
        {
            return toString(bSource ? "sqt" : null);
        }
    }
}