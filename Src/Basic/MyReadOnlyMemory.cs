using System;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Helper class for generic ReadOnlyMemory<T> extension
    /// </summary>
    public static partial class MyReadOnlyMemory
    {
        public static T[] Func<T>(this ReadOnlyMemory<T> a1, Func<T, T> func)
        {
            var n = a1.Length;
            var result = new T[n];
            var s = result.AsSpan();
            var s1 = a1.Span;
            for (int i = 0; i < n; i++)
            {
                s[i] = func(s1[i]);
            }
            return result;
        }
        public static T[] Func<T>(this ReadOnlyMemory<T> a1, T a2, Func<T, T, T> func)
        {
            var n = a1.Length;
            var result = new T[n];
            var s = result.AsSpan();
            var s1 = a1.Span;
            for (int i = 0; i < n; i++)
            {
                s[i] = func(s1[i], a2);
            }
            return result;
        }
        public static T[] Func<T>(this ReadOnlyMemory<T> a1, ReadOnlyMemory<T> a2, Func<T, T, T> func)
        {
            var n = a1.Length;
            var result = new T[n];
            var s = result.AsSpan();
            var s1 = a1.Span;
            var s2 = a2.Span;
            for (int i = 0; i < n; i++)
            {
                s[i] = func(s1[i], s2[i]);
            }
            return result;
        }
    }
}