using System;
using System.Globalization;
using Xunit;

namespace CastingConversionParsing.Tests
{
    public class ConversionTests
    {
        [Theory]
        [InlineData(5.1, 5)]
        [InlineData(5.4999, 5)]
        [InlineData(5.5, 6)]
        [InlineData(5.99999, 6)]
        public void ShouldConvertWithRoundingWhenNarrowing(double input, int expected)
        {
            Assert.Equal(expected, Convert.ToInt32(input));
        }

        [Fact]
        public void ShouldConvertFromIntToText()
        {
            const int number = 99;
            Assert.Equal("99", number.ToString());
        }

        [Fact]
        public void ShouldConvertFromFloatToText()
        {
            const float number = 5.4f;
            Assert.Equal("5.4", number.ToString(CultureInfo.InvariantCulture));
        }

        [Fact]
        public void ShouldConvertFromDoubleToText()
        {
            const double number = -532.123;
            Assert.Equal("-532.123", number.ToString(CultureInfo.InvariantCulture));
        }
    }
}
