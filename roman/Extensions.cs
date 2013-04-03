using System;

namespace roman
{
    public static class Extensions
    {
        public static int ToInt(this char s)
        {
            return Convert.ToInt32(s);
        }
    }
}