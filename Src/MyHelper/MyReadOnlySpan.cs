using System;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Helper class for generic ReadOnlySpan<T> extension
    /// </summary>
    public static partial class MyReadOnlySpan
    {
        public static T[] Func<T>(this ReadOnlySpan<T> a1, Func<T, T> func)
        {
            var n = a1.Length;
            var result = new T[n];
            var s = result.AsSpan();
            for (int i = 0; i < n; i++)
            {
                s[i] = func(a1[i]);
            }
            return result;
        }
        public static T[] Func<T>(this ReadOnlySpan<T> a1, T a2, Func<T, T, T> func)
        {
            var n = a1.Length;
            var result = new T[n];
            var s = result.AsSpan();
            for (int i = 0; i < n; i++)
            {
                s[i] = func(a1[i], a2);
            }
            return result;
        }
        public static T[] Func<T>(this ReadOnlySpan<T> a1, ReadOnlySpan<T> a2, Func<T, T, T> func)
        {
            var n = a1.Length;
            var result = new T[n];
            var s = result.AsSpan();
            for (int i = 0; i < n; i++)
            {
                s[i] = func(a1[i], a2[i]);
            }
            return result;
        }
    }
}