using HaveshApp.Admin.Authentication;
using HaveshApp.Classes;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using System.Configuration;
using Havesh.Application.Services;
using Havesh.Model.Model;

namespace Havesh.Domain.Services;

public class AuthenticationService
{
	private readonly UserSessionService _userSession;
	private readonly IConfiguration _configuration;
	private readonly BrowserService _browserService;
	private readonly AuthenticationStateProvider _authenticationStateProvider;
	private readonly NavigationManager _navigationManager;
	private readonly DataProviderService _dataProviderService;

	public AuthenticationService(
		UserSessionService userSession,
		IConfiguration configuration,
		BrowserService browserService,
		AuthenticationStateProvider authenticationStateProvider,
		NavigationManager navigationManager,
		DataProviderService dataProviderService)
	{
		_userSession = userSession;
		_configuration = configuration;
		_browserService = browserService;
		_authenticationStateProvider = authenticationStateProvider;
		_navigationManager = navigationManager;
		_dataProviderService = dataProviderService;
	}

	public class InvalidUserCredentialException : Exception
	{
		public InvalidUserCredentialException( string message) 
			: base(message)
		{
                
		}
	}
	public class UserIsNotActiveException : Exception
	{
		public UserIsNotActiveException( string message) 
			: base(message)
		{
                
		}
	}

	public async Task<User> Login(string username,string password)
	{
		var user = _dataProviderService.CheckUserLogin(username, password);
		if (user == null)
		{
			throw new InvalidUserCredentialException("Invalid username or password");
		}

		if (!user.IsActive)
			throw new UserIsNotActiveException("User is not ACTIVE, Please Contact Administrator.");
            
		var jwtSection = _configuration.GetSection("JWT");

		var tokenName = jwtSection["TokenName"]!;
		var secretKey = jwtSection["Secret"]!;
		var issuer = jwtSection["Issuer"]!;
		var audience = jwtSection["Audience"]!;

		var expiryMinutes = 60 * 24 * 30; // Token expiration time in minutes
		var generator = new JwtTokenGenerator(secretKey, issuer, audience, expiryMinutes);
		var jwt = generator.GenerateToken(
			user.Id,
			user.UserName,
			user.Roles.Select(x => x.Name).ToArray(),
			user.Gender,
			user.FirstName,
			user.LastName,
			user.Email,
			user.Phone);
		await _browserService.SetCookieAsync(tokenName, jwt, 30);
		_navigationManager.NavigateTo("/", true);

        return user;
	}

	public async Task<string> LogOut()
	{
		_userSession.Token = null;
		var jwtSection = _configuration.GetSection("JWT");
		var tokenName = jwtSection["TokenName"]!;
		await _browserService.EraseCookieAsync(tokenName);
		var state = await ((CustomAuthenticationStateProvider)_authenticationStateProvider).GetAuthenticationStateAsync();
		_navigationManager.NavigateTo("/LoginPage", true);
        _dataProviderService.DbContext.Actor = null;
		return _userSession.UserName!;
	}

}