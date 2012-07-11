using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ProjectEulerCSharp
{
    public static class IEnumerableExtensions
    {
        public static void ForEach<T>( this IEnumerable<T> @this, Action<T> action )
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
    }

    public static class IntExtensions
    {
        public static IEnumerable<long> To(this int @this, long to)
        {
            if (@this < to)
            {
                while (@this <= to)
                    yield return @this++;
            }
            else
            {
                while (@this >= to)
                    yield return @this--;
            }
        }

        public static IEnumerable<int> ToMax(this int @this)
        {
            return @this.To(Int32.MaxValue);
        }

        public static IEnumerable<int> To(this int @this, int to)
        {
            return Enumerable.Range(@this, to - @this + 1);
        }

        public static IEnumerable<uint> ToUint(this int @this, uint to)
        {
            for (var i = (uint)@this; i <= to; i++)
                yield return i;
        }

        public static bool IsEven(this int @this)
        {
            return @this.IsEvenlyDivisibleBy(2);
        }

        public static bool IsEven(this uint @this)
        {
            return @this % 2 == 0;
        }

        public static bool IsEvenlyDivisibleBy(this int @this, int divisor)
        {
            return @this % divisor == 0;
        }

        public static int CalculateMaxFactor(this int @this)
        {
            return (int)Math.Sqrt(@this);
        }

        public static int Sqr(this int @this)
        {
            return @this * @this;
        }

        public static int Sqrt(this int @this)
        {
            return (int)Math.Sqrt(@this);
        }

        /// <summary>
        /// Spec: http://www.math.mtu.edu/mathlab/COURSES/holt/dnt/divis2.html
        /// </summary>
        public static int NumberOfDivisors(this int @this)
        {
            if (@this == 1)
                return 1;

            // 2do: subtract one if @this is a «perfect square»
            return 1.To(@this.Sqrt()).Count(t => @this.IsEvenlyDivisibleBy(t)) * 2;
        }
    }

    public static class LongExtensions
    {
        public static IEnumerable<long> ToMin(this long @this)
        {
            return @this.To(Int64.MinValue);
        }

        public static IEnumerable<long> To(this long @this, long to)
        {
            if (@this < to)
            {
                while (@this <= to)
                    yield return @this++;
            }
            else
            {
                while (@this >= to)
                    yield return @this--;
            }
        }

        public static bool IsEven(this long @this)
        {
            return @this.IsEvenlyDivisibleBy(2);
        }

        public static bool IsEvenlyDivisibleBy(this long @this, long divisor)
        {
            return @this % divisor == 0;
        }

        public static long CalculateMaxFactor(this long @this)
        {
            return (long)Math.Sqrt(@this);
        }
    }

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
            return Int32.Parse(@this);
        }
    }
}
