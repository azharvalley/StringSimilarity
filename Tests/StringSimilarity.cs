using System;
using Xunit;
using StringSimilarity;

namespace Tests
{
    public class StringSimilarity
    {
        [Fact]
        public void LevenstainMethodForEqualStrings()
        {
            var string1 = "system under test";
            var string2 = string1;

            Assert.True(LevenstainDistance.CalculateSimilarity(string1, string2) == 1);
        }

        [Theory]
        [InlineData("test string", "another test")]
        [InlineData("another string", "another test")]
        [InlineData("another test", "another string")]
        public void LevenstainMethodForVariousString(string source, string target)
        {
            var result = LevenstainDistance.CalculateSimilarity(source, target);
            Assert.True( result < 1 && result > 0);
        }
    }
}
