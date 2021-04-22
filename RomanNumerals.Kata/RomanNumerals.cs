using System;

namespace RomanNumerals.Kata
{
    public class RomanNumerals
    {
        public static string ConvertValue(int input)
        {
            if (input == 1)
            {
                return "I";
            }
            else if (input == 2)
            {
                return "II";
            }

            return "None";
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
