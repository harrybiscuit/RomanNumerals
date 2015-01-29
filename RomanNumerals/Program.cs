using System;
using System.Diagnostics;

namespace RomanNumerals
{
    public class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Write("Enter a positive integer or 'q' to quit...  ");
                var input = Console.ReadLine();
                Debug.Assert(input != null, "input != null");
                if (input.Trim().ToLower().Equals("q"))
                {
                    return;
                }
                int number;
                if (!int.TryParse(input, out number)) continue;
                var parser = new RomanNumeralParser();
                Console.WriteLine("The Roman Numeral for {0} is {1} ", number, parser.Parse(number));
            }
        }
    }
}