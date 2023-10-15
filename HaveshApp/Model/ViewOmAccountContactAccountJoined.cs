using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ViewOmAccountContactAccountJoined
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; } = null!;
        public int ContactId { get; set; }
        public int AccountContactId { get; set; }
        public int? ContactRoleId { get; set; }
        public int? AccountCountryId { get; set; }
        public int? AccountStatusId { get; set; }
    }
}
