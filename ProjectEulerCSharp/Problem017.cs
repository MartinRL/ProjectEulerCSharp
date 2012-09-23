using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace ProjectEulerCSharp
{
    public class Problem017
    {
        [Fact]
        public void should_find_the_number_of_letters_of_1_to_1000_written_out_in_words()
        {
            1.To(1000)
            .Select(t => t.AsWord())
            .JoinAsString()
            .RemoveAll(" ")
            .Count()
            .Should().Be(21124);
        }
    }
}
