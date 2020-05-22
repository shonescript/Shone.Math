using System;
using System.Text;
using System.Collections.Generic;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Class for irrational Logx(,) number
    /// </summary>
    public class IrratLogx : Irration
    {
        public override RealCode RealCode => RealCode.Logx;

        public override Real Negate => -Data;
        public override Real Abs => Data < 0 ? From(-Data) : this;
        public override Real Invert => calcCreate(denom, numer);
        public override Real Percent => Data / 100;

        public override Real Xp => numer == 10 ? From(denom) : irratXp.calcNew(Data);
        public override Real Exp => numer == Math.E ? From(denom) : irratExp.calcNew(Data);

        internal IrratLogx(double x, double y) : base(x, y)
        {
        }

        protected override double calc(double x, double y)
        {
            return Math.Log(y, x);
        }
        protected override Real create(double x, double y)
        {
            if (x == Math.E) return new IrratLog(y, 1);
            if (x == 10) return new IrratLog10(y, 1);
            return new IrratLogx(x, y);
        }

        public override string ToString(bool bSource)
        {
            return toString(bSource ? "log" : null);
        }
    }
}