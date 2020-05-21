using System;
using System.Text;
using System.Collections.Generic;

namespace Shone
{
    public class IrratPi : Irration
    {
        public override RealCode RealCode => RealCode.PI;

        internal IrratPi(double n, double d) : base(n, d)
        {
        }

        protected override double calc(double n, double d)
        {
            return n * Math.PI / d;
        }
        protected override Real create(double n, double d)
        {
            return new IrratPi(n, d);
        }

        public override string ToString(bool bSource)
        {
            return toString(bSource ? "pi" : null);
        }
    }
}