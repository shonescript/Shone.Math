using System;
using System.Collections.Generic;
using System.Text;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Helper class for Type usage
    /// </summary>
    public static class MyType
    {
        public static Type Bool = typeof(bool);
        public static Type Char = typeof(char);
        public static Type SByte = typeof(sbyte);
        public static Type Byte = typeof(byte);
        public static Type Short = typeof(short);
        public static Type UShort = typeof(uint);
        public static Type Int = typeof(int);
        public static Type UInt = typeof(uint);
        public static Type Long = typeof(long);
        public static Type ULong = typeof(ulong);
        public static Type Float = typeof(float);
        public static Type Double = typeof(double);
        public static Type Decimal = typeof(decimal);
        public static Type Real = typeof(Real);
        public static Type String = typeof(string);

        public static HashSet<Type> NumberSet = new HashSet<Type> { Bool, Char, SByte, Byte, Short, UShort, Int, UInt, Long, ULong, Float, Double, Decimal, Real };
        public static HashSet<Type> UnsignedSet = new HashSet<Type> { Byte, Char, UShort, UInt, ULong };
        public static HashSet<Type> SignedSet = new HashSet<Type> { SByte, Short, Int, Long, Float, Double, Decimal, Real };
    }
}
