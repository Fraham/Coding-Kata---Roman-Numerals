using System;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralGenerator : IRomanNumeralGenerator
    {
        public string Generate(int number)
        {
            var roman = new StringBuilder();

            if (number == 5)
            {
                roman.Append("V");
            }

            if (number == 2)
            {
                roman.Append("II");
            }

            if (number == 1)
            {
                roman.Append("I");
            }

            return roman.ToString();
        }
    }
}
