using System;

namespace RomanNumerals.Kata
{
    public class RomanNumerals
    {
        public static string ConvertValue(int input)
        {
            return "I";
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
