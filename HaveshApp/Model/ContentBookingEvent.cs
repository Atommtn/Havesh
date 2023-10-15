using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ContentBookingEvent
    {
        public int BookingEventId { get; set; }
        public string EventName { get; set; } = null!;
        public string? EventSummary { get; set; }
        public string? EventDetails { get; set; }
        public string? EventLocation { get; set; }
        public DateTime? EventDate { get; set; }
        public DateTime? EventEndDate { get; set; }
        public bool? EventAllDay { get; set; }
        public int? EventCapacity { get; set; }
        public bool? EventAllowRegistrationOverCapacity { get; set; }
        public DateTime? EventOpenFrom { get; set; }
        public DateTime? EventOpenTo { get; set; }
        public bool? EventLogActivity { get; set; }
    }
}
