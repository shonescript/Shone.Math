using System;
using System.Collections.Generic;
using System.Text;

namespace Shone
{
    public static class MyDouble
    {
        /// <summary>
        /// 计算两个整数的最小公倍数
        /// </summary>
        public static double Lcm(double a, double b)
        {
            return a * b / Gcd(a, b);
        }
        /// <summary>
        /// 根据欧几里德算法，计算两个整数的最大公约数
        /// </summary>
        public static double Gcd(double a, double b)
        {
            if (a == 0) return b;
            if (b == 0) return a;
            if (a == b) return a;
            if (b < 0) b = -b;
            if (a < 0) a = -a;
            if (a == 1 || b == 1) return 1;
            return a < b ? gcd(b, a) : gcd(a, b);
        }
        public static double gcd(this double n1, double n2)
        {
            while (n2 != 0)
            {
                double d = n1 % n2;
                n1 = n2;
                n2 = d;
            }
            return n1;
        }

        unsafe public static bool IsMisc(this double d)
        {
            return *(byte*)&d != 0;
        }
        unsafe public static bool IsNotMisc(this double d)
        {
            return *(byte*)&d == 0;
        }
        public static bool TryRound_(this ref double d)
        {
            double n = Math.Round(d, MidpointRounding.AwayFromZero);
            double delta = d - n;
            if (delta > -1E-15 && delta < 1E-15)
            {
                d = n;
                return true;
            }
            return false;
        }
    }
}
