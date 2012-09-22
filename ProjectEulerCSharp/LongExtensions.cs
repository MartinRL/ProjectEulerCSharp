using System;
using System.Collections.Generic;

namespace ProjectEulerCSharp
{
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
}
