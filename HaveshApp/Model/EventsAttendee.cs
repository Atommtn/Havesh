using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class EventsAttendee
    {
        public int AttendeeId { get; set; }
        public string AttendeeEmail { get; set; } = null!;
        public string? AttendeeFirstName { get; set; }
        public string? AttendeeLastName { get; set; }
        public string? AttendeePhone { get; set; }
        public int AttendeeEventNodeId { get; set; }
        public Guid AttendeeGuid { get; set; }
        public DateTime AttendeeLastModified { get; set; }

        public virtual CmsTree AttendeeEventNode { get; set; } = null!;
    }
}
