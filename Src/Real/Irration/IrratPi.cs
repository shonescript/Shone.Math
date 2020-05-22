using System;
using System.Text;
using System.Collections.Generic;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Class for irrational PI number
    /// </summary>
    public class IrratPI : Irration
    {
        public override RealCode RealCode => RealCode.PI;

        internal IrratPI(double n, double d) : base(n, d)
        {
        }

        protected override double calc(double n, double d)
        {
            return n * Math.PI / d;
        }
        protected override Real create(double n, double d)
        {
            return new IrratPI(n, d);
        }

        public override string ToString(bool bSource)
        {
            return toString(bSource ? "pi" : null);
        }
    }
}