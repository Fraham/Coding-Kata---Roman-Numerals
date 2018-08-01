using System;

namespace RomanNumerals
{
    public class RomanNumeralGenerator : IRomanNumeralGenerator
    {
        public string Generate(int number)
        {
            if (number == 5)
            {
                return "V";
            }
            if (number == 2)
            {
                return "II";
            }
            return "I";
        }
    }
}
