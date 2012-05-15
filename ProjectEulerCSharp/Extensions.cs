using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerCSharp
{
    public static class Extensions
    {
        public static IEnumerable<long> ToMin(this long @this)
        {
            return @this.To(long.MinValue);
        }

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

        public static IEnumerable<int> ToMax(this int @this)
        {
            return @this.To(int.MaxValue);
        }

        public static IEnumerable<int> To(this int @this, int to)
        {
            return Enumerable.Range(@this, to - @this + 1);
        }

        public static bool IsEven(this int @this)
        {
            return @this.IsEvenlyDivisibleBy(2);
        }

        public static bool IsEven(this long @this)
        {
            return @this.IsEvenlyDivisibleBy(2);
        }

        public static bool IsEvenlyDivisibleBy(this int @this, int divisor)
        {
            return @this % divisor == 0;
        }

        public static bool IsEvenlyDivisibleBy(this long @this, long divisor)
        {
            return @this % divisor == 0;
        }

        public static IEnumerable<int> TakeWhileLessThan(this IEnumerable<int> @this, int upperBound)
        {
            return @this.TakeWhile(term => term <= upperBound);
        }

        public static bool IsPrime(this long @this)
        {
            if (@this == 2)
                return true;

            if (@this.IsEven())
                return false;

            var maxFactor = @this.CalculateMaxFactor();
            for (var t = 3; t <= maxFactor; t = t + 2)
            {
                if (@this.IsEvenlyDivisibleBy(t))
                    return false;
            }

            return @this != 1;
        }

        public static long CalculateMaxFactor(this long @this)
        {
            return (long)Math.Sqrt(@this);
        }

        public static bool IsPrime(this int @this)
        {
            if (@this == 2)
                return true;

            if (@this.IsEven())
                return false;

            var maxFactor = @this.CalculateMaxFactor();
            for (var t = 3; t <= maxFactor; t = t + 2)
            {
                if (@this.IsEvenlyDivisibleBy(t))
                    return false;
            }

            return @this != 1;
        }

        public static int CalculateMaxFactor(this int @this)
        {
            return (int)Math.Sqrt(@this);
        }

        public static int Sqr(this int @this)
        {
            return @this * @this;
        }

        public static int ParseAsInt(this char @this)
        {
            return ParseAsInt(new string(@this, 1));
        }

        public static int ParseAsInt(this string @this)
        {
            return int.Parse(@this);
        }

        public static int Sqrt(this int @this)
        {
            return (int)Math.Sqrt(@this);
        }

        public static int Product(this IEnumerable<int> values)
        {
            return values.Aggregate((a, b) => a * b);
        }

        /// <summary>
        /// Spec: http://www.math.mtu.edu/mathlab/COURSES/holt/dnt/divis2.html
        /// </summary>
        public static int NumberOfDivisors(this int @this)
        {
            if (@this == 1)
                return 1;

            // 2do: subtract one if @this is a «perfect square»
            return 1.To(@this.Sqrt())
                       .Count(t => @this.IsEvenlyDivisibleBy(t)) * 2;
        }
    }
}
