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
            {90, "XC"},
            {9, "IX"},
            {400, "CD"},
            {40, "XL"},
            {4, "IV"},
            {1000, "M"},
            {500, "D"},
            {100, "C"},
            {50, "L"},
            {10, "X"},
            {5, "V"},
            {1, "I"},
        };

        public string Generate(int number)
        {
            var romanNumeralBuilder = new StringBuilder();

            /*
              It is important that the order is descending so that highest values are removed first

              If ordered 1,5,10 it will result in 6 being IIIIII instead of VI
            */
            foreach (var romanNumeral in _romanNumeralValues.OrderByDescending(rn => rn.Key))
            {
                int amountOfSymbols = (int)(number/romanNumeral.Key);

                romanNumeralBuilder.Append(string.Concat(Enumerable.Repeat(romanNumeral.Value, amountOfSymbols)));
                number -= romanNumeral.Key * amountOfSymbols;
            }

            return romanNumeralBuilder.ToString();
        }
    }
}
