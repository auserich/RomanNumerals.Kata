using Xunit;
using System;

namespace RomanNumerals.Kata.Tests
{
    /// <summary>
    /// Contains unit tests in order to test the functionality of the RomanNumeral class's ConvertNumberToRomanNumeral method.
    /// </summary>
    public class UnitTests
    {
        [Fact]
        public void ConvertNumberToRomanNumeral_OneToI()
        {
            int input = 1;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("I", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_TwoToII()
        {
            int input = 2;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("II", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_ThreeToIII()
        {
            int input = 3;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("III", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_FourToIV()
        {
            int input = 4;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("IV", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_FiveToV()
        {
            int input = 5;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("V", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_EightToVIII()
        {
            int input = 8;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("VIII", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_NineToIX()
        {
            int input = 9;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("IX", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_TenToX()
        {
            int input = 10;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("X", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_TwentyEightToXXVIII()
        {
            int input = 28;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("XXVIII", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_ThirtyTwoToXXXII()
        {
            int input = 32;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("XXXII", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_FortyTwoToXLII()
        {
            int input = 42;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("XLII", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_FiftyFiveToLV()
        {
            int input = 55;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("LV", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_NinetyToXC()
        {
            int input = 90;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("XC", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_OneHundredSixtySevenToCLXVII()
        {
            int input = 167;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("CLXVII", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_TwoHundredFiftySixtoCCLVI()
        {
            int input = 256;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("CCLVI", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_ThreeHundredEightyNineToCCCLXXXIX()
        {
            int input = 389;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("CCCLXXXIX", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_FourHundredTwentyEightToCDXXVIII()
        {
            int input = 428;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("CDXXVIII", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_FiveHundredToD()
        {
            int input = 500;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("D", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_NineHundredToCM()
        {
            int input = 900;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("CM", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_OneThousandToM()
        {
            int input = 1000;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("M", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_TwoThousandSixHundredThirtyNineToMMDCXXXIX()
        {
            int input = 2639;

            string output = RomanNumerals.ConvertNumberToRomanNumeral(input);

            Assert.Equal("MMDCXXXIX", output);
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_NegativeNumber_ThrowsOutOfRangeException()
        {
            int input = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() => { RomanNumerals.ConvertNumberToRomanNumeral(input); });
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_BeyondUpperLimit_ThrowsOutOfRangeException()
        {
            int input = 4000;

            Assert.Throws<ArgumentOutOfRangeException>(() => { RomanNumerals.ConvertNumberToRomanNumeral(input); });
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_NegativeFour_ThrowsOutOfRangeException()
        {
            int input = -4;

            Assert.Throws<ArgumentOutOfRangeException>(() => { RomanNumerals.ConvertNumberToRomanNumeral(input); });
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_FourThousandFortyTwo_ThrowsOutOfRangeException()
        {
            int input = 4042;

            Assert.Throws<ArgumentOutOfRangeException>(() => { RomanNumerals.ConvertNumberToRomanNumeral(input); });
        }

        [Fact]
        public void ConvertNumberToRomanNumeral_Zero_ThrowsNullException()
        {
            int input = 0;

            Assert.Throws<ArgumentException>(() => { RomanNumerals.ConvertNumberToRomanNumeral(input); });
        }
         
    }
}