using System;

namespace RomanNumerals.Kata
{
    public class RomanNumerals
    {
        // Method that takes an integer value that builds a string of Roman numerals from the value of the input
        public static string ConvertValue(int input)
        {
            CheckOutOfRange(input);

            string output = "";
            int count;
            int denominator;
            string roman;

            while (input > 0)
            {
                roman = GetRomanNumeral(input);
                denominator = GetDecimalValue(roman);
                count = input / denominator;
                output = BuildRomanNumeral(output, count, roman);
                input -= (denominator * count);
            }

            return output;
        }

        public static string GetRomanNumeral(int input)
        {
            if (input / 1000 > 0)
                return "M";
            else if (input / 900 > 0)
                return "CM";
            else if (input / 500 > 0)
                return "D";
            else if (input / 400 > 0)
                return "CD";
            else if (input / 100 > 0)
                return "C";
            else if (input / 90 > 0)
                return "XC";
            else if (input / 50 > 0)
                return "L";
            else if (input / 40 > 0)
                return "XL";
            else if (input / 10 > 0)
                return "X";
            else if (input / 9 > 0)
                return "IX";
            else if (input / 5 > 0)
                return "V";
            else if (input / 4 > 0)
                return "IV";

            return "I";
        }

        public static int GetDecimalValue(string input)
        {
            if (input == "M")
                return 1000;
            else if (input == "CM")
                return 900;
            else if (input == "D")
                return 500;
            else if (input == "CD")
                return 400;
            else if (input == "C")
                return 100;
            else if (input == "XC")
                return 90;
            else if (input == "L")
                return 50;
            else if (input == "XL")
                return 40;
            else if (input == "X")
                return 10;
            else if (input == "IX")
                return 9;
            else if (input == "V")
                return 5;
            else if (input == "IV")
                return 4;

            return 1;
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

        public static void CheckNegative(int input)
        {
            if (input < 0)
                throw new ArgumentOutOfRangeException();
        }

        public static void CheckBeyondUpperLimit(int input)
        {
            if (input >= 4000)
                throw new ArgumentOutOfRangeException();
        }

        public static void CheckOutOfRange(int input)
        {
            if (input < 0 || input >= 4000)
                throw new ArgumentOutOfRangeException();
        }
    }
}