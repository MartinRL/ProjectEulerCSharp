using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ProjectEulerCSharp
{
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

        /// <summary>
        /// http://mathworld.wolfram.com/BinomialCoefficient.html
        /// </summary>
        public static BigInteger Choose(this int n, int k)
        {
            return n.BigFactorial() / ((n - k).BigFactorial() * k.BigFactorial());
        }

        public static BigInteger BigFactorial(this int @this)
        {
            if (@this == 1)
                return @this;

            return @this * BigFactorial(@this - 1);
        }

        public static int Pow(this int @this, int power)
        {
            return (int)Math.Pow(@this, power);
        }

        public static string AsWord(this int @this)
        {
            const string HUNDRED = "hundred";
            const string ONE = "one";

            var thisAsString = @this.ToString();

            if (@this < 100 && ((NumberAsWord)@this).ToString() != thisAsString)
                return ((NumberAsWord)@this).ToString();

            if (@this > 20 && @this < 100)
                return thisAsString.ToCharArray().Reverse()
                    .Select((c, i) => c.ParseAsInt() * 10.Pow(i)).Reverse()
                    .Select(t => ((NumberAsWord)t).ToString())
                    .JoinAsString(" ");

            if (@this > 100 && @this < 1000)
            {
                var numberOfHundreds = thisAsString.ToCharArray().First().ParseAsInt();

                var thisMinusTheHundreds = @this - numberOfHundreds * 100;

                if (thisMinusTheHundreds == 0)
                    return ((NumberAsWord)numberOfHundreds) + " " + HUNDRED;

                return ((NumberAsWord)numberOfHundreds)
                       + " " + HUNDRED + " and "
                       + AsWord(thisMinusTheHundreds);
            }

            if (@this == 100)
                return ONE + " " + HUNDRED;

            if (@this == 1000)
                return ONE + " thousand";

            throw new NotSupportedException("{0} is unsupported as of now".FormatWith(thisAsString));
        }

        internal enum NumberAsWord
        {
            one = 1,
            two = 2,
            three = 3,
            four = 4,
            five = 5,
            six = 6,
            seven = 7,
            eight = 8,
            nine = 9,
            ten = 10,
            eleven = 11,
            twelve = 12,
            thirteen = 13,
            fourteen = 14,
            fifteen = 15,
            sixteen = 16,
            seventeen = 17,
            eighteen = 18,
            nineteen = 19,
            twenty = 20,
            thirty = 30,
            forty = 40,
            fifty = 50,
            sixty = 60,
            seventy = 70,
            eighty = 80,
            ninety = 90
        }
    }
}
