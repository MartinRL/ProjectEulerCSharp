using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;
using Xunit.Extensions;

namespace ProjectEulerCSharp
{
    public class Problem014
    {
        [Fact]
        public void should_find_the_starting_number_less_than_1000000_that_produces_the_longest_chain()
        {
            var result = 2.ToUint(999999)
                .Select(t => new {Term = t, Count = GetChainCountFor(t)})
                .OrderByDescending(tc => tc.Count)
                .First();

            result.Term.Should().Be(837799);
            result.Count.Should().Be(524);
        }

        private static ulong GetChainCountFor(uint startingNumber, ulong count = (ulong)0)
        {
            if (startingNumber == 1)
                return count;

            return GetChainCountFor(startingNumber % 2 == 0 ? startingNumber / 2 : 3 * startingNumber + 1, ++count);
        }
    }
}
