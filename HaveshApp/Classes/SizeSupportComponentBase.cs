using Microsoft.AspNetCore.Components;
using MudBlazor;
using MudBlazor.Services;

namespace HaveshApp.Classes;

public class SizeSupportComponentBase : ComponentBase , IDisposable
{
    [Inject] public IResizeListenerService ResizeListenerService{ get; set; }
    [Inject] public IBrowserWindowSizeProvider WindowSizeProvider { get; set; }

    public static int BrowserHeight { get; set; }
    public int BrowserWidth { get; set; }
    protected override void OnInitialized()
    {
        base.OnInitialized();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            ResizeListenerService.OnResized += ResizeListenerService_OnResized;
            var wsp = await WindowSizeProvider.GetBrowserWindowSize();
            ResizeListenerService_OnResized(ResizeListenerService, new BrowserWindowSize
            {
                Height = wsp.Height,
                Width = wsp.Height
            });
        }
        base.OnAfterRender(firstRender);
    }

    void ResizeListenerService_OnResized(object? sender, BrowserWindowSize e)
    {
        BrowserHeight = e.Height;
        BrowserWidth = e.Width;
        //Console.WriteLine(BrowserHeight);
        StateHasChanged();
    }

    public void Dispose()
    {
        ResizeListenerService.OnResized -= ResizeListenerService_OnResized;
        //ResizeListenerService.Dispose();
    }
}