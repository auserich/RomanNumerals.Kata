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

            while (input > 0)
            {
                if (input / 1000 > 0)
                {
                    count = input / 1000;
                    output = BuildRomanNumeral(output, count, "M");
                    input -= (1000 * count);
                }
                // Series of checks to find highest denominator of Roman numeral to match with input
                else if (input / 900 > 0)
                {
                    count = 1;
                    output = BuildRomanNumeral(output, count, "CM");
                    input -= 900;
                }
                else if (input / 500 > 0)
                {
                    count = input / 500;
                    output = BuildRomanNumeral(output, count, "D");
                    input -= 500;
                }
                else if (input / 400 > 0)
                {
                    count = 1;
                    output = BuildRomanNumeral(output, count, "CD");
                    input -= 400;
                }
                else if (input / 100 > 0)
                {
                    count = input / 100;
                    output = BuildRomanNumeral(output, count, "C");
                    input -= (100 * count);
                }
                else if (input / 90 > 0)
                {
                    count = 1;
                    output = BuildRomanNumeral(output, count, "XC");
                    input -= 90;
                }
                else if (input / 50 > 0)
                {
                    count = input / 50;
                    output = BuildRomanNumeral(output, count, "L");
                    input -= (50 * count);
                }
                else if (input / 40 > 0)
                {
                    count = 1;
                    output = BuildRomanNumeral(output, count, "XL");
                    input -= 40;
                }
                else if (input / 10 > 0)
                {
                    count = input / 10;
                    output = BuildRomanNumeral(output, count, "X");
                    input -= (10 * count);
                }
                else if (input / 9 > 0)
                {
                    count = 1;
                    output = BuildRomanNumeral(output, count, "IX");
                    input -= 9;
                }
                else if (input / 5 > 0)
                {
                    count = input / 5;
                    output = BuildRomanNumeral(output, count, "V");
                    input -= (5 * count);
                }
                else if (input / 4 > 0)
                {
                    count = 1;
                    output = BuildRomanNumeral(output, count, "IV");
                    input -= 4;
                }
                else if (input / 1 > 0)
                {
                    count = input;
                    output = BuildRomanNumeral(output, count, "I");
                    input -= (1 * count);
                }
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