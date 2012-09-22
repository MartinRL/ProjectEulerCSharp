using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerCSharp
{
    public static class StringExtensions
    {
        public static IEnumerable<string> SplitWithNewLineSeparator(this string @this)
        {
            return @this.Split(Environment.NewLine.ToCharArray()[0]);
        }

        public static string Truncate(this string @this, int length)
        {
            return @this.Substring(0, length);
        }

        public static int ParseAsInt(this string @this)
        {
            return int.Parse(@this);
        }

        public static string FormatWith(this string @this, params object[] args)
        {
            return string.Format(@this, args);
        }

        public static string RemoveAll(this string @this, string remove)
        {
            return @this.Replace(remove, string.Empty);
        }
    }
}
