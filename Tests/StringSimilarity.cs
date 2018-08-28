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
        public void LevenstainMethodForVariousStrings(string source, string target)
        {
            var result = LevenstainDistance.CalculateSimilarity(source, target);
            Assert.True( result < 1 && result > 0);
        }

        [Fact]
        public void DiceCoefficientForEqualStrings()
        {
            var string1 = "system under test";
            var string2 = string1;

            Assert.True(DiceCoefficient.DiceCoefficientCount(string1, string2) == 1);
        }

        [Theory]
        [InlineData("tests aaaa", "bbbb tests")]
        public void DiceCoefficientForVariousStrings(string source, string target)
        {
            var result = DiceCoefficient.DiceCoefficientCount(source, target);
      
            var expected = (2.0 * 6) / (source.Length + target.Length);
            Assert.True(Math.Round(result, 1) == Math.Round(expected, 1));
        }
    }
}
