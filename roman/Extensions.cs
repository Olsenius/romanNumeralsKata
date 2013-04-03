using System;

namespace roman
{
    public static class Extensions
    {
        public static int ToInt(this string s)
        {
            return Convert.ToInt32(s);
        }
    }
}