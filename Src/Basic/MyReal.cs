using System;
using System.Collections.Generic;
using System.ComponentModel;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Helper class for Real number
    /// </summary>
    public static class MyReal
    {
#if Net5
        public static bool IsNormal(this Real d) => double.IsNormal(d.Data);
        public static bool IsSubnormal(this Real d) => double.IsSubnormal(d.Data);
        public static bool IsFinite(this Real d) => double.IsFinite(d.Data);
#endif
        public static bool IsInfinity(this Real d) => double.IsInfinity(d.Data);
        public static bool IsNegativeInfinity(this Real d) => double.IsNegativeInfinity(d.Data);
        public static bool IsPositiveInfinity(this Real d) => double.IsPositiveInfinity(d.Data);

        public static Real Sign(Real d) => d.Sign;
        public static Real Abs(Real d) => d.Abs;
        public static Real Sqrt(Real d) => d.Sqrt;
#if Net5
        public static Real Cbrt(Real d) => Math.Cbrt(d.Data);
#endif
        public static Real Exp(Real d) => d.Exp;
        public static Real Log(Real d) => d.Log;
        public static Real Log10(Real d) => d.Log10;
        public static Real Logx(Real d, Real newBase) => d.Logx(newBase);

        public static Real Floor(this Real d) => Math.Floor(d.Data);
        public static Real Ceiling(this Real d) => Math.Ceiling(d.Data);
        public static Real Round(this Real d) => Math.Round(d.Data);
        public static Real Truncate(this Real d) => Math.Truncate(d.Data);
        public static Real Min(this Real d1, Real d2) => d1 > d2 ? d2 : d1;
        public static Real Max(this Real d1, Real d2) => d1 < d2 ? d2 : d1;

        public static Real Sin(this Real a) => Math.Sin(a.Data);
        public static Real Cos(this Real a) => Math.Cos(a.Data);
        public static Real Tan(this Real a) => Math.Tan(a.Data);
        public static Real Sinh(this Real a) => Math.Sinh(a.Data);
        public static Real Cosh(this Real a) => Math.Cosh(a.Data);
        public static Real Tanh(this Real a) => Math.Tanh(a.Data);

        public static Real Asin(this Real x) => Math.Asin(x.Data);
        public static Real Acos(this Real x) => Math.Acos(x.Data);
        public static Real Atan(this Real x) => Math.Atan(x.Data);
        public static Real Atan2(this Real y, Real x) => Math.Atan2(y.Data, x.Data);
#if Net5
        public static Real Asinh(this Real x) => Math.Asinh(x.Data);
        public static Real Acosh(this Real x) => Math.Acosh(x.Data);
        public static Real Atanh(this Real x) => Math.Atanh(x.Data);
#endif
    }
}
