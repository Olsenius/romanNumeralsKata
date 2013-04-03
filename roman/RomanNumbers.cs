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

            roman += LetterLookup[number/1000%10][3]; //10000
            roman += LetterLookup[number/100%10][2]; //1000
            roman += LetterLookup[number/10%10][1]; //100
            roman += LetterLookup[number%10][0]; //10

            return roman;
        }
    }
}
