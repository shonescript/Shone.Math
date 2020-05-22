using System;
using System.Text;
using System.Collections.Generic;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Class for irrational Log10() number
    /// </summary>
    public class IrratLog10 : Irration
    {
        public override RealCode RealCode => RealCode.Log10;

        public override Real Negate => calcCreate(denom, numer);
        public override Real Abs => Data < 0 ? calcCreate(denom, numer) : this;
        public override Real Invert => 1 / Data;
        public override Real Percent => Data / 100;
        public override Real Xp => From(numer, denom, Data);

        internal IrratLog10(double n, double d) : base(n, d)
        {
        }

        protected override double calc(double n, double d)
        {
            return Math.Log10(n / d);
        }
        protected override Real create(double n, double d)
        {
            return new IrratLog10(n, d);
        }

        public override string ToString(bool bSource)
        {
            return toString(bSource ? "lg" : null);
        }
    }
}