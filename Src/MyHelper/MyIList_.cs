using System;
using System.Collections.Generic;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Helper class for generic IList modifying extension
    /// </summary>
    public static partial class MyIList_
    {
        public static IList<T> Func_<T>(this IList<T> a1, Func<T, T> func)
        {
            for (int i = 0; i < a1.Count; i++)
            {
                a1[i] = func(a1[i]);
            }
            return a1;
        }

        public static IList<T> Func_<T>(this IList<T> a1, T a2, Func<T, T, T> func)
        {
            for (int i = 0; i < a1.Count; i++)
            {
                a1[i] = func(a1[i], a2);
            }
            return a1;
        }

        public static IList<T> Func_<T>(this IList<T> a1, IList<T> a2, Func<T, T, T> func)
        {
            for (int i = 0; i < a1.Count; i++)
            {
                a1[i] = func(a1[i], a2[i]);
            }
            return a1;
        }
    }
}