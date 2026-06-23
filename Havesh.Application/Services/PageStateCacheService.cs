// فایل جدید — این رو در مسیر زیر روی سرور بساز:
// /opt/havesh-app/Havesh.Application/Services/PageStateCacheService.cs
//
// این یک سرویس عمومی و قابل‌استفاده در کل سایت برای حفظ وضعیت یک صفحه
// (مثلاً ترم انتخاب‌شده، نتایج جستجو و غیره) موقع برگشتن با دکمه‌ی Back مرورگره.
//
// چرا کار می‌کنه: چون Scoped ثبت می‌شه، یک نمونه از این سرویس به ازای هر
// "Circuit" (یعنی هر تب باز مرورگر کاربر در Blazor Server) ساخته می‌شه و
// تا وقتی همون تب/کانکشن SignalR زنده‌ست (حتی وقتی بین صفحات مختلف سایت
// جابه‌جا می‌شی) از بین نمی‌ره. فقط با Refresh کامل صفحه (F5) یا قطع کانکشن
// پاک می‌شه.
//
// نحوه‌ی استفاده در هر صفحه (نمونه در StudentChurnReport.razor.cs):
//   1. [Inject] PageStateCacheService PageState { get; set; }
//   2. یک کلید ثابت برای صفحه تعریف کن، مثلاً: private const string CacheKey = "StudentChurnReport";
//   3. در OnInitialized، با PageState.TryGet<T>(CacheKey, out var state) وضعیت قبلی رو بازیابی کن.
//   4. هر وقت وضعیت مهمی تغییر کرد (انتخاب ترم، نمایش نتایج)، با PageState.Set(CacheKey, state) ذخیره‌ش کن.

using System.Collections.Generic;

namespace Havesh.Application.Services;

public class PageStateCacheService
{
	private readonly Dictionary<string, object> _cache = new();

	public void Set<T>(string key, T value)
	{
		_cache[key] = value!;
	}

	public bool TryGet<T>(string key, out T value)
	{
		if (_cache.TryGetValue(key, out var obj) && obj is T typed)
		{
			value = typed;
			return true;
		}

		value = default!;
		return false;
	}

	public void Clear(string key)
	{
		_cache.Remove(key);
	}
}
