using System;
using System.Collections.Generic;
using System.Text;

namespace NumberConverter
{
    public class RomanToIntegerConverter
    {
        private static Dictionary<char, int> RomanIntegerDictionary = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public int RomanToInteger(string roman)
        {
            int number = 0;
            char previousChar = roman[0];
            foreach (char currentChar in roman)
            {
                number += RomanIntegerDictionary[currentChar];
                if (RomanIntegerDictionary[previousChar] < RomanIntegerDictionary[currentChar])
                {
                    number -= RomanIntegerDictionary[previousChar] * 2;
                }
                previousChar = currentChar;
            }
            return number;
        }
    }
}
