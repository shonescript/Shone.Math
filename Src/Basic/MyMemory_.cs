using System;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Helper class for generic Memory<T> modifying extension
    /// </summary>
    public static partial class MyMemory_
    {
        public static Memory<T> Func_<T>(this Memory<T> m1, Func<T, T> func)
        {
            var a1 = m1.Span;
            for (int i = 0; i < a1.Length; i++)
            {
                a1[i] = func(a1[i]);
            }
            return m1;
        }
        public static Memory<T> Func_<T>(this Memory<T> m1, T m2, Func<T, T, T> func)
        {
            var a1 = m1.Span;
            for (int i = 0; i < a1.Length; i++)
            {
                a1[i] = func(a1[i], m2);
            }
            return m1;
        }
        public static Memory<T> Func_<T>(this Memory<T> m1, Memory<T> m2, Func<T, T, T> func)
        {
            var a1 = m1.Span;
            var a2 = m2.Span;
            for (int i = 0; i < a1.Length; i++)
            {
                a1[i] = func(a1[i], a2[i]);
            }
            return m1;
        }
    }
}