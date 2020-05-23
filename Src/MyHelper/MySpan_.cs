using System;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Helper class for generic Span<T> modifying extension
    /// </summary>
    public static partial class MySpan_
    {
        public static Span<T> Func_<T>(this Span<T> a1, Func<T, T> func)
        {
            for (int i = 0; i < a1.Length; i++)
            {
                a1[i] = func(a1[i]);
            }
            return a1;
        }
        public static Span<T> Func_<T>(this Span<T> a1, T a2, Func<T, T, T> func)
        {
            for (int i = 0; i < a1.Length; i++)
            {
                a1[i] = func(a1[i], a2);
            }
            return a1;
        }
        public static Span<T> Func_<T>(this Span<T> a1, Span<T> a2, Func<T, T, T> func)
        {
            for (int i = 0; i < a1.Length; i++)
            {
                a1[i] = func(a1[i], a2[i]);
            }
            return a1;
        }
    }
}