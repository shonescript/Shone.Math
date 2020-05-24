using System;
using System.Reflection;
using System.Collections.Generic;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Static class for generic-types Math operations.
    /// It can be used as a replacement in generic context.
    /// </summary>
    /// <typeparam name="T">the generic numeric type</typeparam>
    public static class Math<T>
    {
        static readonly Type NumType = typeof(T);
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
        public static T RadFactor;
        public static T DegFactor;

        public static Func<T, bool> IsNormal = xTrue;
        public static Func<T, bool> IsSubnormal = xFalse;
        public static Func<T, bool> IsFinite = xTrue;
        public static Func<T, bool> IsNaN = xFalse;
        public static Func<T, bool> IsInfinity = xFalse;
        public static Func<T, bool> IsPositiveInfinity = xFalse;
        public static Func<T, bool> IsNegativeInfinity = xFalse;
        public static Func<T, bool> IsNegative = x => LessThan(x, Zero);

        public static Func<T, T> Negate = x => FromDecimal(-ToDecimal(x));
        public static Func<T, T> Increase = x => FromDecimal(ToDecimal(x) + 1);
        public static Func<T, T> Decrease = x => FromDecimal(ToDecimal(x) - 1);
        public static Func<T, T> Comp = x => FromLong(~ToLong(x));
        public static Func<T, bool> Not = x => !ToBool(x);

        public static Func<T, T, T> Add = (x, y) => FromInt(ToInt(x) + ToInt(y));
        public static Func<T, T, T> Subtract = (x, y) => FromInt(ToInt(x) - ToInt(y));
        public static Func<T, T, T> Multiply = (x, y) => FromInt(ToInt(x) * ToInt(y));
        public static Func<T, T, T> Divide = (x, y) => FromInt(ToInt(x) / ToInt(y));
        public static Func<T, T, T> Modulus = (x, y) => FromInt(ToInt(x) % ToInt(y));

        public static Func<T, T, T> BitAnd = (x, y) => FromLong(ToLong(x) & ToLong(y));
        public static Func<T, T, T> BitOr = (x, y) => FromLong(ToLong(x) | ToLong(y));
        public static Func<T, T, T> BitXOr = (x, y) => FromLong(ToLong(x) ^ ToLong(y));
        public static Func<T, T, T> LeftShift = (x, y) => FromLong(ToLong(x) << ToInt(y));
        public static Func<T, T, T> RightShif = (x, y) => FromLong(ToLong(x) >> ToInt(y));

        public static Func<T, T, bool> And = (x, y) => ToBool(x) && ToBool(x);
        public static Func<T, T, bool> Or = (x, y) => ToBool(x) || ToBool(x);
        public static Func<T, T, bool> LessThan = (x, y) => ToInt(x) < ToInt(y);
        public static Func<T, T, bool> GreatThan = (x, y) => ToInt(x) > ToInt(y);
        public static Func<T, T, bool> LessEqual = (x, y) => ToInt(x) <= ToInt(y);
        public static Func<T, T, bool> GreatEqual = (x, y) => ToInt(x) >= ToInt(y);
        public static Func<T, T, bool> Equal;
        public static Func<T, T, bool> NotEqual;

        public static Func<bool, T> FromBool;
        public static Func<char, T> FromChar;
        public static Func<sbyte, T> FromSByte;
        public static Func<byte, T> FromByte;
        public static Func<short, T> FromShort;
        public static Func<ushort, T> FromUShort;
        public static Func<int, T> FromInt;
        public static Func<uint, T> FromUInt;
        public static Func<long, T> FromLong;
        public static Func<ulong, T> FromULong;
        public static Func<float, T> FromFloat;
        public static Func<double, T> FromDouble;
        public static Func<decimal, T> FromDecimal;
        public static Func<Real, T> FromReal;

        public static Func<T, bool> ToBool;
        public static Func<T, char> ToChar;
        public static Func<T, sbyte> ToSByte;
        public static Func<T, byte> ToByte;
        public static Func<T, short> ToShort;
        public static Func<T, ushort> ToUShort;
        public static Func<T, int> ToInt;
        public static Func<T, uint> ToUInt;
        public static Func<T, long> ToLong;
        public static Func<T, ulong> ToULong;
        public static Func<T, float> ToFloat;
        public static Func<T, double> ToDouble;
        public static Func<T, decimal> ToDecimal;
        public static Func<T, Real> ToReal;

        public static Func<string, T> Parse;
        public static TryParseDelegate TryParse;

        public static Func<T, int> Sign = x => Math.Sign(ToInt(x));
        public static Func<T, T> Abs => x => FromInt(Math.Abs(ToInt(x)));
        public static Func<T, T> Sqrt = x => FromDouble(Math.Sqrt(ToDouble(x)));
        public static Func<T, T> Cbrt = x => FromDouble(Math.Pow(ToDouble(x), 1d / 3d));
        public static Func<T, T> Exp = x => FromDouble(Math.Exp(ToDouble(x)));
        public static Func<T, T, T> Pow = (x, y) => FromDouble(Math.Pow(ToDouble(x), ToDouble(y)));
        public static Func<T, T> Log = x => FromDouble(Math.Log(ToDouble(x)));
        public static Func<T, T> Log2 = x => FromDouble(Math.Log2(ToDouble(x)));
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
        public static Func<T, T> Asinh = x => FromDouble(Math.Asinh(ToDouble(x)));
        public static Func<T, T> Acosh = x => FromDouble(Math.Acosh(ToDouble(x)));
        public static Func<T, T> Atanh = x => FromDouble(Math.Atanh(ToDouble(x)));

        public static Func<T, T> SinDeg = x => Sin(Multiply(x, RadFactor));
        public static Func<T, T> CosDeg = x => Cos(Multiply(x, RadFactor));
        public static Func<T, T> TanDeg = x => Tan(Multiply(x, RadFactor));
        public static Func<T, T> SinhDeg = x => Sinh(Multiply(x, RadFactor));
        public static Func<T, T> CoshDeg = x => Cosh(Multiply(x, RadFactor));
        public static Func<T, T> TanhDeg = x => Tanh(Multiply(x, RadFactor));
        public static Func<T, T> AsinDeg = x => Multiply(Asin(x), DegFactor);
        public static Func<T, T> AcosDeg = x => Multiply(Acos(x), DegFactor);
        public static Func<T, T> AtanDeg = x => Multiply(Atan(x), DegFactor);
        public static Func<T, T, T> AtanDeg2 = (x, y) => Multiply(Atan2(x, y), DegFactor);
        public static Func<T, T> AsinhDeg = x => Multiply(Asinh(x), DegFactor);
        public static Func<T, T> AcoshDeg = x => Multiply(Acosh(x), DegFactor);
        public static Func<T, T> AtanhDeg = x => Multiply(Atanh(x), DegFactor);

        public delegate bool TryParseDelegate(string s, out T t);

        static Math()
        {
            var fields = typeof(Math<T>).GetFields(MyReflection.PublicStatic);
            if (NumType == MyType.Float) AddMethodConsts(typeof(MathF), fields);
            AddMethodConsts(typeof(Math), fields);
            AddMethodConsts(NumType, fields);
            foreach (var pair in MyType.ExtensionSet)
            {
                AddMethodConsts(pair.Value, fields);
            }
            AddMethodConsts(typeof(MyOperator), fields, false);

            foreach (var type in MyType.ConvertSet)
            {
                AddConverts(type, fields);
            }

            if (NumType == MyType.Real) return;
            if (NumType == MyType.Bool) MaxValue = FromInt(1);
            if (!MyType.HasOneSet.Contains(NumType))
            {
                One = FromInt(1);
                if (!MyType.UnsignedSet.Contains(NumType)) MinusOne = FromInt(-1);
            }
            if (!MyType.IEEESet.Contains(NumType))
            {
                NegativeInfinity = MinValue;
                PositiveInfinity = MaxValue;
                if (NumType != MyType.Decimal)
                {
                    PI = FromDouble(Math.PI);
                    E = FromDouble(Math.E);
                }
            }
            var d180 = FromInt(180);
            RadFactor = Divide(PI, d180);
            DegFactor = Divide(d180, PI);
        }

        private static void AddConsts(Type extension, FieldInfo[] fields)
        {
            var fs = extension.GetFields(MyReflection.PublicStatic);
            foreach (var f in fs)
            {
                var name = f.Name;
                if (MyReflection.ConstNameMaps.ContainsKey(name))
                    name = MyReflection.ConstNameMaps[name];
                if (f.FieldType != NumType) continue;
                foreach (var field in fields)
                {
                    if (field.FieldType != NumType || field.Name != name) continue;
                    try
                    {
                        field.SetValue(null, (T)f.GetValue(null));
                    }
                    catch
                    {
                        throw new Exception($"Cannot init the field {NumType.Name}.{name} from: {f}");
                    }
                    break;
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
                        field.SetValue(null, m.CreateDelegate(field.FieldType));
                    }
                    catch
                    {
                        throw new Exception($"Cannot init the method {NumType.Name}.{name} from {m}");
                    }
                    break;
                }
            }
        }

        private static void AddMethodConsts(Type extension, FieldInfo[] fields, bool addConst = true)
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
                var rInt = rt == MyType.Int;
                var rBool = rt == MyType.Bool;
                var bTwo = k == 2;
                var bNums = para.ParameterType == NumType;
                var bStr = para.ParameterType == MyType.String;
                if (bTwo) bNums = bNums && paras[1].ParameterType == NumType;

                if (bNums && (rNum || rBool || rInt) ||
                    bStr && (k == 1 || bTwo && paras[1].ParameterType.IsByRef))
                {
                    if (MyReflection.MethodNameMaps.ContainsKey(name))
                        name = MyReflection.MethodNameMaps[name];
                    else if (bTwo && name == "Log")
                        name = "Logx";
                    setDelegate(fields, name, m);
                }
            }

            if (addConst) AddConsts(extension, fields);
        }

        private static void AddConverts(Type extension, FieldInfo[] fields)
        {
            var ms = extension.GetMethods(MyReflection.PublicStatic);
            var toName = "To" + NumType.ShortName();
            foreach (var m in ms)
            {
                var paras = m.GetParameters();
                if (paras.Length != 1) continue;
                var name = m.Name;
                var fromType = paras[0].ParameterType;
                var toType = m.ReturnType;
                var mtName = "To" + toType.ShortName();
                if (name == "op_Implicit" || name == "op_Explicit" || name == mtName || name == toType.Name)
                {
                    if (fromType == NumType)
                    {
                        setDelegate(fields, mtName, m);
                    }
                    if (toType == NumType && mtName == toName)
                    {
                        setDelegate(fields, "From" + fromType.ShortName(), m);
                    }
                }
            }
        }
    }
}
