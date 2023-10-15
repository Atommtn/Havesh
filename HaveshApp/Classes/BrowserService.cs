using Microsoft.JSInterop;

namespace HaveshApp.Classes
{
    public class BrowserService
    {
        readonly IJSRuntime _jsRuntime;

        public BrowserService(IJSRuntime js)
        {
            _jsRuntime = js;
        }


        public async Task SetCookieAsync(string name, string? value, int days)
        {
            await _jsRuntime.InvokeAsync<string>("blazorExtensions.SetCookie", name, value, days);
        }

        public async Task<string?> GetCookieAsync(string name)
        {
            var value = await _jsRuntime.InvokeAsync<string>("blazorExtensions.GetCookie", name);
            return value;
        }

        public async Task EraseCookieAsync(string name)
        {
            var res = await _jsRuntime.InvokeAsync<object>("blazorExtensions.EraseCookie", name);
        }
        public async Task PrintPageAsync()
        {
await _jsRuntime.InvokeVoidAsync("blazorExtensions.PrintPage");
        }
        public async Task OpenInNewTabAsync(string url)
        {
        await _jsRuntime.InvokeVoidAsync("blazorExtensions.OpenInNewTab", url);
        }
    }
}

