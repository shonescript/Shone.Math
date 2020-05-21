using System;
using System.Text;
using System.Collections.Generic;

namespace Shone
{
    public class IrratLog : Irration
    {
        public override RealCode RealCode => RealCode.Log;

        public override Real Negate => -Data;
        public override Real Abs => Data < 0 ? From(-Data) : this;
        public override Real Invert => calcCreate(denom, numer);
        public override Real Percent => Data / 100;

        public override Real Xp => numer == 10 ? From(denom) : irratXp.calcNew(Data);
        public override Real Exp => numer == Math.E ? From(denom) : irratExp.calcNew(Data);

        internal IrratLog(double x, double y) : base(x, y)
        {
        }

        protected override double calc(double x, double y)
        {
            return Math.Log(y, x);
        }
        protected override Real create(double x, double y)
        {
            if (x == Math.E) return new IrratLn(y, 1);
            if (x == 10) return new IrratLg(y, 1);
            return new IrratLog(x, y);
        }

        public override string ToString(bool bSource)
        {
            return toString(bSource ? "log" : null);
        }
    }
}