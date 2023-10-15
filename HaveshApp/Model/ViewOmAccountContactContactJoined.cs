using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ViewOmAccountContactContactJoined
    {
        public int ContactId { get; set; }
        public string? ContactFirstName { get; set; }
        public string? ContactMiddleName { get; set; }
        public string? ContactLastName { get; set; }
        public string? ContactEmail { get; set; }
        public int AccountId { get; set; }
        public int AccountContactId { get; set; }
        public int? ContactCountryId { get; set; }
        public int? ContactStatusId { get; set; }
        public int? ContactRoleId { get; set; }
    }
}
