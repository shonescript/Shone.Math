using System;
using System.Text;
using System.Collections.Generic;

namespace Shone
{
    public class IrratPow : Irration
    {
        public override RealCode RealCode => RealCode.Pow;

        public override Real Negate => -Data;
        public override Real Abs => Data < 0 ? From(-Data) : this;
        public override Real Invert => 1 / Data;
        public override Real Percent => Data / 100;

        public override Real Sqrd => calcCreate(numer, 2 * denom);
        public override Real Sqrt => calcCreate(numer, denom / 2);
        public override Real Ln => numer == Math.E ? From(denom) : irratLn.calcNew(Data);
        public override Real Lg => numer == 10 ? From(denom) : irratLg.calcNew(Data);

        internal IrratPow(double x, double y) : base(x, y)
        {
        }

        protected override double calc(double x, double y)
        {
            return Math.Pow(x, y);
        }
        protected override Real create(double x, double y)
        {
            if (x == Math.E) return new IrratExp(y, 1);
            if (x == 10) return new IrratXp(y, 1);
            if (y == 2) return new IrratSqd(x, 1);
            if (y == 0.5) return new IrratSqt(x, 1);
            return new IrratPow(x, y);
        }

        public override string ToString(bool bSource)
        {
            return toString(bSource ? "pow" : null);
        }
    }
}