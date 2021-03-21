using System.Globalization;
using Xunit;

namespace CastingConversionParsing.Tests
{
    public class ParsingTests
    {
        [Fact]
        public void TryParseReturnsTrueWhenSuccess()
        {
            Assert.True(int.TryParse("123", out int _));
        }

        [Fact]
        public void TryParseReturnsFalseWhenFailing()
        {
            Assert.False(int.TryParse("invalid", out int _));
        }

        [Fact]
        public void TryParseSuppliesParsedIntValueOut()
        {
            int.TryParse("5", out int actual);
            Assert.Equal(5, actual);
        }

        [Fact]
        public void TryParseSuppliesParsedDoubleValueOut()
        {
            double.TryParse("5.5", NumberStyles.AllowDecimalPoint, new NumberFormatInfo { NumberDecimalSeparator = "." }, out double actual);
            Assert.Equal(5.5, actual);
        }

        [Fact]
        public void TryParseCultureSpecificDoubleValueOut()
        {
            double.TryParse("5,5", out double actual); // Norway uses comma as decimal separator.
            Assert.Equal(5.5, actual);
        }
    }
}
