using Microsoft.AspNetCore.Components.Authorization;
using HaveshApp.Admin.MemberShip.Model;
using HaveshApp.Classes;
using HaveshApp.Services;

namespace HaveshApp.Admin.Authentication
{
    public class UserSessionService
    {
	    private readonly IServiceProvider _serviceProvider;
	    private DataProviderService? _dataProviderService;
	    public event Func<MessageDto,Task> MessageReceived;

		public UserSessionService(IServiceProvider serviceProvider)
        {
	        _serviceProvider = serviceProvider;
        }

        private User? _user;
        public User? User
        {
            get
            {
                if (_user != null)
                {
                    return _user;
                }

                _dataProviderService ??= _serviceProvider.GetService<DataProviderService>();
                _user = _dataProviderService?.GetUserByUserName(Payload?.UserName);
                return _user;
            }
        }

        
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
}
