using Xunit;
using System;

namespace RomanNumerals.Kata.Tests
{
    public class UnitTests
    {
        [Fact]
        public void ConvertValue_OneToI()
        {
            int input = 1;

            string output = RomanNumerals.ConvertValue(input);

            Assert.Equal("I", output);
        }

        [Fact]
        public void ConvertValue_TwoToII()
        {
            int input = 2;

            string output = RomanNumerals.ConvertValue(input);

            Assert.Equal("II", output);
        }

        [Fact]
        public void ConvertValue_FourToIV()
        {
            int input = 4;

            string output = RomanNumerals.ConvertValue(input);

            Assert.Equal("IV", output);
        }

        [Fact]
        public void ConvertValue_FiveToV()
        {
            int input = 5;

            string output = RomanNumerals.ConvertValue(input);

            Assert.Equal("V", output);
        }

        [Fact]
        public void ConvertValue_EightToVIII()
        {
            int input = 8;

            string output = RomanNumerals.ConvertValue(input);

            Assert.Equal("VIII", output);
        }

        [Fact]
        public void ConvertValue_NineToIX()
        {
            int input = 9;

            string output = RomanNumerals.ConvertValue(input);

            Assert.Equal("IX", output);
        }

        [Fact]
        public void ConvertValue_TenToX()
        {
            int input = 10;

            string output = RomanNumerals.ConvertValue(input);

            Assert.Equal("X", output);
        }

        [Fact]
        public void ConvertValue_TwentyEightToXXVIII()
        {
            int input = 28;

            string output = RomanNumerals.ConvertValue(input);

            Assert.Equal("XXVIII", output);
        }

        [Fact]
        public void ConvertValue_ThirtyTwoToXXXII()
        {
            int input = 32;

            string output = RomanNumerals.ConvertValue(input);

            Assert.Equal("XXXII", output);
        }

        [Fact]
        public void ConvertValue_FortyTwoToXLII()
        {
            int input = 42;

            string output = RomanNumerals.ConvertValue(input);

            Assert.Equal("XLII", output);
        }

        [Fact]
        public void ConvertValue_FiftyFiveToLV()
        {
            int input = 55;

            string output = RomanNumerals.ConvertValue(input);

            Assert.Equal("LV", output);
        }

        [Fact]
        public void ConvertValue_NinetyToXC()
        {
            int input = 90;

            string output = RomanNumerals.ConvertValue(input);

            Assert.Equal("XC", output);
        }

        [Fact]
        public void ConvertValue_OneHundredSixtySevenToCLXVII()
        {
            int input = 167;

            string output = RomanNumerals.ConvertValue(input);

            Assert.Equal("CLXVII", output);
        }

        [Fact]
        public void ConvertValue_TwoHundredFiftySixtoCCLVI()
        {
            int input = 256;

            string output = RomanNumerals.ConvertValue(input);

            Assert.Equal("CCLVI", output);
        }

        [Fact]
        public void ConvertValue_ThreeHundredEightyNineToCCCLXXXIX()
        {
            int input = 389;

            string output = RomanNumerals.ConvertValue(input);

            Assert.Equal("CCCLXXXIX", output);
        }

        [Fact]
        public void ConvertValue_FourHundredTwentyEightToCDXXVIII()
        {
            int input = 428;

            string output = RomanNumerals.ConvertValue(input);

            Assert.Equal("CDXXVIII", output);
        }

        [Fact]
        public void ConvertValue_NineHundredToCM()
        {
            int input = 900;

            string output = RomanNumerals.ConvertValue(input);

            Assert.Equal("CM", output);
        }

        [Fact]
        public void ReduceValue_IIIToIV()
        {
            string input = "IIII";

            string output = RomanNumerals.ReduceValue(input);

            Assert.Equal("IV", output);
        }

        [Fact]
        public void ConvertValue_NegativeNumber_ThrowsOutOfRangeException()
        {
            int input = -1;

            string output = RomanNumerals.ConvertValue(input);

            Assert.Throws<ArgumentOutOfRangeException>(() => { RomanNumerals.CheckNegative(input); });
        }
    }
}