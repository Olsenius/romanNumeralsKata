using NUnit.Framework;
using Should;

namespace roman
{
    [TestFixture]
    public class RomanTests
    {
        [TestCase(1, "I")]
        [TestCase(5, "V")]
        [TestCase(10, "X")]
        [TestCase(50, "L")]
        [TestCase(100, "C")]
        [TestCase(500, "D")]
        [TestCase(1000, "M")]
        public void Should_handle_single_letter_numbers(int number, string expected)
        {
            RomanNumbers.ToRoman(number).ShouldEqual(expected);
        }
        
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        public void Should_handle_numbers_below_10(int number, string expected)
        {
            RomanNumbers.ToRoman(number).ShouldEqual(expected);
        }
        
        [TestCase(11, "XI")]
        [TestCase(22, "XXII")]
        [TestCase(32, "XXXII")]
        [TestCase(42, "XLII")]
        [TestCase(55, "LV")]
        [TestCase(64, "LXIV")]
        [TestCase(71, "LXXI")]
        [TestCase(82, "LXXXII")]
        [TestCase(92, "XCII")]
        public void Should_handle_numbers_below_100(int number, string expected)
        {
            RomanNumbers.ToRoman(number).ShouldEqual(expected);
        }

        [TestCase(111, "CXI")]
        [TestCase(222, "CCXXII")]
        [TestCase(333, "CCCXXXIII")]
        public void Should_handle_numbers_below_1000(int number, string expected)
        {
            RomanNumbers.ToRoman(number).ShouldEqual(expected);
        }

        [TestCase(1111, "MCXI")]
        [TestCase(2222, "MMCCXXII")]
        [TestCase(2013, "MMXIII")]
        [TestCase(3999, "MMMCMXCIX")]
        public void Should_handle_numbers_below_3999(int number, string expected)
        {
            RomanNumbers.ToRoman(number).ShouldEqual(expected);
        }   
    }
}