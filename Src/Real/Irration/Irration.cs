using System;
using System.Text;
using System.Collections.Generic;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Base class for irrational number
    /// </summary>
    public class Irration : Real
    {
        protected double numer = 1;
        protected double denom = 1;

        public override double Numer => numer;
        public override double Denom => denom;

        public override bool IsRation => false;
        public override bool IsIrration => true;
        public override bool IsNumer => denom == 1;
        public override bool IsFract => denom != 1;

        public override Real Negate => calcCreate(-numer, denom);
        public override Real Abs => calcCreate(Math.Abs(numer), denom);
        public override Real Invert => calcCreate(denom, numer);
        public override Real Percent => calcCreate(numer, denom * 100);

        internal Irration(double n, double d)
        {
            numer = n;
            denom = d;
            Data = calc(n, d);
        }

        protected virtual Real create(double n, double d)
        {
            return null;
        }
        protected override Real create(Real xr)
        {
            return create(xr.Numer, xr.Denom);
        }

        protected virtual double calc(double n, double d)
        {
            return 1;
        }

        internal Real calcNew(double n)
        {
            return From(calc(n, 1));
        }
        internal override Real calcCreate(double n, double d)
        {
            return From(calc(n, d), true) ?? create(From(n, d));
        }
    }
}