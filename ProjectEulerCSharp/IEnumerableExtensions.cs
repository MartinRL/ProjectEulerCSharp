using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ProjectEulerCSharp
{
    public static class IEnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> @this, Action<T> action)
        {
            foreach (var element in @this)
            {
                action(element);
            }
        }

        public static IEnumerable<int> TakeWhileLessThan(this IEnumerable<int> @this, int upperBound)
        {
            return @this.TakeWhile(term => term <= upperBound);
        }

        public static BigInteger Sum(this IEnumerable<BigInteger> @this)
        {
            return @this.Aggregate((t1, t2) => t1 + t2);
        }

        public static int Product(this IEnumerable<int> values)
        {
            return values.Aggregate((a, b) => a * b);
        }

        public static IEnumerable<byte> ToBytes(this IEnumerable<char> @this)
        {
            return @this.Select(c => c.ParseAsByte());
        }

        public static uint Sum(this IEnumerable<byte> @this)
        {
            uint sum = 0;

            @this.ForEach(b => sum = sum + b);

            return sum;
        }

        public static string JoinAsString(this IEnumerable<object> @this, string separator = "")
        {
            return string.Join(separator, @this);
        }
    }
}
