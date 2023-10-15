using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Configuration;
using HaveshApp.Admin.Authentication;

namespace HaveshApp.Classes
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        readonly UserSessionService _sessionService;
        readonly IHttpContextAccessor _accessor;
        readonly IConfiguration _configuration;

        public CustomAuthenticationStateProvider(
            UserSessionService sessionService,
            IHttpContextAccessor accessor,
            IConfiguration configuration
            )
        {
            _sessionService = sessionService;
            _accessor = accessor;
            _configuration = configuration;
        }
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var jwtSection = _configuration.GetSection("JWT");

            var tokenName = jwtSection["TokenName"]!;
            var secretKey = jwtSection["Secret"]!;
            var issuer = jwtSection["Issuer"]!;
            var audience = jwtSection["Audience"]!;

            var token = _accessor.HttpContext?.Request.Cookies[tokenName] ;//?? _tokenProviderService.Token;
            var parser = new JwtTokenParser(secretKey);

            if (parser.TryParseToken(token,out var payload,out var claims))
            {
                var authenticationState = new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(claims?.Claims, "Bearer")));
                var authenticationStateAsync = Task.FromResult(authenticationState);
                NotifyAuthenticationStateChanged(authenticationStateAsync);
                _sessionService.Token = token;
                _sessionService.State = authenticationStateAsync;
                _sessionService.Payload = payload;
                return authenticationStateAsync;
            }

            var fromResult = Task.FromResult(new AuthenticationState(new ClaimsPrincipal()));
            NotifyAuthenticationStateChanged(fromResult);
            _sessionService.Token = null;
            _sessionService.State = fromResult;
            return fromResult;

        }
    }
}
