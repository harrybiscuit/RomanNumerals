using FluentAssertions;
using NUnit.Framework;
using RomanNumerals;

namespace RomanNumeralsTests
{
    [TestFixture]
    public class RomanNumeralParserTests
    {
        [TestCase(1990, "MCMXC")]
        [TestCase(2008, "MMVIII")]
        [TestCase(99, "XCIX")]
        [TestCase(47, "XLVII")]
        public void AcceptThis(int number, string expected)
        {
            var parser = new RomanNumeralParser();
            var result = parser.Parse(number);
            result.Should().Be(expected);
        }

        public class TheParseMethod
        {
            [TestCase(1,"I")]
            [TestCase(2, "II")]
            [TestCase(3, "III")]
            [TestCase(4, "IV")]
            [TestCase(5, "V")]
            public void ShouldParseSingleDigits(int number, string expected)
            {
                var parser = new RomanNumeralParser();
                var result = parser.Parse(number);
                result.Should().Be(expected);
            }

            [TestCase(10, "X")]
            [TestCase(11, "XI")]
            [TestCase(14, "XIV")]
            [TestCase(17, "XVII")]
            [TestCase(18, "XVIII")]
            [TestCase(24, "XXIV")]            
            [TestCase(21, "XXI")]
            [TestCase(40, "XL")]
            [TestCase(44, "XLIV")]
            [TestCase(47, "XLVII")]
            [TestCase(51, "LI")]
            [TestCase(61, "LXI")]
            [TestCase(71, "LXXI")]
            [TestCase(81, "LXXXI")]
            [TestCase(91, "XCI")]
            [TestCase(99, "XCIX")]
            public void ShouldParseDoubleDigits(int number, string expected)
            {
                var parser = new RomanNumeralParser();
                var result = parser.Parse(number);
                result.Should().Be(expected);
            }

            [TestCase(100, "C")]
            [TestCase(101, "CI")]
            [TestCase(111, "CXI")]
            [TestCase(200, "CC")]
            [TestCase(300, "CCC")]
            [TestCase(400, "CD")]
            [TestCase(444, "CDXLIV")]
            [TestCase(500, "D")]
            [TestCase(600, "DC")]
            [TestCase(606, "DCVI")]
            [TestCase(700, "DCC")]
            [TestCase(800, "DCCC")]
            [TestCase(810, "DCCCX")]
            [TestCase(900, "CM")]
            [TestCase(999, "CMXCIX")]            
            public void ShouldParseTripleDigits(int number, string expected)
            {
                var parser = new RomanNumeralParser();
                var result = parser.Parse(number);
                result.Should().Be(expected);
            }

            [TestCase(1000, "M")]
            [TestCase(5000, "MMMMM")]
            [TestCase(9000, "MMMMMMMMM")]
            [TestCase(1990, "MCMXC")]
            [TestCase(2008, "MMVIII")]
            public void ShouldParseQuadrupleDigits(int number, string expected)
            {
                var parser = new RomanNumeralParser();
                var result = parser.Parse(number);
                result.Should().Be(expected);
            }
        }
    }
}
