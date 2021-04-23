using System;

namespace RomanNumerals.Kata
{
    public class RomanNumerals
    {
        // Method that takes an integer value that builds a string of Roman numerals from the value of the input
        public static string ConvertValue(int input)
        {
            string output = "";
            int count;

            // Series of checks to find highest denominator of Roman numeral to match with input
            if (input / 10 > 0)
            {
                count = input / 10;
                output = BuildRomanNumeral(output, count, "X");
            }
            else if (input / 5 > 0)
            {
                count = input / 5;
                output = BuildRomanNumeral(output, count, "V");
            }
            else if (input / 4 > 0)
            {
                count = 1;
                output = BuildRomanNumeral(output, count, "IV");
            }
            else if (input / 1 > 0)
            {
                count = input;
                output = BuildRomanNumeral(output, count, "I");
            }

            return output;
        }

        // Method that takes an input string, an integer to use as a counter, and a string to represent the Roman
        // numeral to append to the input string.
        public static string BuildRomanNumeral(string input, int count, string roman)
        {
            string output = input;

            for (int i = 0; i < count; i++)
            {
                output = output.Insert(output.Length, roman);
            }

            return output;
        }

        public static string ReduceValue(string input)
        {
            if (input == "IIII")
            {
                return "IV";
            }

            if (input == "IVI")
            {
                return "V";
            }

            return input;
        }

        public static int CheckNegative(int input)
        {
            if (input < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            return input;
        }
    }
}