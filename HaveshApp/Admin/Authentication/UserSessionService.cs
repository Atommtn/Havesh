using Amazon.Runtime.Internal.Transform;
using Havesh.Model.Model;
using Microsoft.AspNetCore.Components.Authorization;
using Havesh.Application.Services;
using Havesh.Grains;
using Havesh.Model.Data.Dashboard;
using HaveshApp.Classes.ExtensionMethods;
using Havesh.GrainInterfaces;
using Havesh.GrainInterfaces.Common;
using Havesh.Model.Contract;
using Olive;

namespace HaveshApp.Admin.Authentication;

public class UserSessionService : IUserSessionService
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IClusterClient _client;
    private readonly MyDbContext _dbContext;
    private DataProviderService? _dataProviderService;
    public event Func<MessageDto, Task> MessageReceived;
    protected static string BranchName => Environment.GetEnvironmentVariable("BranchName")!;

    public UserSessionService(IServiceProvider serviceProvider, IClusterClient client,MyDbContextFactory dbContextFactory)
    {
        _serviceProvider = serviceProvider;
        _client = client;
        _dbContext = dbContextFactory.CreateDbContextForBranch(BranchName);
        //Console.Beep();
    }

    private User? _user;

    private async Task<User> GetUserAsync()
    {
        if (Payload == null)
            return null;

        if (Payload?.UserId != null)
        {
            var userGrain = _client.GetGrain<IHaveshGrain<User>>((int)Payload?.UserId, BranchName);
            _user = await userGrain.Get();
        }

        //_dataProviderService ??= _serviceProvider.GetService<DataProviderService>();
        // if (_dataProviderService != null)
        // {
        //     await _dataProviderService.DbContext.Entry(_user).ReloadAsync();
	       //  _dataProviderService.DbContext.Actor ??= _user;
        // }

        _dbContext.Actor ??= _user;
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

    public record DebugSetting(bool? IsDebug, DateTime? date, TimeSpan? time);

    //public DebugSetting? Debug { get; set; }

    public Task NotifyNewMessageDelivered(MessageDto messageDto)
    {
        return MessageReceived.Invoke(messageDto);
    }
}