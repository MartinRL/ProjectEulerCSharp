using System;
using System.Linq;
using FluentAssertions;
using Xunit.Extensions;

namespace ProjectEulerCSharp
{
    public class Problem001
    {
        [Theory]
        [InlineData(9, 23)]
        [InlineData(999, 233168)]
        public void should_find_sum_of_multiples_of_3_or_5_for_upper_bound(int upperBound, int expectedSum)
        {
            var finder = new MultiplesOf3or5Finder(upperBound);

            var actualSum = finder.Find();

            actualSum.Should().Be(expectedSum);
        }

        public class MultiplesOf3or5Finder
        {
            private readonly int upperBound;

            public MultiplesOf3or5Finder(int upperBound)
            {
                this.upperBound = upperBound;
            }

            public int Find()
            {
                return 0.To(upperBound)
                    .Where(i => i.IsEvenlyDivisibleBy(3)
                             || i.IsEvenlyDivisibleBy(5))
                    .Sum();
            }
        }
    }
}