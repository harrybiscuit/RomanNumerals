using System;

namespace RomanNumerals
{
    public class Program
    {
        private static void Main()
        {
            var parser=new RomanNumeralParser();
            Console.WriteLine(parser.Parse(1990));
            Console.WriteLine(parser.Parse(2008));
            Console.WriteLine(parser.Parse(99));
            Console.WriteLine(parser.Parse(47));
            

            Console.ReadLine();
        }
    }
}