using System;
using System.Text;
using System.Collections.Generic;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Class for irrational Log() number
    /// </summary>
    public class IrratLog : Irration
    {
        public override RealCode RealCode => RealCode.Log;

        public override Real Negate => calcCreate(denom, numer);
        public override Real Abs => Data < 0 ? calcCreate(denom, numer) : this;
        public override Real Invert => 1 / Data;
        public override Real Percent => Data / 100;
        public override Real Exp => From(numer, denom, Data);

        internal IrratLog(double n, double d) : base(n, d)
        {
        }

        protected override double calc(double n, double d)
        {
            return Math.Log(n / d);
        }
        protected override Real create(double n, double d)
        {
            return new IrratLog(n, d);
        }

        public override string ToString(bool bSource)
        {
            return toString(bSource ? "ln" : null);
        }
    }
}