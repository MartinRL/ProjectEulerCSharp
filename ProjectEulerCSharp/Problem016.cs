using System.Numerics;
using FluentAssertions;
using Xunit;

namespace ProjectEulerCSharp
{
    public class Problem016
    {
        [Fact]
        public void should_find_he_sum_of_the_digits_of_2_raised_to_the_power_of_1000()
        {
            var twoRaisedToThePowerOf1000 = new BigInteger(1) << 1000;

            twoRaisedToThePowerOf1000
                    .ToString()
                    .ToBytes()
                    .Sum()
                    .Should().Be(1366);
        }
    }
}
