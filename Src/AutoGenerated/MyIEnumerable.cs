using System;
using System.Collections.Generic;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Helper class auto gerated for generic IEnumerable<T> extension
    /// </summary>
    public static partial class MyIEnumerable
    {
        public static IEnumerable<Boolean> IsNormal<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.IsNormal);
        public static IEnumerable<Boolean> IsSubnormal<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.IsSubnormal);
        public static IEnumerable<Boolean> IsFinite<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.IsFinite);
        public static IEnumerable<Boolean> IsNaN<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.IsNaN);
        public static IEnumerable<Boolean> IsInfinity<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.IsInfinity);
        public static IEnumerable<Boolean> IsPositiveInfinity<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.IsPositiveInfinity);
        public static IEnumerable<Boolean> IsNegativeInfinity<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.IsNegativeInfinity);
        public static IEnumerable<Boolean> IsNegative<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.IsNegative);
        public static IEnumerable<T> Negate<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Negate);
        public static IEnumerable<T> Increase<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Increase);
        public static IEnumerable<T> Decrease<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Decrease);
        public static IEnumerable<T> Comp<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Comp);
        public static IEnumerable<Boolean> Not<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Not);
        public static IEnumerable<T> Add<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.Add);
        public static IEnumerable<T> Subtract<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.Subtract);
        public static IEnumerable<T> Multiply<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.Multiply);
        public static IEnumerable<T> Divide<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.Divide);
        public static IEnumerable<T> Modulus<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.Modulus);
        public static IEnumerable<T> BitAnd<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.BitAnd);
        public static IEnumerable<T> BitOr<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.BitOr);
        public static IEnumerable<T> BitXOr<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.BitXOr);
        public static IEnumerable<T> LeftShift<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.LeftShift);
        public static IEnumerable<T> RightShif<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.RightShif);
        public static IEnumerable<Boolean> And<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.And);
        public static IEnumerable<Boolean> Or<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.Or);
        public static IEnumerable<Boolean> LessThan<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.LessThan);
        public static IEnumerable<Boolean> GreatThan<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.GreatThan);
        public static IEnumerable<Boolean> LessEqual<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.LessEqual);
        public static IEnumerable<Boolean> GreatEqual<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.GreatEqual);
        public static IEnumerable<Boolean> Equal<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.Equal);
        public static IEnumerable<Boolean> NotEqual<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.NotEqual);
        public static IEnumerable<Boolean> ToBool<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.ToBool);
        public static IEnumerable<Char> ToChar<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.ToChar);
        public static IEnumerable<SByte> ToSByte<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.ToSByte);
        public static IEnumerable<Byte> ToByte<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.ToByte);
        public static IEnumerable<Int16> ToShort<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.ToShort);
        public static IEnumerable<UInt16> ToUShort<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.ToUShort);
        public static IEnumerable<Int32> ToInt<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.ToInt);
        public static IEnumerable<UInt32> ToUInt<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.ToUInt);
        public static IEnumerable<Int64> ToLong<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.ToLong);
        public static IEnumerable<UInt64> ToULong<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.ToULong);
        public static IEnumerable<Single> ToFloat<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.ToFloat);
        public static IEnumerable<Double> ToDouble<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.ToDouble);
        public static IEnumerable<Decimal> ToDecimal<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.ToDecimal);
        public static IEnumerable<Real> ToReal<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.ToReal);
        public static IEnumerable<T> Parse<T>(this IEnumerable<String> a1) => Map(a1, Math<T>.Parse);
        public static IEnumerable<Int32> Sign<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Sign);
        public static IEnumerable<T> Sqrt<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Sqrt);
        public static IEnumerable<T> Cbrt<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Cbrt);
        public static IEnumerable<T> Exp<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Exp);
        public static IEnumerable<T> Pow<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.Pow);
        public static IEnumerable<T> Log<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Log);
        public static IEnumerable<T> Log2<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Log2);
        public static IEnumerable<T> Log10<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Log10);
        public static IEnumerable<T> Logx<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.Logx);
        public static IEnumerable<T> Floor<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Floor);
        public static IEnumerable<T> Ceiling<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Ceiling);
        public static IEnumerable<T> Round<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Round);
        public static IEnumerable<T> Truncate<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Truncate);
        public static IEnumerable<T> Min<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.Min);
        public static IEnumerable<T> Max<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.Max);
        public static IEnumerable<T> Sin<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Sin);
        public static IEnumerable<T> Cos<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Cos);
        public static IEnumerable<T> Tan<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Tan);
        public static IEnumerable<T> Sinh<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Sinh);
        public static IEnumerable<T> Cosh<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Cosh);
        public static IEnumerable<T> Tanh<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Tanh);
        public static IEnumerable<T> Asin<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Asin);
        public static IEnumerable<T> Acos<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Acos);
        public static IEnumerable<T> Atan<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Atan);
        public static IEnumerable<T> Atan2<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.Atan2);
#if Net5
        public static IEnumerable<T> Asinh<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Asinh);
        public static IEnumerable<T> Acosh<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Acosh);
        public static IEnumerable<T> Atanh<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.Atanh);
#endif
        public static IEnumerable<T> SinDeg<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.SinDeg);
        public static IEnumerable<T> CosDeg<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.CosDeg);
        public static IEnumerable<T> TanDeg<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.TanDeg);
        public static IEnumerable<T> SinhDeg<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.SinhDeg);
        public static IEnumerable<T> CoshDeg<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.CoshDeg);
        public static IEnumerable<T> TanhDeg<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.TanhDeg);
        public static IEnumerable<T> AsinDeg<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.AsinDeg);
        public static IEnumerable<T> AcosDeg<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.AcosDeg);
        public static IEnumerable<T> AtanDeg<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.AtanDeg);
        public static IEnumerable<T> AtanDeg2<T>(this IEnumerable<T> a1, T a2) => Map(a1, a2, Math<T>.AtanDeg2);
#if Net5
        public static IEnumerable<T> AsinhDeg<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.AsinhDeg);
        public static IEnumerable<T> AcoshDeg<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.AcoshDeg);
        public static IEnumerable<T> AtanhDeg<T>(this IEnumerable<T> a1) => Map(a1, Math<T>.AtanhDeg);
#endif

    }
}