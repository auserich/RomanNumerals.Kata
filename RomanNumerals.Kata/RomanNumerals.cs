using System;

namespace RomanNumerals.Kata
{
    public class RomanNumerals
    {
        public static string ConvertValue(int input)
        {
            string output = "";

            for (int i = 0; i < input; i++)
            {
                output = output.Insert(output.Length, "I");
                output = ReduceValue(output);
            }

            return output;
        }

        public static string ReduceValue(string input)
        {
            if (input == "IIII")
            {
                return "IV";
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
