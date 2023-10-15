using System.Reflection;

namespace HaveshApp.Classes
{
    public static class MyExtensionMethods
    {
        public static TE GetProperty<T,TE>(this T @this, string name)
        {
            return (TE)@this?.GetType().GetProperty(name)?.GetValue(@this)!;
        }

        public static string GetTelephone(this string phone)
        {
            var tel = "";
            for (var i = 0; i < phone.Length; i++)
            {
                if(phone[i].IsDigit())
                    tel+=phone[i];
            }

            return tel;
        }

    }
}
