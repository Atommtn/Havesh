using System;
using System.Linq;
using System.Security.Claims;
using Microsoft.Extensions.DependencyInjection;
using Serilog.Core;
using Serilog.Events;
using HaveshApp.Admin.Authentication;
using Olive;

namespace HaveshApp.Classes.Serilog;

/// <summary>
/// Enrich log events with the named Claim Value.
/// </summary>
public class MtnUserEnricher : ILogEventEnricher
{
    readonly ServiceProvider _serviceProvider;

    public MtnUserEnricher(IServiceCollection services)
    {
        _serviceProvider = services.BuildServiceProvider();
    }

    /// <summary>
    /// Enrich the log event with found by name claim's value
    /// </summary>
    public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
    {
        if (logEvent == null)
            throw new ArgumentNullException(nameof(logEvent));
        using var scope = _serviceProvider.CreateScope();
        var _userService = scope.ServiceProvider.GetService<UserSessionService>();

        if (_userService == null)
            return;

        if (_userService.UserName.IsEmpty())
            return;

        var prop1 = new LogEventProperty("UserName", new ScalarValue(_userService.UserName));
        logEvent.AddPropertyIfAbsent(prop1);

        var prop2 = new LogEventProperty("Fullname", new ScalarValue(_userService.FullName));
        logEvent.AddPropertyIfAbsent(prop2);

        var roleValue = _userService.Payload?.Roles is { Count: > 0 } roles
            ? string.Join(",", roles)
            : null;
        var prop3 = new LogEventProperty("Role", new ScalarValue(roleValue));
        logEvent.AddPropertyIfAbsent(prop3);
    }
}