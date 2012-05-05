using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerCSharp
{
    public static class Extensions
    {
        public static IEnumerable<int> To(this int @this, int to)
        {
            return Enumerable.Range(@this, to - @this + 1);
        }

        public static bool IsEvenlyDivisibleBy(this int @this, int divisor)
        {
            return @this % divisor == 0;
        }
    }
}