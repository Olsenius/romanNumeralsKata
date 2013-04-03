using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roman
{
    public class RomanNumbers
    {
        private static Dictionary<int, string> _lookup = new Dictionary<int, string>
            {
                //{1, "I"},
                //{5, "V"},
                //{10, "X"},
                {50, "L"},
                {100, "C"},
                {500, "D"},
                {1000, "M"},
            };

        private static Dictionary<int, string[]> _lookup2 = new Dictionary<int, string[]>
            {
                {0, new [] {"", "", ""}},
                {1, new [] {"I", "X", "C"}},
                {2, new [] {"II", "XX", "CC"}},
                {3, new [] {"III", "XXX", "CCC"}},
                {4, new [] {"IV", "XL", "CD"}},
                {5, new [] {"V", "L", "D"}},
                {6, new [] {"VI", "LX", "DC"}},
                {7, new [] {"VII", "LXX", "DCC"}},
                {8, new [] {"VIII", "LXXX", "DCCC"}},
                {9, new [] {"IX", "XC", "CM"}},
            };

        public static string ToRoman(int number)
        {
            if (_lookup.ContainsKey(number))
                return _lookup[number];

            var roman = "";

            roman += _lookup2[number/100][2]; //1000

            roman += _lookup2[number/10%10][1]; //100

            roman += _lookup2[number%10][0]; //10

            return roman;
        }
    }
}
