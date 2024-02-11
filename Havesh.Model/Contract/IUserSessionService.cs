using Havesh.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havesh.Model.Contract
{
    public interface IUserSessionService
    {
        public Task<User> GetUserOrLoadAsync();
        public void ResetUser();

        public User User { get; }

        public DateTime? LastJvDate { get; set; }
        public string? Token { get; set; }
        
        public string? UserName { get; }
        public string? FullName { get; }

    }
}
