using Havesh.Model.Model;
using Microsoft.AspNetCore.Components.Authorization;
using Havesh.Domain.Services;
using Havesh.Grains;
using Havesh.Model.Data.Dashboard;
using HaveshApp.Classes.ExtensionMethods;
using Havesh.GrainInterfaces;
using Havesh.GrainInterfaces.Common;
using Olive;

namespace HaveshApp.Admin.Authentication;

public class UserSessionService
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IClusterClient _client;
    private DataProviderService? _dataProviderService;
    public event Func<MessageDto, Task> MessageReceived;

    public UserSessionService(IServiceProvider serviceProvider, IClusterClient client)
    {
        _serviceProvider = serviceProvider;
        _client = client;
    }

    private User? _user;

    private async Task<User> GetUserAsync()
    {
        var userGrain = _client.GetGrain<IHaveshGrain<User>>((int)Payload?.UserId!);
        _user = await userGrain.Get();

        _dataProviderService ??= _serviceProvider.GetService<DataProviderService>();
        if (_dataProviderService != null)
        {
            _dataProviderService.DbContext.Entry(_user).Reload();
	        _dataProviderService.DbContext.Actor ??= _user;
        }

        return _user!;
    }

    public void ResetUser() => _user = null;

    public async Task<User> GetUserOrLoadAsync()
    {
        _user ??= await GetUserAsync();
        return _user;
    }

    public User User => _user ;//?? throw new Exception("User is invalid !");

    public DateTime? LastJvDate { get; set; } = DateTime.Today;
    public Payload? Payload { get; set; }
    public string? Token { get; set; }
    public Task<AuthenticationState>? State { get; set; }

    public string? UserName => Payload?.UserName;
    public string? FullName => Payload?.FirstName + " " + Payload?.LastName;

    public Task NotifyNewMessageDelivered(MessageDto messageDto)
    {
        return MessageReceived.Invoke(messageDto);
    }
}