using System.Linq;

namespace ProjectEulerCSharp
{
    public abstract class Problem
    {
        public static bool IsPrime(long term)
        {
            if (term == 2)
                return true;

            if (term.IsEven())
                return false;

            var maxFactor = term.CalculateMaxFactor();
            for (var t = 3; t <= maxFactor; t = t + 2)
            {
                if (term.IsEvenlyDivisibleBy(t))
                    return false;
            }

            return term != 1;
        }

        public static bool IsPrime(int term)
        {
            if (term == 2)
                return true;

            if (term.IsEven())
                return false;

            var maxFactor = term.CalculateMaxFactor();
            for (var t = 3; t <= maxFactor; t = t + 2)
            {
                if (term.IsEvenlyDivisibleBy(t))
                    return false;
            }

            return term != 1;
        }

        protected static bool IsEven(int term)
        {
            return term.IsEven();
        }

        protected static int ParseAsInt(char @this)
        {
            return int.Parse(@this.ToString());
        }

        protected static bool IsPalindrome(int term)
        {
            return term.ToString().SequenceEqual(term.ToString().Reverse());
        }

        public static int Sqr(int term)
        {
            return term.Sqr();
        }

        protected int TriangleNumber(int term)
        {
            return 1.To(term).Sum();
        }
    }
}
