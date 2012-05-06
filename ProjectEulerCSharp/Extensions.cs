using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerCSharp
{
    public static class Extensions
    {
        public static IEnumerable<int> ToMax(this int @this)
        {
            return @this.To(int.MaxValue);
        }

        public static IEnumerable<int> To(this int @this, int to)
        {
            return Enumerable.Range(@this, to - @this + 1);
        }

        public static bool IsEven( this int @this )
        {
            return @this.IsEvenlyDivisibleBy(2);
        }

        public static bool IsEvenlyDivisibleBy(this int @this, int divisor)
        {
            return @this % divisor == 0;
        }

        public static IEnumerable<int> TakeWhileLessThan(this IEnumerable<int> @this, int upperBound)
        {
            return @this.TakeWhile(term => term <= upperBound);
        }
    }
}