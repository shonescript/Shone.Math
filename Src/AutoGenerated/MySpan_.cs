using System;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Helper class auto gerated for generic Spanmodifying extension
    /// </summary>
    public static partial class MySpan_
    {
        public static Span<T> Negate_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Negate);
        public static Span<T> Increase_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Increase);
        public static Span<T> Decrease_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Decrease);
        public static Span<T> Comp_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Comp);
        public static Span<T> Add_<T>(this Span<T> a1, Span<T> a2) where T : unmanaged => Func_(a1, a2, Math<T>.Add);
        public static Span<T> Add_<T>(this Span<T> a1, T a2) where T : unmanaged => Func_(a1, a2, Math<T>.Add);
        public static Span<T> Subtract_<T>(this Span<T> a1, Span<T> a2) where T : unmanaged => Func_(a1, a2, Math<T>.Subtract);
        public static Span<T> Subtract_<T>(this Span<T> a1, T a2) where T : unmanaged => Func_(a1, a2, Math<T>.Subtract);
        public static Span<T> Multiply_<T>(this Span<T> a1, Span<T> a2) where T : unmanaged => Func_(a1, a2, Math<T>.Multiply);
        public static Span<T> Multiply_<T>(this Span<T> a1, T a2) where T : unmanaged => Func_(a1, a2, Math<T>.Multiply);
        public static Span<T> Divide_<T>(this Span<T> a1, Span<T> a2) where T : unmanaged => Func_(a1, a2, Math<T>.Divide);
        public static Span<T> Divide_<T>(this Span<T> a1, T a2) where T : unmanaged => Func_(a1, a2, Math<T>.Divide);
        public static Span<T> Modulus_<T>(this Span<T> a1, Span<T> a2) where T : unmanaged => Func_(a1, a2, Math<T>.Modulus);
        public static Span<T> Modulus_<T>(this Span<T> a1, T a2) where T : unmanaged => Func_(a1, a2, Math<T>.Modulus);
        public static Span<T> BitAnd_<T>(this Span<T> a1, Span<T> a2) where T : unmanaged => Func_(a1, a2, Math<T>.BitAnd);
        public static Span<T> BitAnd_<T>(this Span<T> a1, T a2) where T : unmanaged => Func_(a1, a2, Math<T>.BitAnd);
        public static Span<T> BitOr_<T>(this Span<T> a1, Span<T> a2) where T : unmanaged => Func_(a1, a2, Math<T>.BitOr);
        public static Span<T> BitOr_<T>(this Span<T> a1, T a2) where T : unmanaged => Func_(a1, a2, Math<T>.BitOr);
        public static Span<T> BitXOr_<T>(this Span<T> a1, Span<T> a2) where T : unmanaged => Func_(a1, a2, Math<T>.BitXOr);
        public static Span<T> BitXOr_<T>(this Span<T> a1, T a2) where T : unmanaged => Func_(a1, a2, Math<T>.BitXOr);
        public static Span<T> LeftShift_<T>(this Span<T> a1, Span<T> a2) where T : unmanaged => Func_(a1, a2, Math<T>.LeftShift);
        public static Span<T> LeftShift_<T>(this Span<T> a1, T a2) where T : unmanaged => Func_(a1, a2, Math<T>.LeftShift);
        public static Span<T> RightShif_<T>(this Span<T> a1, Span<T> a2) where T : unmanaged => Func_(a1, a2, Math<T>.RightShif);
        public static Span<T> RightShif_<T>(this Span<T> a1, T a2) where T : unmanaged => Func_(a1, a2, Math<T>.RightShif);
        public static Span<T> Sqrt_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Sqrt);
        public static Span<T> Cbrt_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Cbrt);
        public static Span<T> Exp_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Exp);
        public static Span<T> Pow_<T>(this Span<T> a1, Span<T> a2) where T : unmanaged => Func_(a1, a2, Math<T>.Pow);
        public static Span<T> Pow_<T>(this Span<T> a1, T a2) where T : unmanaged => Func_(a1, a2, Math<T>.Pow);
        public static Span<T> Log_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Log);
        public static Span<T> Log2_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Log2);
        public static Span<T> Log10_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Log10);
        public static Span<T> Logx_<T>(this Span<T> a1, Span<T> a2) where T : unmanaged => Func_(a1, a2, Math<T>.Logx);
        public static Span<T> Logx_<T>(this Span<T> a1, T a2) where T : unmanaged => Func_(a1, a2, Math<T>.Logx);
        public static Span<T> Floor_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Floor);
        public static Span<T> Ceiling_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Ceiling);
        public static Span<T> Round_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Round);
        public static Span<T> Truncate_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Truncate);
        public static Span<T> Min_<T>(this Span<T> a1, Span<T> a2) where T : unmanaged => Func_(a1, a2, Math<T>.Min);
        public static Span<T> Min_<T>(this Span<T> a1, T a2) where T : unmanaged => Func_(a1, a2, Math<T>.Min);
        public static Span<T> Max_<T>(this Span<T> a1, Span<T> a2) where T : unmanaged => Func_(a1, a2, Math<T>.Max);
        public static Span<T> Max_<T>(this Span<T> a1, T a2) where T : unmanaged => Func_(a1, a2, Math<T>.Max);
        public static Span<T> Sin_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Sin);
        public static Span<T> Cos_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Cos);
        public static Span<T> Tan_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Tan);
        public static Span<T> Sinh_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Sinh);
        public static Span<T> Cosh_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Cosh);
        public static Span<T> Tanh_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Tanh);
        public static Span<T> Asin_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Asin);
        public static Span<T> Acos_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Acos);
        public static Span<T> Atan_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Atan);
        public static Span<T> Atan2_<T>(this Span<T> a1, Span<T> a2) where T : unmanaged => Func_(a1, a2, Math<T>.Atan2);
        public static Span<T> Atan2_<T>(this Span<T> a1, T a2) where T : unmanaged => Func_(a1, a2, Math<T>.Atan2);
        public static Span<T> Asinh_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Asinh);
        public static Span<T> Acosh_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Acosh);
        public static Span<T> Atanh_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.Atanh);
        public static Span<T> SinDeg_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.SinDeg);
        public static Span<T> CosDeg_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.CosDeg);
        public static Span<T> TanDeg_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.TanDeg);
        public static Span<T> SinhDeg_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.SinhDeg);
        public static Span<T> CoshDeg_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.CoshDeg);
        public static Span<T> TanhDeg_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.TanhDeg);
        public static Span<T> AsinDeg_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.AsinDeg);
        public static Span<T> AcosDeg_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.AcosDeg);
        public static Span<T> AtanDeg_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.AtanDeg);
        public static Span<T> AtanDeg2_<T>(this Span<T> a1, Span<T> a2) where T : unmanaged => Func_(a1, a2, Math<T>.AtanDeg2);
        public static Span<T> AtanDeg2_<T>(this Span<T> a1, T a2) where T : unmanaged => Func_(a1, a2, Math<T>.AtanDeg2);
        public static Span<T> AsinhDeg_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.AsinhDeg);
        public static Span<T> AcoshDeg_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.AcoshDeg);
        public static Span<T> AtanhDeg_<T>(this Span<T> a1) where T : unmanaged => Func_(a1, Math<T>.AtanhDeg);
    }
}