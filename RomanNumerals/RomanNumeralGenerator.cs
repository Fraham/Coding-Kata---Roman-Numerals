using System;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralGenerator : IRomanNumeralGenerator
    {
        public string Generate(int number)
        {
            var roman = new StringBuilder();

            if (number >= 5)
            {
                roman.Append("V");
                number -= 5;
            }

            while (number >= 1)
            {
                roman.Append("I");
                number -= 1;
            }

            return roman.ToString();
        }
    }
}
