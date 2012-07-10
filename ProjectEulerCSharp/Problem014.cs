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
            uint startingNumberOfLongestChain = 0;
            ulong longestChainCount = 0;

            for (uint i = 1; i < 1000000; i++)
            {
                var member = i;
                ulong chainCount = 0;

                while (member != 1)
                {
                    if (member % 2 == 0)
                        member = member / 2;
                    else
                        member = 3 * member + 1;

                    chainCount++;
                }

                if (longestChainCount < chainCount)
                {
                    longestChainCount = chainCount;
                    startingNumberOfLongestChain = i;
                }
            }

            startingNumberOfLongestChain.Should().Be(837799);
            longestChainCount.Should().Be(524);
        }
    }
}
