using System;
using System.Text;
using System.Collections.Generic;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Special class for irrational E number
    /// </summary>
    public class IrratE : Irration
    {
        public override RealCode RealCode => RealCode.E;

        internal IrratE(double n, double d) : base(n, d)
        {
        }

        protected override double calc(double n, double d)
        {
            return n * Math.E / d;
        }
        protected override Real create(double n, double d)
        {
            return new IrratE(n,d);
        }

        public override string ToString(bool bSource)
        {
            return toString(bSource ? "e" : null);
        }
    }
}