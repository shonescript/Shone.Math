﻿using System;
using System.Reflection;

namespace Shone
{
    public static class Math<T>
    {
        public static readonly Type TheType = typeof(Math<T>);
        public static readonly Type NumType = typeof(T);
        static Func<T, bool> xTrue = x => true;
        static Func<T, bool> xFalse = x => false;
        static Func<T, T> xSelf = x => x;

        public static T MinValue;
        public static T MaxValue;
        public static T Epsilon;
        public static T NegativeInfinity;
        public static T PositiveInfinity;
        public static T NaN;
        public static T Zero;
        public static T One;
        public static T MinusOne;
        public static T PI;
        public static T E;

        public static Func<T, bool> IsNormal = xTrue;
        public static Func<T, bool> IsSubnormal = xFalse;
        public static Func<T, bool> IsFinite = xTrue;
        public static Func<T, bool> IsInfinity = xFalse;
        public static Func<T, bool> IsNaN = xFalse;
        public static Func<T, bool> IsNegative = x => LessThan(x, Zero);
        public static Func<T, bool> IsNegativeInfinity = xFalse;
        public static Func<T, bool> IsPositiveInfinity = xFalse;

        public static Func<T, T> Negate = x => FromDecimal(-ToDecimal(x));
        public static Func<T, T> Increase = x => FromDecimal(ToDecimal(x) + 1);
        public static Func<T, T> Decrease = x => FromDecimal(ToDecimal(x) - 1);
        public static Func<T, T> Comp = x => FromInt64(~ToInt64(x));
        public static Func<T, bool> Not = x => !ToBoolean(x);

        public static Func<T, T, T> Add = (x, y) => FromInt32(ToInt32(x) + ToInt32(y));
        public static Func<T, T, T> Subtract = (x, y) => FromInt32(ToInt32(x) - ToInt32(y));
        public static Func<T, T, T> Multiply = (x, y) => FromInt32(ToInt32(x) * ToInt32(y));
        public static Func<T, T, T> Divide = (x, y) => FromInt32(ToInt32(x) / ToInt32(y));
        public static Func<T, T, T> Modulus = (x, y) => FromInt32(ToInt32(x) % ToInt32(y));

        public static Func<T, T, T> BitAnd = (x, y) => FromInt64(ToInt64(x) & ToInt64(y));
        public static Func<T, T, T> BitOr = (x, y) => FromInt64(ToInt64(x) | ToInt64(y));
        public static Func<T, T, T> BitXOr = (x, y) => FromInt64(ToInt64(x) ^ ToInt64(y));
        public static Func<T, T, T> LeftShift = (x, y) => FromInt64(ToInt64(x) << ToInt32(y));
        public static Func<T, T, T> RightShif = (x, y) => FromInt64(ToInt64(x) >> ToInt32(y));

        public static Func<T, T, bool> And = (x, y) => ToBoolean(x) && ToBoolean(x);
        public static Func<T, T, bool> Or = (x, y) => ToBoolean(x) || ToBoolean(x);
        public static Func<T, T, bool> LessThan = (x, y) => ToInt32(x) < ToInt32(y);
        public static Func<T, T, bool> GreatThan = (x, y) => ToInt32(x) > ToInt32(y);
        public static Func<T, T, bool> LessEqual = (x, y) => ToInt32(x) <= ToInt32(y);
        public static Func<T, T, bool> GreatEqual = (x, y) => ToInt32(x) >= ToInt32(y);
        public static Func<T, T, bool> Equal;
        public static Func<T, T, bool> NotEqual;

        public static Func<bool, T> FromBoolean;
        public static Func<char, T> FromChar;
        public static Func<sbyte, T> FromSByte;
        public static Func<byte, T> FromByte;
        public static Func<short, T> FromInt16;
        public static Func<ushort, T> FromUInt16;
        public static Func<int, T> FromInt32;
        public static Func<uint, T> FromUInt32;
        public static Func<long, T> FromInt64;
        public static Func<ulong, T> FromUInt64;
        public static Func<float, T> FromSingle;
        public static Func<double, T> FromDouble;
        public static Func<decimal, T> FromDecimal;

        public static Func<T, bool> ToBoolean;
        public static Func<T, char> ToChar;
        public static Func<T, sbyte> ToSByte;
        public static Func<T, byte> ToByte;
        public static Func<T, short> ToInt16;
        public static Func<T, ushort> ToUInt16;
        public static Func<T, int> ToInt32;
        public static Func<T, uint> ToUInt32;
        public static Func<T, long> ToInt64;
        public static Func<T, ulong> ToUInt64;
        public static Func<T, float> ToSingle;
        public static Func<T, double> ToDouble;
        public static Func<T, decimal> ToDecimal;

        public static Func<string, T> Parse;

        public static Func<T, int> Sign = x => Math.Sign(ToInt32(x));
        public static Func<T, T> Abs => x => FromInt32(Math.Abs(ToInt32(x)));
        public static Func<T, T> Sqrt = x => FromDouble(Math.Sqrt(ToDouble(x)));
        public static Func<T, T> Cbrt = x => FromDouble(Math.Pow(ToDouble(x), 1d / 3d));
        public static Func<T, T> Exp = x => FromDouble(Math.Exp(ToDouble(x)));
        public static Func<T, T, T> Pow = (x, y) => FromDouble(Math.Pow(ToDouble(x), ToDouble(y)));
        public static Func<T, T> Log = x => FromDouble(Math.Log(ToDouble(x)));
#if Net5
        public static Func<T, T> Log2 = x => FromDouble(Math.Log2(ToDouble(x)));
#else
        public static Func<T, T> Log2 = x => Logx(x, FromInt32(2));
#endif
        public static Func<T, T> Log10 = x => FromDouble(Math.Log10(ToDouble(x)));
        public static Func<T, T, T> Logx = (x, y) => FromDouble(Math.Log(ToDouble(x), ToDouble(y)));

        public static Func<T, T> Floor = xSelf;
        public static Func<T, T> Ceiling = xSelf;
        public static Func<T, T> Round = xSelf;
        public static Func<T, T> Truncate = xSelf;
        public static Func<T, T, T> Min = (x, y) => FromDouble(Math.Min(ToDouble(x), ToDouble(y)));
        public static Func<T, T, T> Max = (x, y) => FromDouble(Math.Max(ToDouble(x), ToDouble(y)));

        public static Func<T, T> Sin = x => FromDouble(Math.Sin(ToDouble(x)));
        public static Func<T, T> Cos = x => FromDouble(Math.Cos(ToDouble(x)));
        public static Func<T, T> Tan = x => FromDouble(Math.Tan(ToDouble(x)));
        public static Func<T, T> Sinh = x => FromDouble(Math.Sinh(ToDouble(x)));
        public static Func<T, T> Cosh = x => FromDouble(Math.Cosh(ToDouble(x)));
        public static Func<T, T> Tanh = x => FromDouble(Math.Tanh(ToDouble(x)));

        public static Func<T, T> Asin = x => FromDouble(Math.Asin(ToDouble(x)));
        public static Func<T, T> Acos = x => FromDouble(Math.Acos(ToDouble(x)));
        public static Func<T, T> Atan = x => FromDouble(Math.Atan(ToDouble(x)));
        public static Func<T, T, T> Atan2 = (x, y) => FromDouble(Math.Atan2(ToDouble(x), ToDouble(y)));
#if Net5
        public static Func<T, T> Asinh = x => FromDouble(Math.Asinh(ToDouble(x)));
        public static Func<T, T> Acosh = x => FromDouble(Math.Acosh(ToDouble(x)));
        public static Func<T, T> Atanh = x => FromDouble(Math.Atanh(ToDouble(x)));
#endif

        static Math()
        {
            var fields = TheType.GetFields(MyReflection.PublicStatic);
            var bFloat = NumType == MyType.Single;
#if Net5
            if (bFloat)
            {
                var mf = typeof(MathF);
                AddMethods(mf, fields);
                AddConsts(mf, fields);
            }
#endif

            var mathType = typeof(Math);
            AddMethods(mathType, fields);
            AddConsts(mathType, fields);

            AddMethods(NumType, fields);
            AddConsts(NumType, fields);

            AddMethods(typeof(MyHelper), fields);
            AddConverts(typeof(Convert), fields);
            if (NumType == MyType.Boolean)
            {
                Math<bool>.MaxValue = Math<bool>.One = true;
            }
            else if (NumType != MyType.Decimal)
            {
                One = FromInt32(1);
                if (MyType.SignedSet.Contains(NumType))
                {
                    MinusOne = FromInt32(-1);
                }
            }
            if (NumType != MyType.Double)
            {
                NegativeInfinity = MinValue;
                PositiveInfinity = MaxValue;
#if Net5
                if (NumType != MyType.Single)
#endif
                {
                    PI = FromDouble(Math.PI);
                    E = FromDouble(Math.E);
                }
            }
        }

        private static void AddConsts(Type extension, FieldInfo[] fields)
        {
            var fs = extension.GetFields(MyReflection.PublicStatic);
            foreach (var f in fs)
            {
                if (f.FieldType == NumType)
                {
                    var name = f.Name;
                    foreach (var field in fields)
                    {
                        if (field.Name == name)
                        {
                            field.SetValue(null, (T)f.GetValue(null));
                            break;
                        }
                    }
                }
            }
        }
        private static void setDelegate(FieldInfo[] fields, string name, MethodInfo m)
        {
            foreach (var field in fields)
            {
                if (field.Name == name)
                {
                    try
                    {
#if Net5
                        field.SetValue(null, m.CreateDelegate(field.FieldType));
#else
                        field.SetValue(null, Delegate.CreateDelegate(field.FieldType, m));
#endif
                    }
                    catch
                    {
                        throw new Exception($"Cannot init the method {name}");
                    }
                    break;
                }
            }
        }
        private static void AddMethods(Type extension, FieldInfo[] fields)
        {
            var ms = extension.GetMethods(MyReflection.PublicStatic);
            foreach (var m in ms)
            {
                var paras = m.GetParameters();
                var k = paras.Length;
                if (k == 0 || k > 2) continue;

                var name = m.Name;
                var para = paras[0];
                var rt = m.ReturnType;
                var rNum = rt == NumType;
                var rInt = rt == MyType.Int32;
                var rBool = rt == MyType.Boolean;
                var bTwo = k == 2;
                var bNums = para.ParameterType == NumType;
                if (bTwo) bNums = bNums && paras[1].ParameterType == NumType;

                if (bNums && (rNum || rBool || rInt) ||
                    k == 1 && para.ParameterType == MyType.String)
                {
                    if (MyReflection.MethodNameMaps.ContainsKey(name))
                        name = MyReflection.MethodNameMaps[name];
                    else if (bTwo && name == "Log")
                        name = "Logx";
                    setDelegate(fields, name, m);
                }
            }
        }
        private static void AddConverts(Type extension, FieldInfo[] fields)
        {
            var ms = extension.GetMethods(MyReflection.PublicStatic);
            var toName = "To" + NumType.Name;
            foreach (var m in ms)
            {
                var paras = m.GetParameters();
                if (paras.Length != 1) continue;

                var name = m.Name;
                var from = paras[0].ParameterType;
                if (from == NumType)
                {
                    setDelegate(fields, name, m);
                }
                if (m.ReturnType == NumType && name == toName)
                {
                    setDelegate(fields, "From" + from.Name, m);
                }
            }
        }
    }
}
