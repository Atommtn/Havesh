using System.ComponentModel.DataAnnotations.Schema;
using HaveshApp.Admin.MemberShip.Model;

namespace HaveshApp.Model
{
    public partial class InboxMessage
    {
        [ForeignKey(nameof(UserFk))]
        public User User { get; set; }
        //[ForeignKey(nameof(TodoCompleteBy))]
        //public User User1 { get; set; }
    }
}
