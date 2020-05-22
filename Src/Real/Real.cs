using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Real number type code
    /// </summary>
    public enum RealCode
    {
        Real = 1,
        Ration = 2,
        PI = 4,
        E = 8,
        Sqrt = 16,
        Sqrd = 32,
        Log10 = 64,
        Log = 128,
        Logx = 256,
        Xp = 512,
        Exp = 1024,
        Pow = 2048
    }

    /// <summary>
    /// Base class for real number, including floating, rational, irrational
    /// </summary>
    public class Real : IComparable, IFormattable, IConvertible, IComparable<Real>, IEquatable<Real>
    {
        public double Data;

        public virtual RealCode RealCode => RealCode.Real;

        public virtual double Numer => Data;

        public virtual double Denom => 1;

        public virtual bool IsNumer => true;
        public virtual bool IsFract => false;
        public virtual bool IsRation => true;
        public virtual bool IsIrration => false;

        public virtual Real Sign => From(Math.Sign(Data));
        public virtual Real Abs => From(Math.Abs(Data));
        public virtual Real Invert => From(1, Data);
        public virtual Real Percent => From(Data, 100);
        public virtual Real Negate => -Data;

        public virtual Real Sqrd => irratSqrd.calcNew(Data);
        public virtual Real Sqrt => irratSqrt.calcNew(Data);
        public virtual Real Xp => irratXp.calcNew(Data);
        public virtual Real Exp => irratExp.calcNew(Data);
        public virtual Real Log => irratLn.calcNew(Data);
        public virtual Real Log10 => irratLg.calcNew(Data);

        internal Real()
        {
        }
        internal Real(double x)
        {
            Data = x;
        }

        public override int GetHashCode()
        {
            return Data.GetHashCode();
        }

        public bool Equal(double d)
        {
            var d1 = Data;
            if (double.IsNaN(d1) && double.IsNaN(d)) return true;
            return d1 == d;
        }
        public bool Equals(Real r)
        {
            return Equal(r.Data);
        }
        public override bool Equals(object obj)
        {
            if (obj is Real r) return Equal(r.Data);
            return ReferenceEquals(this, obj);
        }
        public int CompareTo(Real r)
        {
            return Data.CompareTo(r.Data);
        }
        public int CompareTo(object obj)
        {
            if (obj is Real r) return Data.CompareTo(r.Data);
            return -1;
        }

        protected string toString(string suffix)
        {
#if Net5
            if (suffix == null || !double.IsFinite(Data))
#else
            if (suffix == null || double.IsInfinity(Data) || double.IsNaN(Data))
#endif
            {
                if (stringCaches.ContainsKey(this)) return stringCaches[this];
                return Data.ToString("r");
            }
            var sb = new StringBuilder(32);
            sb.Append(Numer.ToString("r"));
            if (IsFract)
            {
                sb.Append("\\");
                sb.Append(Denom.ToString("r"));
            }
            sb.Append(suffix);
            return sb.ToString();
        }
        public virtual string ToString(bool bSource)
        {
            return toString(bSource ? "r" : null);
        }

        public TypeCode GetTypeCode() => TypeCode.Double;
        public string ToString(string format) => Data.ToString(format);
        public string ToString(IFormatProvider provider) => Data.ToString(provider);
        public string ToString(string format, IFormatProvider provider) => Data.ToString(format, provider);

        public bool ToBoolean(IFormatProvider provider) => Data != 0;
        public sbyte ToSByte(IFormatProvider provider) => (sbyte)Data;
        public byte ToByte(IFormatProvider provider) => (byte)Data;
        public char ToChar(IFormatProvider provider) => (char)Data;
        public short ToInt16(IFormatProvider provider) => (short)Data;
        public ushort ToUInt16(IFormatProvider provider) => (ushort)Data;
        public int ToInt32(IFormatProvider provider) => (int)Data;
        public uint ToUInt32(IFormatProvider provider) => (uint)Data;
        public long ToInt64(IFormatProvider provider) => (long)Data;
        public ulong ToUInt64(IFormatProvider provider) => (ulong)Data;
        public float ToSingle(IFormatProvider provider) => (float)Data;
        public double ToDouble(IFormatProvider provider) => Data;
        public decimal ToDecimal(IFormatProvider provider) => (decimal)Data;
        public DateTime ToDateTime(IFormatProvider provider) => Convert.ToDateTime(Data);
        public object ToType(Type type, IFormatProvider provider)
        {
            throw new NotImplementedException();
            //return Convert.DefaultToType(Data, type, provider);
        }

        protected virtual Real create(Real xr)
        {
            return xr;
        }
        internal virtual Real calcCreate(double n, double d)
        {
            return From(n, d);
        }

        public virtual Real Add(double n2)
        {
            return Data + n2;
        }
        public Real Add(Real x2)
        {
            var code = x2.RealCode;
            var n2 = x2.Numer;
            if (code == RealCode.Real) return Add(n2);
            var n1 = Numer;
            var d1 = Denom;
            var d2 = x2.Denom;
            code |= RealCode;
            if (code <= RealCode.PI || code == RealCode.E)
            {
                return d1 == d2 ?
                   calcCreate(n1 + n2, d1) :
                   calcCreate(n1 * d2 + d1 * n2, d1 * d2);
            }
            if (code == RealCode.Log10 || code == RealCode.Log)
            {
                return calcCreate(n1 * n2, d1 * d2);
            }
            if (code == RealCode.Logx && n1 == n2) return calcCreate(n1, d1 * d2);
            return Data + x2.Data;
        }

        public virtual Real Sub(double n2)
        {
            return Data - n2;
        }
        public Real Sub(Real x2)
        {
            var code = x2.RealCode;
            var n2 = x2.Numer;
            if (code == RealCode.Real) return Sub(n2);
            var n1 = Numer;
            var d1 = Denom;
            var d2 = x2.Denom;
            code |= RealCode;
            if (code <= RealCode.PI || code == RealCode.E)
            {
                return d1 == d2 ?
                   calcCreate(n1 - n2, d1) :
                   calcCreate(n1 * d2 - d1 * n2, d1 * d2);
            }
            if (code == RealCode.Log10 || code == RealCode.Log)
            {
                return calcCreate(n1 * d2, d1 * n2);
            }
            return Data - x2.Data;
        }

        public virtual Real Mul(double x2)
        {
            return Data * x2;
        }
        public Real Mul(Real x2)
        {
            var code = x2.RealCode;
            var n2 = x2.Numer;
            if (code == RealCode.Real) return Mul(n2);
            var n1 = Numer;
            var d1 = Denom;
            var d2 = x2.Denom;
            code |= RealCode;
            if (code < RealCode.PI || code == RealCode.Sqrt || code == RealCode.Sqrd)
            {
                return calcCreate(n1 * n2, d1 * d2);
            }
            if (code == RealCode.Xp || code == RealCode.Exp)
            {
                return d1 == d2 ?
                   calcCreate(n1 + n2, d1) :
                   calcCreate(n1 * d2 + d1 * n2, d1 * d2);
            }
            if (code == RealCode.Pow && n1 == n2) return calcCreate(n1, d1 + d2);
            return Data * x2.Data;
        }

        public virtual Real Divide(double x2)
        {
            return From(Data, x2);
        }
        public Real Divide(Real x2)
        {
            var code = x2.RealCode;
            var n2 = x2.Numer;
            if (code == RealCode.Real) return Divide(n2);
            var n1 = Numer;
            var d1 = Denom;
            var d2 = x2.Denom;
            code |= RealCode;
            if (code < RealCode.PI)
            {
                return From(n1 * d2, d1 * n2);
            }
            if (code == RealCode.PI || code == RealCode.E || code == RealCode.Sqrt || code == RealCode.Sqrd)
            {
                return calcCreate(n1 * d2, d1 * n2);
            }
            if (code == RealCode.Xp || code == RealCode.Exp)
            {
                return d1 == d2 ?
                   calcCreate(n1 - n2, d1) :
                   calcCreate(n1 * d2 - d1 * n2, d1 * d2);
            }
            if (code == RealCode.Pow && n1 == n2) return calcCreate(n1, d1 - d2);
            return Data / x2.Data;
        }

        public virtual Real Div(double x2)
        {
            return Math.Truncate(Data / x2);
        }
        public Real Div(Real x2)
        {
            var code = x2.RealCode;
            var n2 = x2.Numer;
            if (code == RealCode.Real) return Div(n2);
            var n1 = Numer;
            var d1 = Denom;
            var d2 = x2.Denom;
            code |= RealCode;
            if (code <= RealCode.PI || code == RealCode.E)
            {
                return Math.Truncate(n1 * d2 / (d1 * n2));
            }
            return Math.Truncate(Data / x2.Data);
        }

        public virtual Real Mode(double x2)
        {
            return Data % x2;
        }
        public Real Mode(Real x2)
        {
            if (x2.RealCode == RealCode.Real) return Mode(x2.Numer);
            return Data % x2.Data;
        }

        public Real Pow(Real x2)
        {
            var n2 = x2.Numer;
            var d2 = x2.Denom;
            var c2 = x2.RealCode;
            if (c2 <= RealCode.Ration)
            {
                if (Data == 10) return new IrratXp(n2, d2);
                else if (Data == Math.E) return new IrratExp(n2, d2);
            }
            if ((RealCode | c2) == RealCode.Real) return new IrratPow(Data, n2);
            return Math.Pow(Data, x2.Data);
        }
        public Real SPow(Real x2)
        {
            return Pow(x2.Invert);
        }
        public Real Logx(Real newBase)
        {
            var b = newBase.Data;
            if (b == E) return new IrratLog(Numer, Denom);
            if (b == 10) return new IrratLog10(Numer, Denom);
            return new IrratLogx(b, Data);
        }

        public static readonly Real MaxValue = new Real(double.MaxValue);
        public static readonly Real One = new Real(1);
        public static readonly Real Zero = new Real(0);
        public static readonly Real MinusOne = new Real(-1);
        public static readonly Real MinValue = new Real(double.MinValue);
        public static readonly Real NaN = new Real(double.NaN);
        public static readonly Real PositiveInfinity = new Real(double.PositiveInfinity);
        public static readonly Real NegativeInfinity = new Real(double.NegativeInfinity);
        public static readonly Real EpsDigit = new Real(6);
        public static readonly Real Epsilon = new Ration(1, 1e6);
        public static readonly Real SqrdEpsilon = new Ration(1, 1e12);
        public static readonly Real SqrtEpsilon = new Ration(1, 1e3);
        public static readonly Real E = new IrratE(1, 1);
        public static readonly Real PI = new IrratPI(1, 1);
        public static readonly Real TwoPI = new IrratPI(2, 1);
        public static readonly Real RadFactor = new IrratPI(1, 180);
        public static readonly Real DegFactor = new Real(180 / Math.PI);

        public static readonly Real Two = new Real(2);
        public static readonly Real Three = new Real(3);
        public static readonly Real Four = new Real(4);
        public static readonly Real Five = new Real(5);
        public static readonly Real Six = new Real(6);
        public static readonly Real Seven = new Real(7);
        public static readonly Real Eight = new Real(8);
        public static readonly Real Nine = new Real(9);
        public static readonly Real Ten = new Real(10);
        public static readonly Real Eleven = new Real(11);
        public static readonly Real Tweleve = new Real(12);
        public static readonly Real Thirteen = new Real(13);
        public static readonly Real Forteen = new Real(14);
        public static readonly Real Fifteen = new Real(15);
        public static readonly Real Sixteen = new Real(16);
        public static readonly Real Seventeen = new Real(17);
        public static readonly Real Eighteen = new Real(18);
        public static readonly Real Ninteen = new Real(19);
        public static readonly Real Twenty = new Real(20);
        public static readonly Real Thirty = new Real(30);
        public static readonly Real Forty = new Real(40);
        public static readonly Real Fifty = new Real(50);
        public static readonly Real Sixty = new Real(60);
        public static readonly Real Seventy = new Real(70);
        public static readonly Real Eighty = new Real(80);
        public static readonly Real Ninty = new Real(90);
        public static readonly Real Hundred = new Real(100);
        public static readonly Real OneEighty = new Real(180);
        public static readonly Real TwoSeventy = new Real(270);
        public static readonly Real TreeSixty = new Real(360);
        public static readonly Real OneOfTwo = new Ration(1, 2);
        public static readonly Real OneOfThree = new Ration(1, 3);
        public static readonly Real OneOfFour = new Ration(1, 4);
        public static readonly Real OneOfFive = new Ration(1, 5);
        public static readonly Real OneOfSix = new Ration(1, 6);
        public static readonly Real OneOfSeven = new Ration(1, 7);
        public static readonly Real OneOfEight = new Ration(1, 8);
        public static readonly Real OneOfNine = new Ration(1, 9);
        public static readonly Real OneOfTen = new Ration(1, 10);
        public static readonly Real NOneOfTwo = new Ration(-1, 2);
        public static readonly Real NOneOfThree = new Ration(-1, 3);
        public static readonly Real NOneOfFour = new Ration(-1, 4);
        public static readonly Real NOneOfFive = new Ration(-1, 5);
        public static readonly Real NOneOfSix = new Ration(-1, 6);
        public static readonly Real NOneOfSeven = new Ration(-1, 7);
        public static readonly Real NOneOfEight = new Ration(-1, 8);
        public static readonly Real NOneOfNine = new Ration(-1, 9);
        public static readonly Real NOneOfTen = new Ration(-1, 10);

        internal static readonly IrratSqrt irratSqrt = new IrratSqrt(1, 1);
        internal static readonly IrratSqrd irratSqrd = new IrratSqrd(1, 1);
        internal static readonly IrratLog10 irratLg = new IrratLog10(1, 1);
        internal static readonly IrratLog irratLn = new IrratLog(1, 1);
        internal static readonly IrratLogx irratLog = new IrratLogx(1, 1);
        internal static readonly IrratXp irratXp = new IrratXp(1, 1);
        internal static readonly IrratExp irratExp = new IrratExp(1, 1);
        internal static readonly IrratPow irratPow = new IrratPow(1, 1);

        protected static readonly Dictionary<double, Real> dataMaps = new Dictionary<double, Real>(56000);
        protected static readonly Dictionary<string, Real> stringMaps = new Dictionary<string, Real>(56000);
        protected static readonly Dictionary<Real, string> stringCaches = new Dictionary<Real, string>(56000);
        static Real()
        {
            var fields = MyType.Real.GetFields(MyReflection.PublicStatic);
            foreach (var f in fields)
            {
                var x = f.GetValue(null);
                if (x is Real r) addReal(r);
            }

            for (int i = 1; i < 10000; i++) addDouble(i, true);
            for (int i = 10000; i <= 65536; i++)
            {
                if (i % 100 == 0 || i % 256 == 0) addDouble(i, true);
            }
            for (int i = 17; i < 31; i++) addDouble(1 << i, true);

            int m1 = 10000;
            int N = 8;
            for (int i = 4; i <= N; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    int k = j * m1;
                    addDouble(k, true);
                }
                m1 *= 10;
            }
            addDouble(1000000000, true);
            addDouble(2000000000, true);
            addDouble(int.MaxValue, true);
            addDouble(int.MinValue, true);

            for (int i = 2; i <= 100; i++)
            {
                for (int j = 1; j < 100; j++) addRation(j, i);
            }
            for (int i = 101; i <= 10000; i++)
            {
                if (i % 2 == 0 || i % 5 == 0) addRation(1, i);
            }
            for (int i = 10001; i <= 1000000000; i *= 10) addRation(1, i);

            addReals(72, 36, (n, d) => new IrratPI(n, d));
            addReals(20, 10, (n, d) => new IrratE(n, d));
            addReals(100, 100, (n, d) => new IrratSqrt(n, d), false);
            addReals(100, 1, (n, d) => new IrratLog10(n, d), false);
        }
        static void addReal(Real real)
        {
            var str = MyString.CacheString(real.ToString(false));
            dataMaps[real.Data] = real;
            stringMaps[str] = real;
            stringCaches[real] = str;
        }
        static void addDouble(double x, bool bNeg = false)
        {
            if (!dataMaps.ContainsKey(x)) addReal(new Real(x));
            if (bNeg) addDouble(-x, false);
        }
        static void addRation(double n, double d, bool bNeg = true)
        {
            double x = n / d;
            if (!dataMaps.ContainsKey(x)) addReal(From(n, d, x));
            if (bNeg) addRation(-n, d, false);
        }
        static void addReal(Real real, bool bNeg)
        {
            if (!dataMaps.ContainsKey(real.Data)) addReal(real);
            if (bNeg) addReal(real.Negate, false);
        }
        static void addReals(double N, double D, Func<double, double, Real> func, bool bNeg = true)
        {
            for (double d = 1; d <= D; d++)
            {
                for (double n = 1; n <= N; n++)
                {
                    if (dataMaps.ContainsKey(n / d)) addReal(func(n, d), bNeg);
                }
            }
        }

        public static Real From(int num)
        {
            double value = num;
            if (dataMaps.ContainsKey(value)) return dataMaps[value];
            return new Real(value);
        }

        public static Real From(double value, bool bTest = false)
        {
            if (dataMaps.ContainsKey(value)) return dataMaps[value];
            if (value.IsNotMisc()) return new Real(value);
            if (value.TryRound_())
            {
                if (dataMaps.ContainsKey(value)) return dataMaps[value];
                return new Real(value);
            }
            return bTest ? null : new Real(value);
        }

        public static Real From(double numer, double denom)
        {
            if (denom == 1) return numer;
            if (denom == -1) return -numer;
            return From(numer, denom, numer / denom);
        }
        unsafe public static Real From(double numer, double denom, double value)
        {
            var real = From(value, true);
            if (real != null) return real;

            if (numer.IsMisc() || denom.IsMisc()) return new Real(value);

            if (denom < 0)
            {
                numer = -numer;
                denom = -denom;
            }
            if (denom == 1) return new Real(numer);

            if (value > -1 && value < 1)
            {
                double d = denom / numer;
                if (d.TryRound_())
                {
                    value = 1 / d;
                    if (dataMaps.ContainsKey(value)) return dataMaps[value];
                }
                if (d.IsNotMisc())
                {
                    if (d > 0) return new Ration(1, d, value);
                    else if (d < 0) return new Ration(-1, -d, value);
                    else if (d == 0) return PositiveInfinity;
                    else return NaN;
                }
            }

            if (denom.TryRound_())
            {
                if (denom == 0) return numer < 0 ? PositiveInfinity : NegativeInfinity;
                if (numer.TryRound_())
                {
                    var n = numer < 0 ? -numer : numer;
                    var gcd = n < denom ? MyDouble.gcd(denom, n) : MyDouble.gcd(n, denom);
                    if (gcd > 1)
                    {
                        numer /= gcd;
                        denom /= gcd;
                    }
                    if (denom == 1) return new Real(numer);
                }
            }
            return new Ration(numer, denom);
        }
        public static Real From(Real real, string suffix)
        {
            double numer = real.Numer;
            double denom = real.Denom;
            switch (suffix)
            {
                case "pi":
                    return new IrratPI(numer, denom);
                case "e":
                    return new IrratE(numer, denom);
                case "sqt":
                    return new IrratSqrt(numer, denom);
                case "sqd":
                    return new IrratSqrd(numer, denom);
                case "lg":
                    return new IrratLog10(numer, denom);
                case "ln":
                    return new IrratLog(numer, denom);
                case "log":
                    return new IrratLogx(numer, denom);
                case "xp":
                    return new IrratXp(numer, denom);
                case "exp":
                    return new IrratExp(numer, denom);
                case "pow":
                    return new IrratPow(numer, denom);
            }
            return real;
        }

        public static Real getreal(string text)
        {
            if (stringMaps.ContainsKey(text)) return stringMaps[text];
            return null;
        }
        static Real parsing(string text)
        {
            if (stringMaps.ContainsKey(text)) return stringMaps[text];
            int len = text.Length;
            int n = len;
            int i = text.IndexOf('.');
            bool bDot = i >= 0;
            int maxdigit = 14;
            if (bDot)
            {
                n = i == 0 ? 0 : i;
                i++;
                maxdigit = 16;
            }
            else
            {
                i = 0;
            }

            double e = 0;
            int j = text.IndexOfAny(MyString.ExpSplitChars, i);
            if (j >= i)
            {
                if (j > maxdigit) goto OUT;
                e = int.Parse(text.Substring(j + 1));
                while (j > i && text[j - 1] == '0')
                {
                    j--;
                    if (!bDot) e++;
                }
                if (j < n) n = j;
            }
            else
            {
                if (len > maxdigit) goto OUT;
                j = len;
            }
            if (e > 100 || e < -100) goto OUT;

            bool bFract = e < 0;
            var exp = e == 0 ? 1 : Math.Pow(10, bFract ? -e : e);
            double numer = n > 0 ? double.Parse(text.Substring(0, n)) : 0;
            if (j > i)
            {
                double d = 0;
                if (bDot)
                {
                    j -= i;
                    d = double.Parse(text.Substring(i, j));
                }
                else
                {
                    j = 0;
                }
                if (e == j) return numer * exp + d;
                double jxp = j == 0 ? 1 : Math.Pow(10, j);
                numer = numer * jxp + d;
                if (e > j) return numer * (exp / jxp);
                if (bFract) return From(numer, exp * jxp);
                return From(numer, jxp / exp);
            }
            if (bFract) return From(numer, exp);
            return numer * exp;

        OUT: return double.Parse(text);
        }
        public static Real Parsing(string text, int k = -1)
        {
            var real = Zero;
            int n = text.Length;
            if (k < 0) k = text.LastIndexOfAny(MyString.Digit10Chars) + 1;
            if (k > 0)
            {
                var suffix = k < n;
                var str = suffix ? text.Substring(0, k) : text;
                var i = str.IndexOf('\\');
                if (i < 0)
                {
                    real = parsing(str);
                }
                else
                {
                    int j = i + 1;
                    real = parsing(str.Substring(0, i)) / parsing(str.Substring(j, n - j));
                }
                if (suffix) return From(real, text.Substring(k));
            }
            return real;
        }
        public static Real Parse(string text)
        {
            return Parsing(text, -1);
        }
        public static Real Parse(string text, NumberStyles style) => double.Parse(text, style);
        public static Real Parse(string text, IFormatProvider provider) => double.Parse(text, provider);
        public static Real Parse(string text, NumberStyles style, IFormatProvider provider) => double.Parse(text, style, provider);
        public static bool TryParse(string text, out Real result)
        {
            result = Parsing(text, -1);
            return true;
        }
        public static bool TryParse(string text, NumberStyles style, IFormatProvider provider, out Real result)
        {
            result = Parsing(text, -1);
            return true;
        }

        public static implicit operator Real(byte x) => From(x);
        public static implicit operator Real(sbyte x) => From(x);
        public static implicit operator Real(short x) => From(x);
        public static implicit operator Real(ushort x) => From(x);
        public static implicit operator Real(char x) => From(x);
        public static implicit operator Real(int x) => From(x);
        public static implicit operator Real(uint x) => From(x);
        public static implicit operator Real(long x) => From(x);
        public static implicit operator Real(ulong x) => From(x);
        public static implicit operator Real(float x) => From(x);
        public static implicit operator Real(double x) => From(x);
        public static implicit operator Real(decimal x) => From((double)x);

        public static explicit operator bool(Real r) => r.Data != 0;
        public static explicit operator byte(Real r) => (byte)r.Data;
        public static explicit operator sbyte(Real r) => (sbyte)r.Data;
        public static explicit operator short(Real r) => (short)r.Data;
        public static explicit operator ushort(Real r) => (ushort)r.Data;
        public static explicit operator char(Real r) => (char)r.Data;
        public static explicit operator int(Real r) => (int)r.Data;
        public static explicit operator uint(Real r) => (uint)r.Data;
        public static explicit operator long(Real r) => (long)r.Data;
        public static explicit operator ulong(Real r) => (ulong)r.Data;
        public static explicit operator float(Real r) => (float)r.Data;
        public static explicit operator double(Real r) => r.Data;
        public static explicit operator decimal(Real r) => (decimal)r.Data;

        public static Real operator -(Real x)
        {
            return x.Negate;
        }
        public static Real operator ++(Real x)
        {
            return x.Add(1);
        }
        public static Real operator --(Real x)
        {
            return x.Add(-1);
        }

        public static Real operator +(double n1, Real x2)
        {
            return x2.Add(n1);
        }
        public static Real operator +(Real x1, double n2)
        {
            return x1.Add(n2);
        }
        public static Real operator +(Real x1, Real x2)
        {
            return x1.Add(x2);
        }

        public static Real operator -(double n1, Real x2)
        {
            return x2.Negate.Add(n1);
        }
        public static Real operator -(Real x1, double n2)
        {
            return x1.Sub(n2);
        }
        public static Real operator -(Real x1, Real x2)
        {
            return x1.Sub(x2);
        }

        public static Real operator *(double n1, Real x2)
        {
            return x2.Mul(n1);
        }
        public static Real operator *(Real x1, double n2)
        {
            return x1.Mul(n2);
        }
        public static Real operator *(Real x1, Real x2)
        {
            return x1.Mul(x2);
        }

        public static Real operator /(double n1, Real x2)
        {
            return x2.Invert.Mul(n1);
        }
        public static Real operator /(Real x1, double n2)
        {
            return x1.Divide(n2);
        }
        public static Real operator /(Real x1, Real x2)
        {
            return x1.Divide(x2);
        }

        public static Real operator %(double n1, Real x2)
        {
            return From(n1).Mode(x2);
        }
        public static Real operator %(Real x1, double n2)
        {
            return x1.Mode(n2);
        }
        public static Real operator %(Real x1, Real x2)
        {
            return x1.Mode(x2);
        }

        public static bool operator ==(double x1, Real x2) => (object)x2 != null && x2.Equal(x1);
        public static bool operator ==(Real x1, double x2) => (object)x1 != null && x1.Equal(x2);
        public static bool operator ==(Real x1, Real x2)
        {
            object o1 = x1;
            object o2 = x2;
            if (o1 == o2) return true;
            if (o1 == null || o2 == null) return false;
            return x1.Equals(x2);
        }

        public static bool operator !=(double x1, Real x2) => (object)x2 == null || !x2.Equal(x1);
        public static bool operator !=(Real x1, double x2) => (object)x1 == null || !x1.Equal(x2);
        public static bool operator !=(Real x1, Real x2) => !(x1 == x2);

        public static bool operator >(double x1, Real x2) => x1 > x2.Data;
        public static bool operator >(Real x1, double x2) => x1.Data > x2;
        public static bool operator >(Real x1, Real x2) => x1.Data > x2.Data;

        public static bool operator <(double x1, Real x2) => x1 < x2.Data;
        public static bool operator <(Real x1, double x2) => x1.Data < x2;
        public static bool operator <(Real x1, Real x2) => x1.Data < x2.Data;

        public static bool operator >=(double x1, Real x2) => x1 >= x2.Data;
        public static bool operator >=(Real x1, double x2) => x1.Data >= x2;
        public static bool operator >=(Real x1, Real x2) => x1.Data >= x2.Data;

        public static bool operator <=(double x1, Real x2) => x1 <= x2.Data;
        public static bool operator <=(Real x1, double x2) => x1.Data <= x2;
        public static bool operator <=(Real x1, Real x2) => x1.Data <= x2.Data;
    }
}
