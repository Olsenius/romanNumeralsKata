using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roman
{
    public class RomanNumbers
    {
        private static readonly Dictionary<int, string[]> LetterLookup = new Dictionary<int, string[]>
            {
                {0, new [] {"", "", "", ""}},
                {1, new [] {"I", "X", "C", "M"}},
                {2, new [] {"II", "XX", "CC", "MM"}},
                {3, new [] {"III", "XXX", "CCC", "MMM"}},
                {4, new [] {"IV", "XL", "CD"}},
                {5, new [] {"V", "L", "D"}},
                {6, new [] {"VI", "LX", "DC"}},
                {7, new [] {"VII", "LXX", "DCC"}},
                {8, new [] {"VIII", "LXXX", "DCCC"}},
                {9, new [] {"IX", "XC", "CM"}},
            };

        public static string ToRoman(int number)
        {
            var roman = "";

            roman += LetterLookup[number / 1000 % 10][3]; //10000
            roman += LetterLookup[number / 100 % 10][2]; //1000
            roman += LetterLookup[number / 10 % 10][1]; //100
            roman += LetterLookup[number % 10][0]; //10

            return roman;
        }

        public static int ToDecimal(string roman)
        {
            var answer = "";
            var numberOfLettersToRemove = 0;
            while (roman != "")
            {
                roman = roman.Substring(numberOfLettersToRemove);

                var num = new int[4];
                num[0] = LetterToNumberLookup(roman.Substring(0, Math.Min(1, roman.Length)));
                num[1] = LetterToNumberLookup(roman.Substring(0, Math.Min(2, roman.Length)));
                num[2] = LetterToNumberLookup(roman.Substring(0, Math.Min(3, roman.Length)));
                num[3] = LetterToNumberLookup(roman.Substring(0, Math.Min(4, roman.Length)));

                if (!num.Any(x => x != 0))
                    continue;

                numberOfLettersToRemove = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] != 0)
                        numberOfLettersToRemove = i;
                }

                answer += num[numberOfLettersToRemove];

                if (numberOfLettersToRemove == 0)
                    return answer.ToInt();
            }
            return answer.ToInt();
        }

        private static int LetterToNumberLookup(string roman)
        {
            return LetterLookup.FirstOrDefault(x => x.Value.Contains(roman)).Key;
        }
    }
}
