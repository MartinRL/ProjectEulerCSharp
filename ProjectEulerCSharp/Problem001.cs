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
            0.To(upperBound)
                .Where(i => i.IsEvenlyDivisibleBy(3) || i.IsEvenlyDivisibleBy(5))
                .Sum().Should().Be(expectedSum);
        }
    }
}