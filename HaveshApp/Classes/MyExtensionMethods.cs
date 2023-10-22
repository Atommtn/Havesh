using System.Reflection;
using Olive;

namespace HaveshApp.Classes;

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
	public static string? GetFirstNWords(this string? text, int n)
	{
		if (text == null) return null;
		var words = text.Split(new char[] { ' ', '.', ',', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
		var length = Math.Min(n, words.Length);
		var result = string.Join(" ", words.Take(length));
		if (result.Length < text.Length) result += "...";
		return result;
	}
}