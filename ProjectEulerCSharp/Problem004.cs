using FluentAssertions;
using Xunit.Extensions;
using System.Linq;

namespace ProjectEulerCSharp
{
    public class Problem004 : Problem
    {
        [Theory]
        [InlineData(99, 9009)]
        [InlineData(999, 906609)]
        public void should_find_largest_palindromic_number(int maxFactor, int expectedPalindromicNumber)
        {
            var firstFactorSequence = 0.To(maxFactor);
            var secondFactorSequence = 0.To(maxFactor);

            var actualPalindromicNumber = firstFactorSequence
                .SelectMany(firstFactor => secondFactorSequence.Select(secondFactor => firstFactor * secondFactor))
                .Where(IsPalindrome)
                .Max();

            actualPalindromicNumber.Should().Be(expectedPalindromicNumber);
        }
    }
}