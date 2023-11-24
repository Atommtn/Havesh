using System;

namespace AdminDashboard.Server.Class.Extensions
{
    public static class StringExtensionMethods
    {
        public static int ToInt(this string text)
        {
            return Convert.ToInt32(text);
        }

        public static string ToStringHavesh(this IEnumerable<string> listStr)
        {
	        return listStr.Aggregate("", (current, str) => current + str);
        }
    }
}
