using System;
using System.Collections.Generic;
using System.Text;

namespace Shone
{
    public static class MyString
    {
        public static readonly string DigitCode10 = "0123456789";
        public static char[] Digit10Chars = DigitCode10.ToCharArray();
        public static char[] SplitDotChars = new char[] { '\\', '.' };
        public static char[] ExpSplitChars = new char[] { 'E', 'e' };

        static Dictionary<string, string> stringCaches = new Dictionary<string, string>(10240);
        public static string CacheString(string s)
        {
            if (s != null && string.IsInterned(s) == null && !stringCaches.ContainsKey(s))
            {
                stringCaches[s] = s;
            }
            return s;
        }
    }
}
