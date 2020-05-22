using System;
using System.Collections.Generic;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Helper class for generic array IEnumerable<T> extension
    /// </summary>
    public static partial class MyIEnumerable
    {
        public static IEnumerable<T1> Map<T, T1>(IEnumerable<T> a1, Func<T, T1> func)
        {
            foreach (var t in a1)
            {
                yield return func(t);
            }
        }

        public static IEnumerable<T1> Map<T, T1>(IEnumerable<T> a1, T a2, Func<T, T, T1> func)
        {
            foreach (var t in a1)
            {
                yield return func(t, a2);
            }
        }
    }
}