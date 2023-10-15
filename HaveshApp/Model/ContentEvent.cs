using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ContentEvent
    {
        public int EventId { get; set; }
        public string EventName { get; set; } = null!;
        public string? EventSummary { get; set; }
        public string? EventDetails { get; set; }
        public string? EventLocation { get; set; }
        public DateTime? EventDate { get; set; }
    }
}
