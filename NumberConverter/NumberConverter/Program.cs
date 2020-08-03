using System;

namespace NumberConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var romanToInt = new RomanToIntegerConverter();
            var output = romanToInt.RomanToInteger(input.ToUpper());
            Console.WriteLine(output);
        }
    }
}
