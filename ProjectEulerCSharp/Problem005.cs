using System.Linq;
using FluentAssertions;
using Xunit.Extensions;

namespace ProjectEulerCSharp
{
    public class Problem005
    {
        [Theory]
        [InlineData(10, 2520)]
        [InlineData(20, 232792560)]
        public void should_find_smallest_positive_number_evenly_divisible_by_divisors(int upperBound, int expected)
        {
            var divisors = 1.To(upperBound);

            var actual = upperBound.ToMax()
                .Where(term => term.IsEven())
                .First(term => divisors.All(divisor => term.IsEvenlyDivisibleBy(divisor)));

            actual.Should().Be(expected);
        }
    }
}