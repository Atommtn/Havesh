using System;

namespace AdminDashboard.Server.Class.Extensions
{
    public static class StringExtensionMethods
    {
        public static int ToInt(this string text)
        {
            return Convert.ToInt32(text);
        }
    }
}
