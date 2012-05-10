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

        public static IEnumerable<long> To(this long @this, long to)
        {
            while (@this >= to)
                yield return @this--;
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
                if (@this % t == 0) return false;
            }

            return @this != 1;
        }

        public static long CalculateMaxFactor(this long @this)
        {
            return (long) Math.Sqrt(@this);
        }

        public static int Sqr(this int @this)
        {
            return @this * @this;
        }
    }
}