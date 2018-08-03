using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RomanNumerals
{
    public class RomanNumeralGenerator : IRomanNumeralGenerator
    {
        private static Dictionary<int, string> _romanNumeralValues = new Dictionary<int, string>
        {
            {100, "C"},
            {50, "L"},
            {10, "X"},
            {5, "V"},
            {1, "I"},
        };

        public string Generate(int number)
        {
            var romanNumeralBuilder = new StringBuilder();

            foreach (var romanNumeral in _romanNumeralValues.OrderByDescending(rn => rn.Key))
            /*
              It is important that the order is descending so that highest values are removed first

              If ordered 1 then 5 it will result in 6 being IIIIII instead of VI
            */
            {
                int amountOfSymbols = (int)(number/romanNumeral.Key);

                romanNumeralBuilder.Append(string.Concat(Enumerable.Repeat(romanNumeral.Value, amountOfSymbols)));
                number -= romanNumeral.Key * amountOfSymbols;
            }

            return romanNumeralBuilder.ToString();
        }
    }
}
