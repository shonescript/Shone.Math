
using System;

namespace Shone
{
    public static class MyArray
    {
        public static T1[] Map<T, T1>(this T[] a1, Func<T, T1> func)
        {
            var n = a1.Length;
            var result = new T1[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = func(a1[i]);
            }
            return result;
        }

        public static T1[] Map<T, T1>(this T[] a1, T a2, Func<T, T, T1> func)
        {
            var n = a1.Length;
            var result = new T1[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = func(a1[i], a2);
            }
            return result;
        }

        public static T1[] Map<T, T1>(this T[] a1, T[] a2, Func<T, T, T1> func)
        {
            var n = a1.Length;
            var result = new T1[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = func(a1[i], a2[i]);
            }
            return result;
        }
        public static Boolean[] IsNormal<T>(this T[] a1) => Map(a1, Math<T>.IsNormal);
        public static Boolean[] IsSubnormal<T>(this T[] a1) => Map(a1, Math<T>.IsSubnormal);
        public static Boolean[] IsFinite<T>(this T[] a1) => Map(a1, Math<T>.IsFinite);
        public static Boolean[] IsInfinity<T>(this T[] a1) => Map(a1, Math<T>.IsInfinity);
        public static Boolean[] IsNaN<T>(this T[] a1) => Map(a1, Math<T>.IsNaN);
        public static Boolean[] IsNegative<T>(this T[] a1) => Map(a1, Math<T>.IsNegative);
        public static Boolean[] IsNegativeInfinity<T>(this T[] a1) => Map(a1, Math<T>.IsNegativeInfinity);
        public static Boolean[] IsPositiveInfinity<T>(this T[] a1) => Map(a1, Math<T>.IsPositiveInfinity);
        public static T[] Negate<T>(this T[] a1) => Map(a1, Math<T>.Negate);
        public static T[] Increase<T>(this T[] a1) => Map(a1, Math<T>.Increase);
        public static T[] Decrease<T>(this T[] a1) => Map(a1, Math<T>.Decrease);
        public static T[] Comp<T>(this T[] a1) => Map(a1, Math<T>.Comp);
        public static Boolean[] Not<T>(this T[] a1) => Map(a1, Math<T>.Not);
        public static T[] Add<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.Add);
        public static T[] Add<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.Add);
        public static T[] Subtract<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.Subtract);
        public static T[] Subtract<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.Subtract);
        public static T[] Multiply<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.Multiply);
        public static T[] Multiply<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.Multiply);
        public static T[] Divide<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.Divide);
        public static T[] Divide<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.Divide);
        public static T[] Modulus<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.Modulus);
        public static T[] Modulus<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.Modulus);
        public static T[] BitAnd<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.BitAnd);
        public static T[] BitAnd<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.BitAnd);
        public static T[] BitOr<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.BitOr);
        public static T[] BitOr<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.BitOr);
        public static T[] BitXOr<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.BitXOr);
        public static T[] BitXOr<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.BitXOr);
        public static T[] LeftShift<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.LeftShift);
        public static T[] LeftShift<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.LeftShift);
        public static T[] RightShif<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.RightShif);
        public static T[] RightShif<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.RightShif);
        public static Boolean[] And<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.And);
        public static Boolean[] And<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.And);
        public static Boolean[] Or<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.Or);
        public static Boolean[] Or<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.Or);
        public static Boolean[] LessThan<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.LessThan);
        public static Boolean[] LessThan<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.LessThan);
        public static Boolean[] GreatThan<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.GreatThan);
        public static Boolean[] GreatThan<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.GreatThan);
        public static Boolean[] LessEqual<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.LessEqual);
        public static Boolean[] LessEqual<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.LessEqual);
        public static Boolean[] GreatEqual<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.GreatEqual);
        public static Boolean[] GreatEqual<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.GreatEqual);
        public static Boolean[] Equal<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.Equal);
        public static Boolean[] Equal<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.Equal);
        public static Boolean[] NotEqual<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.NotEqual);
        public static Boolean[] NotEqual<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.NotEqual);
        public static T[] FromBoolean<T>(this Boolean[] a1) => Map(a1, Math<T>.FromBoolean);
        public static T[] FromChar<T>(this Char[] a1) => Map(a1, Math<T>.FromChar);
        public static T[] FromSByte<T>(this SByte[] a1) => Map(a1, Math<T>.FromSByte);
        public static T[] FromByte<T>(this Byte[] a1) => Map(a1, Math<T>.FromByte);
        public static T[] FromInt16<T>(this Int16[] a1) => Map(a1, Math<T>.FromInt16);
        public static T[] FromUInt16<T>(this UInt16[] a1) => Map(a1, Math<T>.FromUInt16);
        public static T[] FromInt32<T>(this Int32[] a1) => Map(a1, Math<T>.FromInt32);
        public static T[] FromUInt32<T>(this UInt32[] a1) => Map(a1, Math<T>.FromUInt32);
        public static T[] FromInt64<T>(this Int64[] a1) => Map(a1, Math<T>.FromInt64);
        public static T[] FromUInt64<T>(this UInt64[] a1) => Map(a1, Math<T>.FromUInt64);
        public static T[] FromSingle<T>(this Single[] a1) => Map(a1, Math<T>.FromSingle);
        public static T[] FromDouble<T>(this Double[] a1) => Map(a1, Math<T>.FromDouble);
        public static T[] FromDecimal<T>(this Decimal[] a1) => Map(a1, Math<T>.FromDecimal);
        public static Boolean[] ToBoolean<T>(this T[] a1) => Map(a1, Math<T>.ToBoolean);
        public static Char[] ToChar<T>(this T[] a1) => Map(a1, Math<T>.ToChar);
        public static SByte[] ToSByte<T>(this T[] a1) => Map(a1, Math<T>.ToSByte);
        public static Byte[] ToByte<T>(this T[] a1) => Map(a1, Math<T>.ToByte);
        public static Int16[] ToInt16<T>(this T[] a1) => Map(a1, Math<T>.ToInt16);
        public static UInt16[] ToUInt16<T>(this T[] a1) => Map(a1, Math<T>.ToUInt16);
        public static Int32[] ToInt32<T>(this T[] a1) => Map(a1, Math<T>.ToInt32);
        public static UInt32[] ToUInt32<T>(this T[] a1) => Map(a1, Math<T>.ToUInt32);
        public static Int64[] ToInt64<T>(this T[] a1) => Map(a1, Math<T>.ToInt64);
        public static UInt64[] ToUInt64<T>(this T[] a1) => Map(a1, Math<T>.ToUInt64);
        public static Single[] ToSingle<T>(this T[] a1) => Map(a1, Math<T>.ToSingle);
        public static Double[] ToDouble<T>(this T[] a1) => Map(a1, Math<T>.ToDouble);
        public static Decimal[] ToDecimal<T>(this T[] a1) => Map(a1, Math<T>.ToDecimal);
        public static T[] Parse<T>(this String[] a1) => Map(a1, Math<T>.Parse);
        public static Int32[] Sign<T>(this T[] a1) => Map(a1, Math<T>.Sign);
        public static T[] Sqrt<T>(this T[] a1) => Map(a1, Math<T>.Sqrt);
        public static T[] Cbrt<T>(this T[] a1) => Map(a1, Math<T>.Cbrt);
        public static T[] Exp<T>(this T[] a1) => Map(a1, Math<T>.Exp);
        public static T[] Pow<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.Pow);
        public static T[] Pow<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.Pow);
        public static T[] Log<T>(this T[] a1) => Map(a1, Math<T>.Log);
        public static T[] Log2<T>(this T[] a1) => Map(a1, Math<T>.Log2);
        public static T[] Log10<T>(this T[] a1) => Map(a1, Math<T>.Log10);
        public static T[] Logx<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.Logx);
        public static T[] Logx<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.Logx);
        public static T[] Floor<T>(this T[] a1) => Map(a1, Math<T>.Floor);
        public static T[] Ceiling<T>(this T[] a1) => Map(a1, Math<T>.Ceiling);
        public static T[] Round<T>(this T[] a1) => Map(a1, Math<T>.Round);
        public static T[] Truncate<T>(this T[] a1) => Map(a1, Math<T>.Truncate);
        public static T[] Min<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.Min);
        public static T[] Min<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.Min);
        public static T[] Max<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.Max);
        public static T[] Max<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.Max);
        public static T[] Sin<T>(this T[] a1) => Map(a1, Math<T>.Sin);
        public static T[] Cos<T>(this T[] a1) => Map(a1, Math<T>.Cos);
        public static T[] Tan<T>(this T[] a1) => Map(a1, Math<T>.Tan);
        public static T[] Sinh<T>(this T[] a1) => Map(a1, Math<T>.Sinh);
        public static T[] Cosh<T>(this T[] a1) => Map(a1, Math<T>.Cosh);
        public static T[] Tanh<T>(this T[] a1) => Map(a1, Math<T>.Tanh);
        public static T[] Asin<T>(this T[] a1) => Map(a1, Math<T>.Asin);
        public static T[] Acos<T>(this T[] a1) => Map(a1, Math<T>.Acos);
        public static T[] Atan<T>(this T[] a1) => Map(a1, Math<T>.Atan);
        public static T[] Atan2<T>(this T[] a1, T[] a2) => Map(a1, a2, Math<T>.Atan2);
        public static T[] Atan2<T>(this T[] a1, T a2) => Map(a1, a2, Math<T>.Atan2);
#if Net5
        public static T[] Asinh<T>(this T[] a1) => Map(a1, Math<T>.Asinh);
        public static T[] Acosh<T>(this T[] a1) => Map(a1, Math<T>.Acosh);
        public static T[] Atanh<T>(this T[] a1) => Map(a1, Math<T>.Atanh);
#endif
    }
}