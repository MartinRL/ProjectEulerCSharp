using System.Linq;
using FluentAssertions;
using Xunit.Extensions;

namespace ProjectEulerCSharp
{
    public class Problem010
    {
        [Theory]
        [InlineData(10, 17)]
        [InlineData(2000000, 1)]
        public void find_the_sum_of_all_the_primes(int upperBound, int expected)
        {
            1.To(upperBound)
                .Where(t => t.IsPrime())
                .Sum()
                .Should().Be(expected);
        }
    }
}
