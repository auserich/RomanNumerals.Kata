using System;
using System.Text;

namespace RomanNumerals.Kata
{
    /// <summary>
    /// Used for converting a numeric value into its Roman numeral equivalent.
    /// Supports conversions for values between 1 - 3999.
    /// </summary>
    public class RomanNumerals
    {
        /// <summary>
        /// Takes an integer value that builds a string of Roman numerals from the value of the input.
        /// </summary>
        /// <param name="number">Number that will be converted to Roman numeral.</param>
        /// <returns>Return a string that is the Roman numeral for the number inputted.</returns>
        public static string ConvertNumberToRomanNumeral(int number)
        {
            CheckIfValidNumber(number); // checks legal input is being converted

            // Create variables for conversion
            StringBuilder output = new StringBuilder();
            int count;
            int denominator;
            string roman = string.Empty;

            // Loop through input value while removing its current largest denominator and building a Roman numeral
            // from the given value
            while (number > 0)
            {
                roman = GetRomanNumeral(number);
                denominator = GetDecimalValue(roman);
                count = number / denominator;
                output = BuildRomanNumeral(output, count, roman);
                number -= (denominator * count);
            }

            return output.ToString();
        }

        /// <summary>
        /// Returns the Roman numeral associated with the numeric value passed in.
        /// </summary>
        /// <param name="number">Number that is passed in to identify its Roman numeral value.</param>
        /// <returns>Returns a string that is the Roman numeral value for the number passed in.</returns>
        private static string GetRomanNumeral(int number)
        {
            if (number / 1000 > 0)
                return "M";
            else if (number / 900 > 0)
                return "CM";
            else if (number / 500 > 0)
                return "D";
            else if (number / 400 > 0)
                return "CD";
            else if (number / 100 > 0)
                return "C";
            else if (number / 90 > 0)
                return "XC";
            else if (number / 50 > 0)
                return "L";
            else if (number / 40 > 0)
                return "XL";
            else if (number / 10 > 0)
                return "X";
            else if (number / 9 > 0)
                return "IX";
            else if (number / 5 > 0)
                return "V";
            else if (number / 4 > 0)
                return "IV";

            return "I";
        }

        /// <summary>
        /// Returns the value associated with the Roman numeral value passed in.
        /// </summary>
        /// <param name="roman">Roman numeral that is passed in to identify the numeric value associated with it.</param>
        /// <returns>Returns the numeric value for the Roman numeral passed in.</returns>
        private static int GetDecimalValue(string roman)
        {
            if (roman == "M")
                return 1000;
            else if (roman == "CM")
                return 900;
            else if (roman == "D")
                return 500;
            else if (roman == "CD")
                return 400;
            else if (roman == "C")
                return 100;
            else if (roman == "XC")
                return 90;
            else if (roman == "L")
                return 50;
            else if (roman == "XL")
                return 40;
            else if (roman == "X")
                return 10;
            else if (roman == "IX")
                return 9;
            else if (roman == "V")
                return 5;
            else if (roman == "IV")
                return 4;

            return 1;
        }

        /// <summary>
        /// Builds a Roman numeral value from the values passed in.
        /// </summary>
        /// <param name="input">StringBuilder that will represent the final Roman numeral value for the numeric value being converted.</param>
        /// <param name="count">Number of times the given Roman numeral will need to be appended to the string.</param>
        /// <param name="roman">Roman numeral that will be appended to the string.</param>
        /// <returns>Returns string that is the input string with newly appended Roman numerals.</returns>
        private static StringBuilder BuildRomanNumeral(StringBuilder input, int count, string roman)
        {
            for (int i = 0; i < count; i++)
                input.Append(roman);

            return input;
        }

        /// <summary>
        /// Checks if the number being passed in is a valid number to be converted to Roman numeral.
        /// </summary>
        /// <param name="number">Number that is being validated.</param>
        /// <exception cref="ArgumentOutOfRangeException">Exception that will be thrown if the number passed in it outside
        /// of the allowed range.</exception>
        private static void CheckOutOfRange(int number)
        {
            if (number < 0 || number >= 4000)
                throw new ArgumentOutOfRangeException();
        }

        /// <summary>
        /// Checks if the number being passed in is a non-zero number.
        /// </summary>
        /// <param name="number">Number that is being validated.</param>
        /// <exception cref="ArgumentException">Exception that will be thrown if the number is 0.</exception>
        private static void CheckIfZero(int number)
        {
            if (number == 0)
                throw new ArgumentException();
        }

        /// <summary>
        /// Helps validate that the number passed in is safe to be converted to Roman numerals.
        /// </summary>
        /// <param name="number">Number that is being validated.</param>
        private static void CheckIfValidNumber(int number)
        {
            CheckOutOfRange(number);
            CheckIfZero(number);
        }
    }
}