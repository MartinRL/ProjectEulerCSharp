using System.Linq;
using FluentAssertions;
using Xunit.Extensions;

namespace ProjectEulerCSharp
{
    public class Problem007
    {
        [Theory]
        [InlineData(5, 13)]
        [InlineData(10000, 104743)]
        public void should_find_prime_for_given_index(int index, int expectedPrime)
        {
            var actualPrime = 1.ToMax().Where(t => t.IsPrime()).ElementAt(index);

            actualPrime.Should().Be(expectedPrime);
        }
    }
}