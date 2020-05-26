using System;
using System.Collections.Generic;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Helper class auto gerated for generic IList<T> modifying extension
    /// </summary>
    public static partial class MyIList_
    {
        public static IList<T> Negate_<T>(this IList<T> a1) => Func_(a1, Math<T>.Negate);
        public static IList<T> Increase_<T>(this IList<T> a1) => Func_(a1, Math<T>.Increase);
        public static IList<T> Decrease_<T>(this IList<T> a1) => Func_(a1, Math<T>.Decrease);
        public static IList<T> Comp_<T>(this IList<T> a1) => Func_(a1, Math<T>.Comp);
        public static IList<T> Add_<T>(this IList<T> a1, IList<T> a2) => Func_(a1, a2, Math<T>.Add);
        public static IList<T> Add_<T>(this IList<T> a1, T a2) => Func_(a1, a2, Math<T>.Add);
        public static IList<T> Subtract_<T>(this IList<T> a1, IList<T> a2) => Func_(a1, a2, Math<T>.Subtract);
        public static IList<T> Subtract_<T>(this IList<T> a1, T a2) => Func_(a1, a2, Math<T>.Subtract);
        public static IList<T> Multiply_<T>(this IList<T> a1, IList<T> a2) => Func_(a1, a2, Math<T>.Multiply);
        public static IList<T> Multiply_<T>(this IList<T> a1, T a2) => Func_(a1, a2, Math<T>.Multiply);
        public static IList<T> Divide_<T>(this IList<T> a1, IList<T> a2) => Func_(a1, a2, Math<T>.Divide);
        public static IList<T> Divide_<T>(this IList<T> a1, T a2) => Func_(a1, a2, Math<T>.Divide);
        public static IList<T> Modulus_<T>(this IList<T> a1, IList<T> a2) => Func_(a1, a2, Math<T>.Modulus);
        public static IList<T> Modulus_<T>(this IList<T> a1, T a2) => Func_(a1, a2, Math<T>.Modulus);
        public static IList<T> BitAnd_<T>(this IList<T> a1, IList<T> a2) => Func_(a1, a2, Math<T>.BitAnd);
        public static IList<T> BitAnd_<T>(this IList<T> a1, T a2) => Func_(a1, a2, Math<T>.BitAnd);
        public static IList<T> BitOr_<T>(this IList<T> a1, IList<T> a2) => Func_(a1, a2, Math<T>.BitOr);
        public static IList<T> BitOr_<T>(this IList<T> a1, T a2) => Func_(a1, a2, Math<T>.BitOr);
        public static IList<T> BitXOr_<T>(this IList<T> a1, IList<T> a2) => Func_(a1, a2, Math<T>.BitXOr);
        public static IList<T> BitXOr_<T>(this IList<T> a1, T a2) => Func_(a1, a2, Math<T>.BitXOr);
        public static IList<T> LeftShift_<T>(this IList<T> a1, IList<T> a2) => Func_(a1, a2, Math<T>.LeftShift);
        public static IList<T> LeftShift_<T>(this IList<T> a1, T a2) => Func_(a1, a2, Math<T>.LeftShift);
        public static IList<T> RightShif_<T>(this IList<T> a1, IList<T> a2) => Func_(a1, a2, Math<T>.RightShif);
        public static IList<T> RightShif_<T>(this IList<T> a1, T a2) => Func_(a1, a2, Math<T>.RightShif);
        public static IList<T> Sqrt_<T>(this IList<T> a1) => Func_(a1, Math<T>.Sqrt);
        public static IList<T> Cbrt_<T>(this IList<T> a1) => Func_(a1, Math<T>.Cbrt);
        public static IList<T> Exp_<T>(this IList<T> a1) => Func_(a1, Math<T>.Exp);
        public static IList<T> Pow_<T>(this IList<T> a1, IList<T> a2) => Func_(a1, a2, Math<T>.Pow);
        public static IList<T> Pow_<T>(this IList<T> a1, T a2) => Func_(a1, a2, Math<T>.Pow);
        public static IList<T> Log_<T>(this IList<T> a1) => Func_(a1, Math<T>.Log);
        public static IList<T> Log2_<T>(this IList<T> a1) => Func_(a1, Math<T>.Log2);
        public static IList<T> Log10_<T>(this IList<T> a1) => Func_(a1, Math<T>.Log10);
        public static IList<T> Logx_<T>(this IList<T> a1, IList<T> a2) => Func_(a1, a2, Math<T>.Logx);
        public static IList<T> Logx_<T>(this IList<T> a1, T a2) => Func_(a1, a2, Math<T>.Logx);
        public static IList<T> Floor_<T>(this IList<T> a1) => Func_(a1, Math<T>.Floor);
        public static IList<T> Ceiling_<T>(this IList<T> a1) => Func_(a1, Math<T>.Ceiling);
        public static IList<T> Round_<T>(this IList<T> a1) => Func_(a1, Math<T>.Round);
        public static IList<T> Truncate_<T>(this IList<T> a1) => Func_(a1, Math<T>.Truncate);
        public static IList<T> Min_<T>(this IList<T> a1, IList<T> a2) => Func_(a1, a2, Math<T>.Min);
        public static IList<T> Min_<T>(this IList<T> a1, T a2) => Func_(a1, a2, Math<T>.Min);
        public static IList<T> Max_<T>(this IList<T> a1, IList<T> a2) => Func_(a1, a2, Math<T>.Max);
        public static IList<T> Max_<T>(this IList<T> a1, T a2) => Func_(a1, a2, Math<T>.Max);
        public static IList<T> Sin_<T>(this IList<T> a1) => Func_(a1, Math<T>.Sin);
        public static IList<T> Cos_<T>(this IList<T> a1) => Func_(a1, Math<T>.Cos);
        public static IList<T> Tan_<T>(this IList<T> a1) => Func_(a1, Math<T>.Tan);
        public static IList<T> Sinh_<T>(this IList<T> a1) => Func_(a1, Math<T>.Sinh);
        public static IList<T> Cosh_<T>(this IList<T> a1) => Func_(a1, Math<T>.Cosh);
        public static IList<T> Tanh_<T>(this IList<T> a1) => Func_(a1, Math<T>.Tanh);
        public static IList<T> Asin_<T>(this IList<T> a1) => Func_(a1, Math<T>.Asin);
        public static IList<T> Acos_<T>(this IList<T> a1) => Func_(a1, Math<T>.Acos);
        public static IList<T> Atan_<T>(this IList<T> a1) => Func_(a1, Math<T>.Atan);
        public static IList<T> Atan2_<T>(this IList<T> a1, IList<T> a2) => Func_(a1, a2, Math<T>.Atan2);
        public static IList<T> Atan2_<T>(this IList<T> a1, T a2) => Func_(a1, a2, Math<T>.Atan2);
        public static IList<T> Asinh_<T>(this IList<T> a1) => Func_(a1, Math<T>.Asinh);
        public static IList<T> Acosh_<T>(this IList<T> a1) => Func_(a1, Math<T>.Acosh);
        public static IList<T> Atanh_<T>(this IList<T> a1) => Func_(a1, Math<T>.Atanh);
        public static IList<T> SinDeg_<T>(this IList<T> a1) => Func_(a1, Math<T>.SinDeg);
        public static IList<T> CosDeg_<T>(this IList<T> a1) => Func_(a1, Math<T>.CosDeg);
        public static IList<T> TanDeg_<T>(this IList<T> a1) => Func_(a1, Math<T>.TanDeg);
        public static IList<T> SinhDeg_<T>(this IList<T> a1) => Func_(a1, Math<T>.SinhDeg);
        public static IList<T> CoshDeg_<T>(this IList<T> a1) => Func_(a1, Math<T>.CoshDeg);
        public static IList<T> TanhDeg_<T>(this IList<T> a1) => Func_(a1, Math<T>.TanhDeg);
        public static IList<T> AsinDeg_<T>(this IList<T> a1) => Func_(a1, Math<T>.AsinDeg);
        public static IList<T> AcosDeg_<T>(this IList<T> a1) => Func_(a1, Math<T>.AcosDeg);
        public static IList<T> AtanDeg_<T>(this IList<T> a1) => Func_(a1, Math<T>.AtanDeg);
        public static IList<T> AtanDeg2_<T>(this IList<T> a1, IList<T> a2) => Func_(a1, a2, Math<T>.AtanDeg2);
        public static IList<T> AtanDeg2_<T>(this IList<T> a1, T a2) => Func_(a1, a2, Math<T>.AtanDeg2);
        public static IList<T> AsinhDeg_<T>(this IList<T> a1) => Func_(a1, Math<T>.AsinhDeg);
        public static IList<T> AcoshDeg_<T>(this IList<T> a1) => Func_(a1, Math<T>.AcoshDeg);
        public static IList<T> AtanhDeg_<T>(this IList<T> a1) => Func_(a1, Math<T>.AtanhDeg);
    }
}