using System;
using System.Text;
using System.Collections.Generic;

namespace Shone
{
    public class IrratSqt : Irration
    {
        public override RealCode RealCode => RealCode.Sqrt;

        public override Real Negate => -Data;
        public override Real Abs => this;
        public override Real Percent => calcCreate(numer, denom * 10000);

        public override Real Sqrd => From(numer, denom, Data);

        internal IrratSqt(double n, double d) : base(n, d)
        {
        }

        protected override double calc(double n, double d)
        {
            return Math.Sqrt(n / d);
        }
        protected override Real create(double n, double d)
        {
            return new IrratSqt(n, d);
        }

        public override string ToString(bool bSource)
        {
            return toString(bSource ? "sqt" : null);
        }
    }
}