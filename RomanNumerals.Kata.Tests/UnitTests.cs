using Xunit;

namespace RomanNumerals.Kata.Tests
{
    public class UnitTests
    {
        [Fact]
        public void OneEqualsI()
        {
            int input = 1;
            string output = RomanNumerals.ConvertValue(input);
            Assert.Equal("I", output);
        }
    }
}
