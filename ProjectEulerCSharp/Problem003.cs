using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit.Extensions;

namespace ProjectEulerCSharp
{
    public class Problem003
    {
        [Theory]
        [InlineData(13195, 29)]
        [InlineData(600851475143, 6857)]
        public void should_find_largest_prime_factor(long term, int expectedLargestPrimeFactor)
        {
            var actualLargestPrimeFactor = term.CalculateMaxFactor().ToMin()
                .First(t => t.IsPrime() && term.IsEvenlyDivisibleBy(t));

            actualLargestPrimeFactor.Should().Be(expectedLargestPrimeFactor);
        }
    }
}