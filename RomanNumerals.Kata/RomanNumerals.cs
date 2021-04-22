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
            }

            return output;
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
