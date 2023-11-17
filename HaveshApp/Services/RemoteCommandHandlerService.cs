using System.Text.Json;
using System.Text.Json.Serialization;
using Havesh.Model.Model;
using HaveshApp.Classes.ExtensionMethods;
using Microsoft.AspNetCore.Components;

namespace Havesh.Domain.Services;

public class RemoteCommandHandlerService
{
	private readonly AuthenticationService _authenticationService;
	private readonly DataProviderService _dataProviderService;
	private readonly NavigationManager _navigationManager;

	public RemoteCommandHandlerService(
		AuthenticationService authenticationService,
		DataProviderService dataProviderService,
		NavigationManager navigationManager)
	{
		_authenticationService = authenticationService;
		_dataProviderService = dataProviderService;
		_navigationManager = navigationManager;
	}

	
	public async Task ExecuteCommand(string command)
	{
		var cmd = command.ToLower().Split(' ');
		if (cmd.Length <= 0) return;
	        
		switch (cmd[0])
		{
			case "logout":
				var userName = await _authenticationService.LogOut();
				if (cmd.Skip(1).Contains("inactive"))
				{
					_dataProviderService.InactiveUser(userName);
				}
				break;
			case "gotopage":
				if (cmd.Length < 2)
				{
					_navigationManager.NavigateTo("/", true);
					return;
				}
				_navigationManager.NavigateTo($"{cmd[1].TrimStart('/')}/");
				break;
		}
	}
}