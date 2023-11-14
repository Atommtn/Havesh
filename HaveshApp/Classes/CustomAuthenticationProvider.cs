using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Configuration;
using HaveshApp.Admin.Authentication;

namespace HaveshApp.Classes;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{
    private int _authAttemps = 0;

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
		var token = GetTokenParser(out var parser, _accessor.HttpContext, _configuration);


		if (parser.TryParseToken(token,out var payload,out var claims))
		{

			// JWT is Valid

			var authenticationState = new AuthenticationState(new ClaimsPrincipal(
                new ClaimsIdentity(claims?.Claims, "Bearer")));
			var authenticationStateAsync = Task.FromResult(authenticationState);
			NotifyAuthenticationStateChanged(authenticationStateAsync);
			_sessionService.Token = token;
			_sessionService.State = authenticationStateAsync;
			_sessionService.Payload = payload;
            _authAttemps++;

            if ((_sessionService.User?.IsActive ?? false) )
            {
                return authenticationStateAsync;
            }
        }

		// JWT is Invalid
		var fromResult = Task.FromResult(
            new AuthenticationState(new ClaimsPrincipal()));

		NotifyAuthenticationStateChanged(fromResult);
		_sessionService.Token = null;
		_sessionService.State = fromResult;
        _authAttemps = 0;
		return fromResult;

	}

    private static string? GetTokenParser(out JwtTokenParser parser, HttpContext? httpContext, IConfiguration configuration)
	{
		var jwtSection = configuration.GetSection("JWT");

		var tokenName = jwtSection["TokenName"]!;
		var secretKey = jwtSection["Secret"]!;
		var issuer = jwtSection["Issuer"]!;
		var audience = jwtSection["Audience"]!;
		var token = httpContext?.Request.Cookies[tokenName]; //?? _tokenProviderService.Token;
		parser = new JwtTokenParser(secretKey);
		return token;
	}
}