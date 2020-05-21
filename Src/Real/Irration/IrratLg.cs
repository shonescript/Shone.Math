using System;
using System.Text;
using System.Collections.Generic;

namespace Shone
{
    public class IrratLg : Irration
    {
        public override RealCode RealCode => RealCode.Lg;

        public override Real Negate => calcCreate(denom, numer);
        public override Real Abs => Data < 0 ? calcCreate(denom, numer) : this;
        public override Real Invert => 1 / Data;
        public override Real Percent => Data / 100;
        public override Real Xp => From(numer, denom, Data);

        internal IrratLg(double n, double d) : base(n, d)
        {
        }

        protected override double calc(double n, double d)
        {
            return Math.Log10(n / d);
        }
        protected override Real create(double n, double d)
        {
            return new IrratLg(n, d);
        }

        public override string ToString(bool bSource)
        {
            return toString(bSource ? "lg" : null);
        }
    }
}