using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class FormAbbasarabzadehArabzadehContact
    {
        public int ArabzadehContactId { get; set; }
        public DateTime FormInserted { get; set; }
        public DateTime FormUpdated { get; set; }
        public string YourName { get; set; } = null!;
        public string YourEmail { get; set; } = null!;
        public string? Subject { get; set; }
        public string Message { get; set; } = null!;
    }
}
