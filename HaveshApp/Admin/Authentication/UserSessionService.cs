using Microsoft.AspNetCore.Components.Authorization;
using ShokouhApp.Admin.MemberShip.Model;
using ShokouhApp.Services;

namespace ShokouhApp.Admin.Authentication
{
    public class UserSessionService
    {
        private readonly DataProviderService _dataProviderService;

        public UserSessionService(DataProviderService dataProviderService)
        {
            _dataProviderService = dataProviderService;
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

                _user = _dataProviderService.GetUserByUserName(Payload.UserName);
                return _user;
            }
        }

        
        public DateTime? LastJvDate { get; set; } = DateTime.Today;
        public Payload? Payload { get; set; }
        public string? Token { get; set; }
        public Task<AuthenticationState>? State { get; set; }

        public string? UserName => Payload?.UserName;
        public string? FullName => Payload?.FirstName + " " + Payload?.LastName;
    }
}
