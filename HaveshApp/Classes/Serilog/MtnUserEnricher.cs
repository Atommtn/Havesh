using System;
using System.Security.Claims;
using Microsoft.Extensions.DependencyInjection;
using Serilog.Core;
using Serilog.Events;
using HaveshApp.Admin.Authentication;
using Olive;

namespace HaveshApp.Classes.Serilog
{
    /// <summary>
    /// Enrich log events with the named Claim Value.
    /// </summary>
    public class MtnUserEnricher : ILogEventEnricher
    {
        //readonly UserSessionService? _userService;
        readonly ServiceProvider _serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="MtnUserEnricher"/> class.
        /// </summary>
        /// <param name="serviceCollection"></param>
        public MtnUserEnricher(IServiceCollection services)
        {
            _serviceProvider = services.BuildServiceProvider();

        }



        /// <summary>
        /// Enrich the log event with found by name claim's value
        /// </summary>
        /// <param name="logEvent">The log event to enrich.</param>
        /// <param name="propertyFactory">Factory for creating new properties to add to the event.</param>
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            if (logEvent == null)
                throw new ArgumentNullException(nameof(logEvent));
            var service = _serviceProvider.GetService(typeof(UserSessionService));
            using var scope = _serviceProvider.CreateScope();
            var _userService = scope.ServiceProvider.GetService<UserSessionService>();

            if (_userService == null)
                return;

            if (_userService.UserName.IsEmpty())
                return;

            var prop1 = new LogEventProperty("Username", new ScalarValue(_userService.UserName));
            logEvent.AddPropertyIfAbsent(prop1);

            var prop2 = new LogEventProperty("Fullname", new ScalarValue(_userService.FullName));
            logEvent.AddPropertyIfAbsent(prop2);
        }
    }
}