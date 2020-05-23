using System;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Helper class auto gerated for generic number T extension
    /// </summary>
    public static class MyNum
    {
        public static bool IsNormal<T>(this T a1) => Math<T>.IsNormal(a1);
        public static bool IsSubnormal<T>(this T a1) => Math<T>.IsSubnormal(a1);
        public static bool IsFinite<T>(this T a1) => Math<T>.IsFinite(a1);
        public static bool IsNaN<T>(this T a1) => Math<T>.IsNaN(a1);
        public static bool IsInfinity<T>(this T a1) => Math<T>.IsInfinity(a1);
        public static bool IsPositiveInfinity<T>(this T a1) => Math<T>.IsPositiveInfinity(a1);
        public static bool IsNegativeInfinity<T>(this T a1) => Math<T>.IsNegativeInfinity(a1);
        public static bool IsNegative<T>(this T a1) => Math<T>.IsNegative(a1);
        public static T Negate<T>(this T a1) => Math<T>.Negate(a1);
        public static T Increase<T>(this T a1) => Math<T>.Increase(a1);
        public static T Decrease<T>(this T a1) => Math<T>.Decrease(a1);
        public static T Comp<T>(this T a1) => Math<T>.Comp(a1);
        public static bool Not<T>(this T a1) => Math<T>.Not(a1);
        public static T Add<T>(this T a1, T a2) => Math<T>.Add(a1, a2);
        public static T Subtract<T>(this T a1, T a2) => Math<T>.Subtract(a1, a2);
        public static T Multiply<T>(this T a1, T a2) => Math<T>.Multiply(a1, a2);
        public static T Divide<T>(this T a1, T a2) => Math<T>.Divide(a1, a2);
        public static T Modulus<T>(this T a1, T a2) => Math<T>.Modulus(a1, a2);
        public static T BitAnd<T>(this T a1, T a2) => Math<T>.BitAnd(a1, a2);
        public static T BitOr<T>(this T a1, T a2) => Math<T>.BitOr(a1, a2);
        public static T BitXOr<T>(this T a1, T a2) => Math<T>.BitXOr(a1, a2);
        public static T LeftShift<T>(this T a1, T a2) => Math<T>.LeftShift(a1, a2);
        public static T RightShif<T>(this T a1, T a2) => Math<T>.RightShif(a1, a2);
        public static bool And<T>(this T a1, T a2) => Math<T>.And(a1, a2);
        public static bool Or<T>(this T a1, T a2) => Math<T>.Or(a1, a2);
        public static bool LessThan<T>(this T a1, T a2) => Math<T>.LessThan(a1, a2);
        public static bool GreatThan<T>(this T a1, T a2) => Math<T>.GreatThan(a1, a2);
        public static bool LessEqual<T>(this T a1, T a2) => Math<T>.LessEqual(a1, a2);
        public static bool GreatEqual<T>(this T a1, T a2) => Math<T>.GreatEqual(a1, a2);
        public static bool Equal<T>(this T a1, T a2) => Math<T>.Equal(a1, a2);
        public static bool NotEqual<T>(this T a1, T a2) => Math<T>.NotEqual(a1, a2);
        public static bool ToBool<T>(this T a1) => Math<T>.ToBool(a1);
        public static char ToChar<T>(this T a1) => Math<T>.ToChar(a1);
        public static sbyte ToSByte<T>(this T a1) => Math<T>.ToSByte(a1);
        public static byte ToByte<T>(this T a1) => Math<T>.ToByte(a1);
        public static short ToShort<T>(this T a1) => Math<T>.ToShort(a1);
        public static ushort ToUShort<T>(this T a1) => Math<T>.ToUShort(a1);
        public static int ToInt<T>(this T a1) => Math<T>.ToInt(a1);
        public static uint ToUInt<T>(this T a1) => Math<T>.ToUInt(a1);
        public static long ToLong<T>(this T a1) => Math<T>.ToLong(a1);
        public static ulong ToULong<T>(this T a1) => Math<T>.ToULong(a1);
        public static float ToFloat<T>(this T a1) => Math<T>.ToFloat(a1);
        public static double ToDouble<T>(this T a1) => Math<T>.ToDouble(a1);
        public static decimal ToDecimal<T>(this T a1) => Math<T>.ToDecimal(a1);
        public static Real ToReal<T>(this T a1) => Math<T>.ToReal(a1);
        public static int Sign<T>(this T a1) => Math<T>.Sign(a1);
        public static T Sqrt<T>(this T a1) => Math<T>.Sqrt(a1);
        public static T Cbrt<T>(this T a1) => Math<T>.Cbrt(a1);
        public static T Exp<T>(this T a1) => Math<T>.Exp(a1);
        public static T Pow<T>(this T a1, T a2) => Math<T>.Pow(a1, a2);
        public static T Log<T>(this T a1) => Math<T>.Log(a1);
        public static T Log2<T>(this T a1) => Math<T>.Log2(a1);
        public static T Log10<T>(this T a1) => Math<T>.Log10(a1);
        public static T Logx<T>(this T a1, T a2) => Math<T>.Logx(a1, a2);
        public static T Floor<T>(this T a1) => Math<T>.Floor(a1);
        public static T Ceiling<T>(this T a1) => Math<T>.Ceiling(a1);
        public static T Round<T>(this T a1) => Math<T>.Round(a1);
        public static T Truncate<T>(this T a1) => Math<T>.Truncate(a1);
        public static T Min<T>(this T a1, T a2) => Math<T>.Min(a1, a2);
        public static T Max<T>(this T a1, T a2) => Math<T>.Max(a1, a2);
        public static T Sin<T>(this T a1) => Math<T>.Sin(a1);
        public static T Cos<T>(this T a1) => Math<T>.Cos(a1);
        public static T Tan<T>(this T a1) => Math<T>.Tan(a1);
        public static T Sinh<T>(this T a1) => Math<T>.Sinh(a1);
        public static T Cosh<T>(this T a1) => Math<T>.Cosh(a1);
        public static T Tanh<T>(this T a1) => Math<T>.Tanh(a1);
        public static T Asin<T>(this T a1) => Math<T>.Asin(a1);
        public static T Acos<T>(this T a1) => Math<T>.Acos(a1);
        public static T Atan<T>(this T a1) => Math<T>.Atan(a1);
        public static T Atan2<T>(this T a1, T a2) => Math<T>.Atan2(a1, a2);
        public static T Asinh<T>(this T a1) => Math<T>.Asinh(a1);
        public static T Acosh<T>(this T a1) => Math<T>.Acosh(a1);
        public static T Atanh<T>(this T a1) => Math<T>.Atanh(a1);
        public static T SinDeg<T>(this T a1) => Math<T>.SinDeg(a1);
        public static T CosDeg<T>(this T a1) => Math<T>.CosDeg(a1);
        public static T TanDeg<T>(this T a1) => Math<T>.TanDeg(a1);
        public static T SinhDeg<T>(this T a1) => Math<T>.SinhDeg(a1);
        public static T CoshDeg<T>(this T a1) => Math<T>.CoshDeg(a1);
        public static T TanhDeg<T>(this T a1) => Math<T>.TanhDeg(a1);
        public static T AsinDeg<T>(this T a1) => Math<T>.AsinDeg(a1);
        public static T AcosDeg<T>(this T a1) => Math<T>.AcosDeg(a1);
        public static T AtanDeg<T>(this T a1) => Math<T>.AtanDeg(a1);
        public static T AtanDeg2<T>(this T a1, T a2) => Math<T>.AtanDeg2(a1, a2);
        public static T AsinhDeg<T>(this T a1) => Math<T>.AsinhDeg(a1);
        public static T AcoshDeg<T>(this T a1) => Math<T>.AcoshDeg(a1);
        public static T AtanhDeg<T>(this T a1) => Math<T>.AtanhDeg(a1);
    }
}