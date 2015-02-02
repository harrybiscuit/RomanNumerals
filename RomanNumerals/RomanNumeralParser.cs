using System.Collections.Generic;

namespace RomanNumerals
{
    public class RomanNumeralParser
    {
        private readonly Dictionary<int, string> _romanLookup = new Dictionary<int, string>();

        public RomanNumeralParser()
        {
            InitialiseRomanLookup();
        }

        private void InitialiseRomanLookup()
        {            
            _romanLookup.Add(4, "IV");
            _romanLookup.Add(5, "V");
            _romanLookup.Add(6, "VI");
            _romanLookup.Add(7, "VII");
            _romanLookup.Add(8, "VIII");
            _romanLookup.Add(9, "IX");
            _romanLookup.Add(10, "X");
            _romanLookup.Add(40, "XL");
            _romanLookup.Add(50, "L");
            _romanLookup.Add(60, "LX");
            _romanLookup.Add(70, "LXX");
            _romanLookup.Add(80, "LXXX");
            _romanLookup.Add(90, "XC");
            _romanLookup.Add(400, "CD");
            _romanLookup.Add(500, "D");
            _romanLookup.Add(600, "DC");
            _romanLookup.Add(700, "DCC");
            _romanLookup.Add(800, "DCCC");
            _romanLookup.Add(900, "CM");
            _romanLookup.Add(1000, "M");
        }

        public string Parse(int normalNumber)
        {
            if (_romanLookup.ContainsKey(normalNumber)) {
                return _romanLookup[normalNumber];
            }

            int thousands = normalNumber / 1000;
            int remainder = thousands < 1 ? normalNumber : normalNumber - ((thousands * 1000));

            int hundreds = remainder / 100;
            remainder = hundreds < 1 ? remainder : remainder - ((hundreds * 100));
            
            var tens = remainder / 10;            
            remainder = tens < 1 ? remainder : ( remainder - (tens * 10));
            
            var units = remainder % 10;


            var thousandsOutput = GetRomanNumeral(thousands, 1000, "M");
            var hundredsOutput = GetRomanNumeral(hundreds, 100, "C");
            var tensOutput = GetRomanNumeral(tens, 10, "X");
            var unitsOutput = GetRomanNumeral(units, 1, "I");
            
            return thousandsOutput + hundredsOutput + tensOutput + unitsOutput;
        }

        private string GetRomanNumeral(int number, int multiplier, string romanNumeral)
        {
            string output = "";
            for (var i = 0; i < number; i++) {
                var valueToConvert = number * multiplier;
                if (_romanLookup.ContainsKey(valueToConvert)) {
                    return _romanLookup[valueToConvert];
                }
                else {
                    output += romanNumeral;
                }
            }
            return output;
        }
    }
}
