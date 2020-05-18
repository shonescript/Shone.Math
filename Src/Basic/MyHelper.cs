using System;

namespace Shone
{
    public static class MyHelper
    {
        public static Boolean BitAnd(Boolean x, Boolean y) => x & y;
        public static Boolean BitOr(Boolean x, Boolean y) => x | y;
        public static Boolean BitXOr(Boolean x, Boolean y) => x ^ y;
        public static bool And(Boolean x, Boolean y) => x && y;
        public static bool Or(Boolean x, Boolean y) => x || y;
        public static bool Equal(Boolean x, Boolean y) => x == y;
        public static bool NotEqual(Boolean x, Boolean y) => x != y;

        public static bool Equal(Char x, Char y) => x == y;
        public static bool NotEqual(Char x, Char y) => x != y;
        public static bool LessThan(Char x, Char y) => x < y;
        public static bool LessEqual(Char x, Char y) => x <= y;
        public static bool GreatThan(Char x, Char y) => x > y;
        public static bool GreatEqual(Char x, Char y) => x >= y;

        public static bool Equal(SByte x, SByte y) => x == y;
        public static bool NotEqual(SByte x, SByte y) => x != y;
        public static bool LessThan(SByte x, SByte y) => x < y;
        public static bool LessEqual(SByte x, SByte y) => x <= y;
        public static bool GreatThan(SByte x, SByte y) => x > y;
        public static bool GreatEqual(SByte x, SByte y) => x >= y;

        public static bool Equal(Byte x, Byte y) => x == y;
        public static bool NotEqual(Byte x, Byte y) => x != y;
        public static bool LessThan(Byte x, Byte y) => x < y;
        public static bool LessEqual(Byte x, Byte y) => x <= y;
        public static bool GreatThan(Byte x, Byte y) => x > y;
        public static bool GreatEqual(Byte x, Byte y) => x >= y;

        public static bool Equal(Int16 x, Int16 y) => x == y;
        public static bool NotEqual(Int16 x, Int16 y) => x != y;
        public static bool LessThan(Int16 x, Int16 y) => x < y;
        public static bool LessEqual(Int16 x, Int16 y) => x <= y;
        public static bool GreatThan(Int16 x, Int16 y) => x > y;
        public static bool GreatEqual(Int16 x, Int16 y) => x >= y;

        public static UInt32 Add(UInt32 x, UInt32 y) => x + y;
        public static UInt32 Subtract(UInt32 x, UInt32 y) => x - y;
        public static UInt32 Multiply(UInt32 x, UInt32 y) => x * y;
        public static UInt32 Divide(UInt32 x, UInt32 y) => x / y;
        public static UInt32 Modulus(UInt32 x, UInt32 y) => x % y;
        public static UInt32 BitAnd(UInt32 x, UInt32 y) => x & y;
        public static UInt32 BitOr(UInt32 x, UInt32 y) => x | y;
        public static UInt32 BitXOr(UInt32 x, UInt32 y) => x ^ y;
        public static bool Equal(UInt32 x, UInt32 y) => x == y;
        public static bool NotEqual(UInt32 x, UInt32 y) => x != y;
        public static bool LessThan(UInt32 x, UInt32 y) => x < y;
        public static bool LessEqual(UInt32 x, UInt32 y) => x <= y;
        public static bool GreatThan(UInt32 x, UInt32 y) => x > y;
        public static bool GreatEqual(UInt32 x, UInt32 y) => x >= y;

        public static Int32 Negate(Int32 x) => -x;
        public static Int32 Add(Int32 x, Int32 y) => x + y;
        public static Int32 Subtract(Int32 x, Int32 y) => x - y;
        public static Int32 Multiply(Int32 x, Int32 y) => x * y;
        public static Int32 Divide(Int32 x, Int32 y) => x / y;
        public static Int32 Modulus(Int32 x, Int32 y) => x % y;
        public static Int32 BitAnd(Int32 x, Int32 y) => x & y;
        public static Int32 BitOr(Int32 x, Int32 y) => x | y;
        public static Int32 BitXOr(Int32 x, Int32 y) => x ^ y;
        public static Int32 LeftShift(Int32 x, Int32 y) => x << y;
        public static Int32 RightShif(Int32 x, Int32 y) => x >> y;
        public static bool Equal(Int32 x, Int32 y) => x == y;
        public static bool NotEqual(Int32 x, Int32 y) => x != y;
        public static bool LessThan(Int32 x, Int32 y) => x < y;
        public static bool LessEqual(Int32 x, Int32 y) => x <= y;
        public static bool GreatThan(Int32 x, Int32 y) => x > y;
        public static bool GreatEqual(Int32 x, Int32 y) => x >= y;

        public static Int64 Negate(Int64 x) => -x;
        public static Int64 Add(Int64 x, Int64 y) => x + y;
        public static Int64 Subtract(Int64 x, Int64 y) => x - y;
        public static Int64 Multiply(Int64 x, Int64 y) => x * y;
        public static Int64 Divide(Int64 x, Int64 y) => x / y;
        public static Int64 Modulus(Int64 x, Int64 y) => x % y;
        public static Int64 BitAnd(Int64 x, Int64 y) => x & y;
        public static Int64 BitOr(Int64 x, Int64 y) => x | y;
        public static Int64 BitXOr(Int64 x, Int64 y) => x ^ y;
        public static bool Equal(Int64 x, Int64 y) => x == y;
        public static bool NotEqual(Int64 x, Int64 y) => x != y;
        public static bool LessThan(Int64 x, Int64 y) => x < y;
        public static bool LessEqual(Int64 x, Int64 y) => x <= y;
        public static bool GreatThan(Int64 x, Int64 y) => x > y;
        public static bool GreatEqual(Int64 x, Int64 y) => x >= y;

        public static UInt64 Add(UInt64 x, UInt64 y) => x + y;
        public static UInt64 Subtract(UInt64 x, UInt64 y) => x - y;
        public static UInt64 Multiply(UInt64 x, UInt64 y) => x * y;
        public static UInt64 Divide(UInt64 x, UInt64 y) => x / y;
        public static UInt64 Modulus(UInt64 x, UInt64 y) => x % y;
        public static UInt64 BitAnd(UInt64 x, UInt64 y) => x & y;
        public static UInt64 BitOr(UInt64 x, UInt64 y) => x | y;
        public static UInt64 BitXOr(UInt64 x, UInt64 y) => x ^ y;
        public static bool Equal(UInt64 x, UInt64 y) => x == y;
        public static bool NotEqual(UInt64 x, UInt64 y) => x != y;
        public static bool LessThan(UInt64 x, UInt64 y) => x < y;
        public static bool LessEqual(UInt64 x, UInt64 y) => x <= y;
        public static bool GreatThan(UInt64 x, UInt64 y) => x > y;
        public static bool GreatEqual(UInt64 x, UInt64 y) => x >= y;

        public static Single Negate(Single x) => -x;
        public static Single Add(Single x, Single y) => x + y;
        public static Single Subtract(Single x, Single y) => x - y;
        public static Single Multiply(Single x, Single y) => x * y;
        public static Single Divide(Single x, Single y) => x / y;
        public static Single Modulus(Single x, Single y) => x % y;

        public static Double Negate(Double x) => -x;
        public static Double Add(Double x, Double y) => x + y;
        public static Double Subtract(Double x, Double y) => x - y;
        public static Double Multiply(Double x, Double y) => x * y;
        public static Double Divide(Double x, Double y) => x / y;
        public static Double Modulus(Double x, Double y) => x % y;
    }
}