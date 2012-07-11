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
            var result = 1.ToUint(999999)
                .Select(t => new {Term = t, Count = GetChainCountFor(t)})
                .OrderByDescending(tc => tc.Count)
                .First();

            result.Term.Should().Be(837799);
            result.Count.Should().Be(524);
        }

        private static ulong GetChainCountFor(uint startingNumber)
        {
            ulong chainCount = 0;

            while (startingNumber != 1)
            {
                if (startingNumber % 2 == 0)
                    startingNumber = startingNumber / 2;
                else
                    startingNumber = 3 * startingNumber + 1;

                chainCount++;
            }
            return chainCount;
        }
    }
}
