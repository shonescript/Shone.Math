using System;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Helper class auto gerated for generic ReadOnlySpan extension
    /// </summary>
    public static partial class MyReadOnlySpan
    {
        public static T[] Negate<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Negate);
        public static T[] Increase<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Increase);
        public static T[] Decrease<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Decrease);
        public static T[] Comp<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Comp);
        public static T[] Add<T>(this ReadOnlySpan<T> a1, ReadOnlySpan<T> a2) where T : unmanaged => Func(a1, a2, Math<T>.Add);
        public static T[] Add<T>(this ReadOnlySpan<T> a1, T a2) where T : unmanaged => Func(a1, a2, Math<T>.Add);
        public static T[] Subtract<T>(this ReadOnlySpan<T> a1, ReadOnlySpan<T> a2) where T : unmanaged => Func(a1, a2, Math<T>.Subtract);
        public static T[] Subtract<T>(this ReadOnlySpan<T> a1, T a2) where T : unmanaged => Func(a1, a2, Math<T>.Subtract);
        public static T[] Multiply<T>(this ReadOnlySpan<T> a1, ReadOnlySpan<T> a2) where T : unmanaged => Func(a1, a2, Math<T>.Multiply);
        public static T[] Multiply<T>(this ReadOnlySpan<T> a1, T a2) where T : unmanaged => Func(a1, a2, Math<T>.Multiply);
        public static T[] Divide<T>(this ReadOnlySpan<T> a1, ReadOnlySpan<T> a2) where T : unmanaged => Func(a1, a2, Math<T>.Divide);
        public static T[] Divide<T>(this ReadOnlySpan<T> a1, T a2) where T : unmanaged => Func(a1, a2, Math<T>.Divide);
        public static T[] Modulus<T>(this ReadOnlySpan<T> a1, ReadOnlySpan<T> a2) where T : unmanaged => Func(a1, a2, Math<T>.Modulus);
        public static T[] Modulus<T>(this ReadOnlySpan<T> a1, T a2) where T : unmanaged => Func(a1, a2, Math<T>.Modulus);
        public static T[] BitAnd<T>(this ReadOnlySpan<T> a1, ReadOnlySpan<T> a2) where T : unmanaged => Func(a1, a2, Math<T>.BitAnd);
        public static T[] BitAnd<T>(this ReadOnlySpan<T> a1, T a2) where T : unmanaged => Func(a1, a2, Math<T>.BitAnd);
        public static T[] BitOr<T>(this ReadOnlySpan<T> a1, ReadOnlySpan<T> a2) where T : unmanaged => Func(a1, a2, Math<T>.BitOr);
        public static T[] BitOr<T>(this ReadOnlySpan<T> a1, T a2) where T : unmanaged => Func(a1, a2, Math<T>.BitOr);
        public static T[] BitXOr<T>(this ReadOnlySpan<T> a1, ReadOnlySpan<T> a2) where T : unmanaged => Func(a1, a2, Math<T>.BitXOr);
        public static T[] BitXOr<T>(this ReadOnlySpan<T> a1, T a2) where T : unmanaged => Func(a1, a2, Math<T>.BitXOr);
        public static T[] LeftShift<T>(this ReadOnlySpan<T> a1, ReadOnlySpan<T> a2) where T : unmanaged => Func(a1, a2, Math<T>.LeftShift);
        public static T[] LeftShift<T>(this ReadOnlySpan<T> a1, T a2) where T : unmanaged => Func(a1, a2, Math<T>.LeftShift);
        public static T[] RightShif<T>(this ReadOnlySpan<T> a1, ReadOnlySpan<T> a2) where T : unmanaged => Func(a1, a2, Math<T>.RightShif);
        public static T[] RightShif<T>(this ReadOnlySpan<T> a1, T a2) where T : unmanaged => Func(a1, a2, Math<T>.RightShif);
        public static T[] Sqrt<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Sqrt);
        public static T[] Cbrt<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Cbrt);
        public static T[] Exp<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Exp);
        public static T[] Pow<T>(this ReadOnlySpan<T> a1, ReadOnlySpan<T> a2) where T : unmanaged => Func(a1, a2, Math<T>.Pow);
        public static T[] Pow<T>(this ReadOnlySpan<T> a1, T a2) where T : unmanaged => Func(a1, a2, Math<T>.Pow);
        public static T[] Log<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Log);
        public static T[] Log2<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Log2);
        public static T[] Log10<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Log10);
        public static T[] Logx<T>(this ReadOnlySpan<T> a1, ReadOnlySpan<T> a2) where T : unmanaged => Func(a1, a2, Math<T>.Logx);
        public static T[] Logx<T>(this ReadOnlySpan<T> a1, T a2) where T : unmanaged => Func(a1, a2, Math<T>.Logx);
        public static T[] Floor<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Floor);
        public static T[] Ceiling<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Ceiling);
        public static T[] Round<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Round);
        public static T[] Truncate<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Truncate);
        public static T[] Min<T>(this ReadOnlySpan<T> a1, ReadOnlySpan<T> a2) where T : unmanaged => Func(a1, a2, Math<T>.Min);
        public static T[] Min<T>(this ReadOnlySpan<T> a1, T a2) where T : unmanaged => Func(a1, a2, Math<T>.Min);
        public static T[] Max<T>(this ReadOnlySpan<T> a1, ReadOnlySpan<T> a2) where T : unmanaged => Func(a1, a2, Math<T>.Max);
        public static T[] Max<T>(this ReadOnlySpan<T> a1, T a2) where T : unmanaged => Func(a1, a2, Math<T>.Max);
        public static T[] Sin<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Sin);
        public static T[] Cos<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Cos);
        public static T[] Tan<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Tan);
        public static T[] Sinh<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Sinh);
        public static T[] Cosh<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Cosh);
        public static T[] Tanh<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Tanh);
        public static T[] Asin<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Asin);
        public static T[] Acos<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Acos);
        public static T[] Atan<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Atan);
        public static T[] Atan2<T>(this ReadOnlySpan<T> a1, ReadOnlySpan<T> a2) where T : unmanaged => Func(a1, a2, Math<T>.Atan2);
        public static T[] Atan2<T>(this ReadOnlySpan<T> a1, T a2) where T : unmanaged => Func(a1, a2, Math<T>.Atan2);
        public static T[] Asinh<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Asinh);
        public static T[] Acosh<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Acosh);
        public static T[] Atanh<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.Atanh);
        public static T[] SinDeg<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.SinDeg);
        public static T[] CosDeg<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.CosDeg);
        public static T[] TanDeg<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.TanDeg);
        public static T[] SinhDeg<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.SinhDeg);
        public static T[] CoshDeg<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.CoshDeg);
        public static T[] TanhDeg<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.TanhDeg);
        public static T[] AsinDeg<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.AsinDeg);
        public static T[] AcosDeg<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.AcosDeg);
        public static T[] AtanDeg<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.AtanDeg);
        public static T[] AtanDeg2<T>(this ReadOnlySpan<T> a1, ReadOnlySpan<T> a2) where T : unmanaged => Func(a1, a2, Math<T>.AtanDeg2);
        public static T[] AtanDeg2<T>(this ReadOnlySpan<T> a1, T a2) where T : unmanaged => Func(a1, a2, Math<T>.AtanDeg2);
        public static T[] AsinhDeg<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.AsinhDeg);
        public static T[] AcoshDeg<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.AcoshDeg);
        public static T[] AtanhDeg<T>(this ReadOnlySpan<T> a1) where T : unmanaged => Func(a1, Math<T>.AtanhDeg);
    }
}