using System;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Helper class for generic array T[] extension
    /// </summary>
    public static partial class MyArray
    {
        public static T1[] Func<T, T1>(this T[] a1, Func<T, T1> func)
        {
            var n = a1.Length;
            var result = new T1[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = func(a1[i]);
            }
            return result;
        }
        public static T1[] Func<T, T1>(this T[] a1, T a2, Func<T, T, T1> func)
        {
            var n = a1.Length;
            var result = new T1[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = func(a1[i], a2);
            }
            return result;
        }
        public static T1[] Func<T, T1>(this T[] a1, T[] a2, Func<T, T, T1> func)
        {
            var n = a1.Length;
            var result = new T1[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = func(a1[i], a2[i]);
            }
            return result;
        }
    }
}