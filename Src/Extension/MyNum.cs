
using System;

namespace Shone
{
    public static class MyNum
    {
        public static Boolean IsNormal<T>(this T a1) => Math<T>.IsNormal(a1);
        public static Boolean IsSubnormal<T>(this T a1) => Math<T>.IsSubnormal(a1);
        public static Boolean IsFinite<T>(this T a1) => Math<T>.IsFinite(a1);
        public static Boolean IsInfinity<T>(this T a1) => Math<T>.IsInfinity(a1);
        public static Boolean IsNaN<T>(this T a1) => Math<T>.IsNaN(a1);
        public static Boolean IsNegative<T>(this T a1) => Math<T>.IsNegative(a1);
        public static Boolean IsNegativeInfinity<T>(this T a1) => Math<T>.IsNegativeInfinity(a1);
        public static Boolean IsPositiveInfinity<T>(this T a1) => Math<T>.IsPositiveInfinity(a1);
        public static T Negate<T>(this T a1) => Math<T>.Negate(a1);
        public static T Increase<T>(this T a1) => Math<T>.Increase(a1);
        public static T Decrease<T>(this T a1) => Math<T>.Decrease(a1);
        public static T Comp<T>(this T a1) => Math<T>.Comp(a1);
        public static Boolean Not<T>(this T a1) => Math<T>.Not(a1);
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
        public static Boolean And<T>(this T a1, T a2) => Math<T>.And(a1, a2);
        public static Boolean Or<T>(this T a1, T a2) => Math<T>.Or(a1, a2);
        public static Boolean LessThan<T>(this T a1, T a2) => Math<T>.LessThan(a1, a2);
        public static Boolean GreatThan<T>(this T a1, T a2) => Math<T>.GreatThan(a1, a2);
        public static Boolean LessEqual<T>(this T a1, T a2) => Math<T>.LessEqual(a1, a2);
        public static Boolean GreatEqual<T>(this T a1, T a2) => Math<T>.GreatEqual(a1, a2);
        public static Boolean Equal<T>(this T a1, T a2) => Math<T>.Equal(a1, a2);
        public static Boolean NotEqual<T>(this T a1, T a2) => Math<T>.NotEqual(a1, a2);
        public static Boolean ToBoolean<T>(this T a1) => Math<T>.ToBool(a1);
        public static Char ToChar<T>(this T a1) => Math<T>.ToChar(a1);
        public static SByte ToSByte<T>(this T a1) => Math<T>.ToSByte(a1);
        public static Byte ToByte<T>(this T a1) => Math<T>.ToByte(a1);
        public static Int16 ToShort<T>(this T a1) => Math<T>.ToShort(a1);
        public static UInt16 ToUShort<T>(this T a1) => Math<T>.ToUShort(a1);
        public static Int32 ToInt<T>(this T a1) => Math<T>.ToInt(a1);
        public static UInt32 ToUInt<T>(this T a1) => Math<T>.ToUInt(a1);
        public static Int64 ToLong<T>(this T a1) => Math<T>.ToLong(a1);
        public static UInt64 ToULong<T>(this T a1) => Math<T>.ToULong(a1);
        public static Single ToFloat<T>(this T a1) => Math<T>.ToFloat(a1);
        public static Double ToDouble<T>(this T a1) => Math<T>.ToDouble(a1);
        public static Decimal ToDecimal<T>(this T a1) => Math<T>.ToDecimal(a1);
        public static T Parse<T>(this String a1) => Math<T>.Parse(a1);
        public static Int32 Sign<T>(this T a1) => Math<T>.Sign(a1);
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
 #if Net5
        public static T Asinh<T>(this T a1) => Math<T>.Asinh(a1);
        public static T Acosh<T>(this T a1) => Math<T>.Acosh(a1);
        public static T Atanh<T>(this T a1) => Math<T>.Atanh(a1);
#endif
    }
}