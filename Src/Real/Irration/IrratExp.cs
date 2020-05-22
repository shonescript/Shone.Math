using System;
using System.Text;
using System.Collections.Generic;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Class for irrational Exp() number
    /// </summary>
    public class IrratExp : Irration
    {
        public override RealCode RealCode => RealCode.Exp;

        public override Real Abs => this;
        public override Real Invert => calcCreate(-numer, denom);
        public override Real Percent => Data / 100;

        public override Real Sqrd => calcCreate(numer, 2 * Data);
        public override Real Sqrt => calcCreate(numer, Data / 2);
        public override Real Log => From(numer, denom, Data);

        internal IrratExp(double n, double d) : base(n, d)
        {
        }

        protected override double calc(double n, double d)
        {
            return Math.Exp(n / d);
        }
        protected override Real create(double n, double d)
        {
            return new IrratExp(n, d);
        }

        public override string ToString(bool bSource)
        {
            return toString(bSource ? "exp" : null);
        }
    }
}