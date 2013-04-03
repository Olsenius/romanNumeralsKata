using System;
using System.Collections.Generic;
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

        private static Dictionary<int, string> _lookup2 = new Dictionary<int, string>
            {
                {1, "I"},
                {2, "II"},
                {3, "III"},
                {4, "IV"},
                {5, "V"},
                {6, "VI"},
                {7, "VII"},
                {8, "VIII"},
                {9, "IX"},
                {10, "X"},
            };

        public static string ToRoman(int number)
        {
            if (_lookup.ContainsKey(number))
                return _lookup[number];
            if (_lookup2.ContainsKey(number))
                return _lookup2[number];

            return "";
        }
    }
}
