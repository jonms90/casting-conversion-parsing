using Xunit;

namespace CastingConversionParsing.Tests
{
    public class CastingTests
    {
        [Theory]
        [InlineData(3.0, 3)]
        [InlineData(3.5, 3)]
        [InlineData(3.9, 3)]
        [InlineData(3.99999, 3)]
        public void ShouldTruncateWhenNarrowing(double input, int expected)
        {
            int actual = (int)input;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 3)]
        [InlineData(123, 123)]
        [InlineData(-3000, -3000)]
        [InlineData(999999, 999999)]
        public void ShouldSupportWideningImplicitly(int input, double expected)
        {
            double actual = input;
            Assert.Equal(expected, actual);
        }
    }
}
