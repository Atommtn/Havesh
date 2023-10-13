using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace ShokouhApp.Classes;

public class TokenProviderService
{
    public Guid? UniqueKey { get; set; }
    public async Task<(Guid?,bool)> TryGetUniqueKey(BrowserService browserService)
    {
        var isNewKey = false;
        if (UniqueKey == null)
        {
            var uniquekey = await browserService.GetCookieAsync("_uniqueKey");
            if (Guid.TryParse(uniquekey, out var key))
            {
                UniqueKey = key;
            }
        }

        if (UniqueKey is null || UniqueKey == Guid.Empty)
        {
            UniqueKey = Guid.NewGuid();
            await browserService.SetCookieAsync("_uniqueKey", UniqueKey?.ToString("D"), 365);
            isNewKey = true;
        }

        return (UniqueKey, isNewKey);

    }

}