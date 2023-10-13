using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components;

namespace ShokouhApp.Services;

public class Navigation : IDisposable
{
    readonly NavigationManager _navigationManager;
    readonly Stack<string> _history;

    public Navigation(NavigationManager navigationManager)
    {
        _navigationManager = navigationManager;
        _history = new Stack<string>()
        {
            
        };
        _history.Push(_navigationManager.Uri);
        _navigationManager.LocationChanged += OnLocationChanged;
    }

    /// <summary>
    /// Navigates to the specified url.
    /// </summary>
    /// <param name="url">The destination url (relative or absolute).</param>
    public void NavigateTo(string url , bool? ignoreHistory = false)
    {

        _navigationManager.NavigateTo(url);
    }

    /// <summary>
    /// Returns true if it is possible to navigate to the previous url.
    /// </summary>
    public bool CanNavigateBack => _history.Count > 0;

    /// <summary>
    /// Navigates to the previous url if possible or does nothing if it is not.
    /// </summary>
    public void NavigateBack()
    {
        if (!CanNavigateBack) return;
        _history.Pop();
        var backPageUrl = _history.Pop();
        _navigationManager.NavigateTo(backPageUrl);
    }

    // .. All other navigation methods.

    void OnLocationChanged(object? sender, LocationChangedEventArgs e)
    {
        _history.Push(e.Location);
    }

    public void IgnoreThis()
    {
        _history.Pop();
    }

    public void Dispose()
    {
        _navigationManager.LocationChanged -= OnLocationChanged;
    }
}