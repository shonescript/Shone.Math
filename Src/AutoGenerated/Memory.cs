using System;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Helper class auto gerated for generic Memorymodifying extension
    /// </summary>
    public static partial class MyMemory_
    {
        public static Memory<T> Negate_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Negate);
        public static Memory<T> Increase_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Increase);
        public static Memory<T> Decrease_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Decrease);
        public static Memory<T> Comp_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Comp);
        public static Memory<T> Add_<T>(this Memory<T> a1, Memory<T> a2) => Func_(a1, a2, Math<T>.Add);
        public static Memory<T> Add_<T>(this Memory<T> a1, T a2) => Func_(a1, a2, Math<T>.Add);
        public static Memory<T> Subtract_<T>(this Memory<T> a1, Memory<T> a2) => Func_(a1, a2, Math<T>.Subtract);
        public static Memory<T> Subtract_<T>(this Memory<T> a1, T a2) => Func_(a1, a2, Math<T>.Subtract);
        public static Memory<T> Multiply_<T>(this Memory<T> a1, Memory<T> a2) => Func_(a1, a2, Math<T>.Multiply);
        public static Memory<T> Multiply_<T>(this Memory<T> a1, T a2) => Func_(a1, a2, Math<T>.Multiply);
        public static Memory<T> Divide_<T>(this Memory<T> a1, Memory<T> a2) => Func_(a1, a2, Math<T>.Divide);
        public static Memory<T> Divide_<T>(this Memory<T> a1, T a2) => Func_(a1, a2, Math<T>.Divide);
        public static Memory<T> Modulus_<T>(this Memory<T> a1, Memory<T> a2) => Func_(a1, a2, Math<T>.Modulus);
        public static Memory<T> Modulus_<T>(this Memory<T> a1, T a2) => Func_(a1, a2, Math<T>.Modulus);
        public static Memory<T> BitAnd_<T>(this Memory<T> a1, Memory<T> a2) => Func_(a1, a2, Math<T>.BitAnd);
        public static Memory<T> BitAnd_<T>(this Memory<T> a1, T a2) => Func_(a1, a2, Math<T>.BitAnd);
        public static Memory<T> BitOr_<T>(this Memory<T> a1, Memory<T> a2) => Func_(a1, a2, Math<T>.BitOr);
        public static Memory<T> BitOr_<T>(this Memory<T> a1, T a2) => Func_(a1, a2, Math<T>.BitOr);
        public static Memory<T> BitXOr_<T>(this Memory<T> a1, Memory<T> a2) => Func_(a1, a2, Math<T>.BitXOr);
        public static Memory<T> BitXOr_<T>(this Memory<T> a1, T a2) => Func_(a1, a2, Math<T>.BitXOr);
        public static Memory<T> LeftShift_<T>(this Memory<T> a1, Memory<T> a2) => Func_(a1, a2, Math<T>.LeftShift);
        public static Memory<T> LeftShift_<T>(this Memory<T> a1, T a2) => Func_(a1, a2, Math<T>.LeftShift);
        public static Memory<T> RightShif_<T>(this Memory<T> a1, Memory<T> a2) => Func_(a1, a2, Math<T>.RightShif);
        public static Memory<T> RightShif_<T>(this Memory<T> a1, T a2) => Func_(a1, a2, Math<T>.RightShif);
        public static Memory<T> Sqrt_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Sqrt);
        public static Memory<T> Cbrt_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Cbrt);
        public static Memory<T> Exp_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Exp);
        public static Memory<T> Pow_<T>(this Memory<T> a1, Memory<T> a2) => Func_(a1, a2, Math<T>.Pow);
        public static Memory<T> Pow_<T>(this Memory<T> a1, T a2) => Func_(a1, a2, Math<T>.Pow);
        public static Memory<T> Log_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Log);
        public static Memory<T> Log2_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Log2);
        public static Memory<T> Log10_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Log10);
        public static Memory<T> Logx_<T>(this Memory<T> a1, Memory<T> a2) => Func_(a1, a2, Math<T>.Logx);
        public static Memory<T> Logx_<T>(this Memory<T> a1, T a2) => Func_(a1, a2, Math<T>.Logx);
        public static Memory<T> Floor_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Floor);
        public static Memory<T> Ceiling_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Ceiling);
        public static Memory<T> Round_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Round);
        public static Memory<T> Truncate_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Truncate);
        public static Memory<T> Min_<T>(this Memory<T> a1, Memory<T> a2) => Func_(a1, a2, Math<T>.Min);
        public static Memory<T> Min_<T>(this Memory<T> a1, T a2) => Func_(a1, a2, Math<T>.Min);
        public static Memory<T> Max_<T>(this Memory<T> a1, Memory<T> a2) => Func_(a1, a2, Math<T>.Max);
        public static Memory<T> Max_<T>(this Memory<T> a1, T a2) => Func_(a1, a2, Math<T>.Max);
        public static Memory<T> Sin_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Sin);
        public static Memory<T> Cos_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Cos);
        public static Memory<T> Tan_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Tan);
        public static Memory<T> Sinh_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Sinh);
        public static Memory<T> Cosh_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Cosh);
        public static Memory<T> Tanh_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Tanh);
        public static Memory<T> Asin_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Asin);
        public static Memory<T> Acos_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Acos);
        public static Memory<T> Atan_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Atan);
        public static Memory<T> Atan2_<T>(this Memory<T> a1, Memory<T> a2) => Func_(a1, a2, Math<T>.Atan2);
        public static Memory<T> Atan2_<T>(this Memory<T> a1, T a2) => Func_(a1, a2, Math<T>.Atan2);
        public static Memory<T> Asinh_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Asinh);
        public static Memory<T> Acosh_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Acosh);
        public static Memory<T> Atanh_<T>(this Memory<T> a1) => Func_(a1, Math<T>.Atanh);
        public static Memory<T> SinDeg_<T>(this Memory<T> a1) => Func_(a1, Math<T>.SinDeg);
        public static Memory<T> CosDeg_<T>(this Memory<T> a1) => Func_(a1, Math<T>.CosDeg);
        public static Memory<T> TanDeg_<T>(this Memory<T> a1) => Func_(a1, Math<T>.TanDeg);
        public static Memory<T> SinhDeg_<T>(this Memory<T> a1) => Func_(a1, Math<T>.SinhDeg);
        public static Memory<T> CoshDeg_<T>(this Memory<T> a1) => Func_(a1, Math<T>.CoshDeg);
        public static Memory<T> TanhDeg_<T>(this Memory<T> a1) => Func_(a1, Math<T>.TanhDeg);
        public static Memory<T> AsinDeg_<T>(this Memory<T> a1) => Func_(a1, Math<T>.AsinDeg);
        public static Memory<T> AcosDeg_<T>(this Memory<T> a1) => Func_(a1, Math<T>.AcosDeg);
        public static Memory<T> AtanDeg_<T>(this Memory<T> a1) => Func_(a1, Math<T>.AtanDeg);
        public static Memory<T> AtanDeg2_<T>(this Memory<T> a1, Memory<T> a2) => Func_(a1, a2, Math<T>.AtanDeg2);
        public static Memory<T> AtanDeg2_<T>(this Memory<T> a1, T a2) => Func_(a1, a2, Math<T>.AtanDeg2);
        public static Memory<T> AsinhDeg_<T>(this Memory<T> a1) => Func_(a1, Math<T>.AsinhDeg);
        public static Memory<T> AcoshDeg_<T>(this Memory<T> a1) => Func_(a1, Math<T>.AcoshDeg);
        public static Memory<T> AtanhDeg_<T>(this Memory<T> a1) => Func_(a1, Math<T>.AtanhDeg);
    }
}