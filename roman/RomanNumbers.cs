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
                {0, new [] {"", ""}},
                {1, new [] {"I", "X"}},
                {2, new [] {"II", "XX"}},
                {3, new [] {"III", "XXX"}},
                {4, new [] {"IV", "XL"}},
                {5, new [] {"V", "L"}},
                {6, new [] {"VI", "LX"}},
                {7, new [] {"VII", "LXX"}},
                {8, new [] {"VIII", "LXXX"}},
                {9, new [] {"IX", "XC"}},
            };

        public static string ToRoman(int number)
        {
            if (_lookup.ContainsKey(number))
                return _lookup[number];

            var roman = "";
            roman += _lookup2[number/10][1]; //100

            roman += _lookup2[number%10][0]; //10

            return roman;
        }
    }
}
