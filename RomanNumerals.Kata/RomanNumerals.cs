using System;

namespace RomanNumerals.Kata
{
    public class RomanNumerals
    {
        public static string ConvertValue(int input)
        {
            string output = "";
            int count;

            if (input / 5 > 0)
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