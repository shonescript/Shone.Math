using System;
using System.Collections.Generic;
using System.Text;

namespace Shone
{
    public static class MyType
    {
        public static Type Boolean = typeof(bool);
        public static Type Char = typeof(char);
        public static Type SByte = typeof(sbyte);
        public static Type Byte = typeof(byte);
        public static Type Int16 = typeof(short);
        public static Type UInt16 = typeof(uint);
        public static Type Int32 = typeof(int);
        public static Type UInt32 = typeof(uint);
        public static Type Int64 = typeof(long);
        public static Type UInt64 = typeof(ulong);
        public static Type Single = typeof(float);
        public static Type Double = typeof(double);
        public static Type Decimal = typeof(decimal);
        public static Type String = typeof(string);

        public static HashSet<Type> NumberSet = new HashSet<Type> { Boolean, Char, SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double, Decimal };
        public static HashSet<Type> UnsignedSet = new HashSet<Type> { Char, Byte, UInt16, UInt32, UInt64 };
        public static HashSet<Type> SignedSet = new HashSet<Type> { SByte, Int16, Int32, Int64, Single, Double };
    }
}
