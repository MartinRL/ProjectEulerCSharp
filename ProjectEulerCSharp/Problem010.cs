using System.Linq;
using FluentAssertions;
using Xunit.Extensions;

namespace ProjectEulerCSharp
{
    public class Problem010
    {
        [Theory]
        [InlineData(10, 17)]
        [InlineData(2000000, 142913828922)]
        public void should_find_the_sum_of_all_the_primes(long upperBound, long expected)
        {
            1.To(upperBound)
                .Where(t => t.IsPrime())
                .Sum()
                .Should().Be(expected);
        }
    }
}
