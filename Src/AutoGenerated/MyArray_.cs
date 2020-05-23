using System;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Helper class auto gerated for generic array T[] modifying extension
    /// </summary>
    public static partial class MyArray_
    {
        public static T[] Negate_<T>(this T[] a1) => Func_(a1, Math<T>.Negate);
        public static T[] Increase_<T>(this T[] a1) => Func_(a1, Math<T>.Increase);
        public static T[] Decrease_<T>(this T[] a1) => Func_(a1, Math<T>.Decrease);
        public static T[] Comp_<T>(this T[] a1) => Func_(a1, Math<T>.Comp);
        public static T[] Add_<T>(this T[] a1, T[] a2) => Func_(a1, a2, Math<T>.Add);
        public static T[] Add_<T>(this T[] a1, T a2) => Func_(a1, a2, Math<T>.Add);
        public static T[] Subtract_<T>(this T[] a1, T[] a2) => Func_(a1, a2, Math<T>.Subtract);
        public static T[] Subtract_<T>(this T[] a1, T a2) => Func_(a1, a2, Math<T>.Subtract);
        public static T[] Multiply_<T>(this T[] a1, T[] a2) => Func_(a1, a2, Math<T>.Multiply);
        public static T[] Multiply_<T>(this T[] a1, T a2) => Func_(a1, a2, Math<T>.Multiply);
        public static T[] Divide_<T>(this T[] a1, T[] a2) => Func_(a1, a2, Math<T>.Divide);
        public static T[] Divide_<T>(this T[] a1, T a2) => Func_(a1, a2, Math<T>.Divide);
        public static T[] Modulus_<T>(this T[] a1, T[] a2) => Func_(a1, a2, Math<T>.Modulus);
        public static T[] Modulus_<T>(this T[] a1, T a2) => Func_(a1, a2, Math<T>.Modulus);
        public static T[] BitAnd_<T>(this T[] a1, T[] a2) => Func_(a1, a2, Math<T>.BitAnd);
        public static T[] BitAnd_<T>(this T[] a1, T a2) => Func_(a1, a2, Math<T>.BitAnd);
        public static T[] BitOr_<T>(this T[] a1, T[] a2) => Func_(a1, a2, Math<T>.BitOr);
        public static T[] BitOr_<T>(this T[] a1, T a2) => Func_(a1, a2, Math<T>.BitOr);
        public static T[] BitXOr_<T>(this T[] a1, T[] a2) => Func_(a1, a2, Math<T>.BitXOr);
        public static T[] BitXOr_<T>(this T[] a1, T a2) => Func_(a1, a2, Math<T>.BitXOr);
        public static T[] LeftShift_<T>(this T[] a1, T[] a2) => Func_(a1, a2, Math<T>.LeftShift);
        public static T[] LeftShift_<T>(this T[] a1, T a2) => Func_(a1, a2, Math<T>.LeftShift);
        public static T[] RightShif_<T>(this T[] a1, T[] a2) => Func_(a1, a2, Math<T>.RightShif);
        public static T[] RightShif_<T>(this T[] a1, T a2) => Func_(a1, a2, Math<T>.RightShif);
        public static T[] Sqrt_<T>(this T[] a1) => Func_(a1, Math<T>.Sqrt);
        public static T[] Cbrt_<T>(this T[] a1) => Func_(a1, Math<T>.Cbrt);
        public static T[] Exp_<T>(this T[] a1) => Func_(a1, Math<T>.Exp);
        public static T[] Pow_<T>(this T[] a1, T[] a2) => Func_(a1, a2, Math<T>.Pow);
        public static T[] Pow_<T>(this T[] a1, T a2) => Func_(a1, a2, Math<T>.Pow);
        public static T[] Log_<T>(this T[] a1) => Func_(a1, Math<T>.Log);
        public static T[] Log2_<T>(this T[] a1) => Func_(a1, Math<T>.Log2);
        public static T[] Log10_<T>(this T[] a1) => Func_(a1, Math<T>.Log10);
        public static T[] Logx_<T>(this T[] a1, T[] a2) => Func_(a1, a2, Math<T>.Logx);
        public static T[] Logx_<T>(this T[] a1, T a2) => Func_(a1, a2, Math<T>.Logx);
        public static T[] Floor_<T>(this T[] a1) => Func_(a1, Math<T>.Floor);
        public static T[] Ceiling_<T>(this T[] a1) => Func_(a1, Math<T>.Ceiling);
        public static T[] Round_<T>(this T[] a1) => Func_(a1, Math<T>.Round);
        public static T[] Truncate_<T>(this T[] a1) => Func_(a1, Math<T>.Truncate);
        public static T[] Min_<T>(this T[] a1, T[] a2) => Func_(a1, a2, Math<T>.Min);
        public static T[] Min_<T>(this T[] a1, T a2) => Func_(a1, a2, Math<T>.Min);
        public static T[] Max_<T>(this T[] a1, T[] a2) => Func_(a1, a2, Math<T>.Max);
        public static T[] Max_<T>(this T[] a1, T a2) => Func_(a1, a2, Math<T>.Max);
        public static T[] Sin_<T>(this T[] a1) => Func_(a1, Math<T>.Sin);
        public static T[] Cos_<T>(this T[] a1) => Func_(a1, Math<T>.Cos);
        public static T[] Tan_<T>(this T[] a1) => Func_(a1, Math<T>.Tan);
        public static T[] Sinh_<T>(this T[] a1) => Func_(a1, Math<T>.Sinh);
        public static T[] Cosh_<T>(this T[] a1) => Func_(a1, Math<T>.Cosh);
        public static T[] Tanh_<T>(this T[] a1) => Func_(a1, Math<T>.Tanh);
        public static T[] Asin_<T>(this T[] a1) => Func_(a1, Math<T>.Asin);
        public static T[] Acos_<T>(this T[] a1) => Func_(a1, Math<T>.Acos);
        public static T[] Atan_<T>(this T[] a1) => Func_(a1, Math<T>.Atan);
        public static T[] Atan2_<T>(this T[] a1, T[] a2) => Func_(a1, a2, Math<T>.Atan2);
        public static T[] Atan2_<T>(this T[] a1, T a2) => Func_(a1, a2, Math<T>.Atan2);
        public static T[] Asinh_<T>(this T[] a1) => Func_(a1, Math<T>.Asinh);
        public static T[] Acosh_<T>(this T[] a1) => Func_(a1, Math<T>.Acosh);
        public static T[] Atanh_<T>(this T[] a1) => Func_(a1, Math<T>.Atanh);
        public static T[] SinDeg_<T>(this T[] a1) => Func_(a1, Math<T>.SinDeg);
        public static T[] CosDeg_<T>(this T[] a1) => Func_(a1, Math<T>.CosDeg);
        public static T[] TanDeg_<T>(this T[] a1) => Func_(a1, Math<T>.TanDeg);
        public static T[] SinhDeg_<T>(this T[] a1) => Func_(a1, Math<T>.SinhDeg);
        public static T[] CoshDeg_<T>(this T[] a1) => Func_(a1, Math<T>.CoshDeg);
        public static T[] TanhDeg_<T>(this T[] a1) => Func_(a1, Math<T>.TanhDeg);
        public static T[] AsinDeg_<T>(this T[] a1) => Func_(a1, Math<T>.AsinDeg);
        public static T[] AcosDeg_<T>(this T[] a1) => Func_(a1, Math<T>.AcosDeg);
        public static T[] AtanDeg_<T>(this T[] a1) => Func_(a1, Math<T>.AtanDeg);
        public static T[] AtanDeg2_<T>(this T[] a1, T[] a2) => Func_(a1, a2, Math<T>.AtanDeg2);
        public static T[] AtanDeg2_<T>(this T[] a1, T a2) => Func_(a1, a2, Math<T>.AtanDeg2);
        public static T[] AsinhDeg_<T>(this T[] a1) => Func_(a1, Math<T>.AsinhDeg);
        public static T[] AcoshDeg_<T>(this T[] a1) => Func_(a1, Math<T>.AcoshDeg);
        public static T[] AtanhDeg_<T>(this T[] a1) => Func_(a1, Math<T>.AtanhDeg);
    }
}