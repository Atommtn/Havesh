using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class FormShokouhOnlinePortalContact
    {
        public int ContactId { get; set; }
        public DateTime FormInserted { get; set; }
        public DateTime FormUpdated { get; set; }
        public string YourName { get; set; } = null!;
        public string Emailinput { get; set; } = null!;
        public string? Subje { get; set; }
        public string Message { get; set; } = null!;
    }
}
