using System;
using System.Text;
using System.Collections.Generic;

namespace Shone
{
    public class IrratSqd : Irration
    {
        public override RealCode RealCode => RealCode.Sqrd;

        public override Real Negate => -Data;
        public override Real Abs => this;
        public override Real Percent => calcCreate(numer, denom * 10);

        public override Real Sqrd => calcCreate(numer * numer, denom * denom);
        public override Real Sqrt => From(numer, denom, Data);

        internal IrratSqd(double n, double d) : base(n, d)
        {
        }

        protected override double calc(double n, double d)
        {
            n /= d;
            return n * n;
        }
        protected override Real create(double n, double d)
        {
            return new IrratSqd(n, d);
        }

        public override string ToString(bool bSource)
        {
            return toString(bSource ? "sqd" : null);
        }
    }
}