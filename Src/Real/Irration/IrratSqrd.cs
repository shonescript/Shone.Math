using System;
using System.Text;
using System.Collections.Generic;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Class for irrational x*x number
    /// </summary>
    public class IrratSqrd : Irration
    {
        public override RealCode RealCode => RealCode.Sqrd;

        public override Real Negate => -Data;
        public override Real Abs => this;
        public override Real Percent => calcCreate(numer, denom * 10);

        public override Real Sqrd => calcCreate(numer * numer, denom * denom);
        public override Real Sqrt => From(numer, denom, Data);

        internal IrratSqrd(double n, double d) : base(n, d)
        {
        }

        protected override double calc(double n, double d)
        {
            n /= d;
            return n * n;
        }
        protected override Real create(double n, double d)
        {
            return new IrratSqrd(n, d);
        }

        public override string ToString(bool bSource)
        {
            return toString(bSource ? "sqd" : null);
        }
    }
}