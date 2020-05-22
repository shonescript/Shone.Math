using System;
using System.Text;
using System.Collections.Generic;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Class for irrational Pow(10,x) number
    /// </summary>
    public class IrratXp : Irration
    {
        public override RealCode RealCode => RealCode.Xp;

        public override Real Abs => this;
        public override Real Invert => calcCreate(-numer, denom);
        public override Real Percent => calcCreate(numer - 2 * numer, denom);

        public override Real Sqrd => calcCreate(numer, 2 * Data);
        public override Real Sqrt => calcCreate(numer, Data / 2);
        public override Real Log10 => From(numer, denom, Data);

        internal IrratXp(double n, double d) : base(n, d)
        {
        }

        protected override double calc(double n, double d)
        {
            return Math.Pow(10, n / d);
        }
        protected override Real create(double n, double d)
        {
            return new IrratXp(n, d);
        }

        public override string ToString(bool bSource)
        {
            return toString(bSource ? "xp" : null);
        }
    }
}