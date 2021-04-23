using System;

namespace RomanNumerals.Kata
{
    public class RomanNumerals
    {
        // Method that takes an integer value that builds a string of Roman numerals from the value of the input
        public static string ConvertNumberToRomanNumeral(int number)
        {
            CheckIfValidNumber(number); // checks legal input is being converted

            // Create variables for conversion
            string output = string.Empty;
            int count;
            int denominator;
            string roman;

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

            return output;
        }

        // Helper method that will return the Roman numeral associated with the numeric value passed in.
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

        // Helper method that will return the value associated with the Roman numeral value passed in.
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

        // Helper method that takes an input string, an integer to use as a counter, and a string to represent the Roman
        // numeral to append to the input string.
        private static string BuildRomanNumeral(string input, int count, string roman)
        {
            string output = input;

            for (int i = 0; i < count; i++)
            {
                output = output.Insert(output.Length, roman);
            }

            return output;
        }

        // Throws ArgumentOutOfRangeException if input is less than 0.
        private static void CheckNegative(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException();
        }

        // Throws ArgumentOutOfRangeException if input is greater than 3999
        private static void CheckBeyondUpperLimit(int number)
        {
            if (number >= 4000)
                throw new ArgumentOutOfRangeException();
        }

        // Throws ArgumentOutOfRangeException if input is less than 0 or greater than 3999
        private static void CheckOutOfRange(int number)
        {
            if (number < 0 || number >= 4000)
                throw new ArgumentOutOfRangeException();
        }

        // Throws ArgumentNullException if input is equal to 0.
        private static void CheckIfZero(int number)
        {
            if (number == 0)
                throw new ArgumentNullException();
        }

        // Throws either ArgumentOutOfRangeException if input is out of the allowed range or
        // throws ArgumentNullException if input is 0.
        private static void CheckIfValidNumber(int number)
        {
            CheckOutOfRange(number);
            CheckIfZero(number);
        }
    }
}