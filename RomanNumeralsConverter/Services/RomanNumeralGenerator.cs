using System.Collections.Generic;

namespace RomanNumeralsConverter.Services
{
    public class RomanNumeralGenerator : IRomanNumeralGenerator
    {
        private static int CaveatMax => 3999;
        private static int CaveatMin => 0;

        public string Generate(int number)
        {
            if (!PassesCaveat(number))
                return null;

            var romanNumeralsDictionary = new Dictionary<string, int>
            {
                {"M", 1000},
                {"CM", 900},
                {"D", 500},
                {"CD", 400},
                {"C", 100},
                {"XC", 90},
                {"L", 50},
                {"XL", 40},
                {"X", 10},
                {"IX", 9},
                {"V", 5},
                {"IV", 4},
                {"I", 1},
            };

            var output = "";
            foreach (var romanNumeralMap in romanNumeralsDictionary)
            {
                // How many times fully does our map number fit? This will give us the amount of roman numerals to show
                var division = number / romanNumeralMap.Value;

                for (int i = 0; i < division; i++)
                {
                    output += romanNumeralMap.Key;
                }

                // Take away this value as we want to work our way across the int from left to right (1000s, then 100s etc.)
                number = number - (division * romanNumeralMap.Value);
            }

            return output;
        }

        private static bool PassesCaveat(int number)
        {
            return number > CaveatMin && number < CaveatMax;
        }
    }
}
