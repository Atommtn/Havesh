using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class IntranetPortalWorkingEnvironment
    {
        public int WorkingenvironmentId { get; set; }
        public DateTime FormInserted { get; set; }
        public DateTime FormUpdated { get; set; }
        public string? YourName { get; set; }
        public string OfficeSatisfaction { get; set; } = null!;
        public string? Suggestions { get; set; }
    }
}
