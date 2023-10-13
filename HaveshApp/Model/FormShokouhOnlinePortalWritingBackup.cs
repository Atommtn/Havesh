using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class FormShokouhOnlinePortalWritingBackup
    {
        public int WritingBackupId { get; set; }
        public DateTime FormInserted { get; set; }
        public DateTime FormUpdated { get; set; }
        public string Student { get; set; } = null!;
        public string Teacher { get; set; } = null!;
        public string? DropDownListControl { get; set; }
        public string YourLevel { get; set; } = null!;
        public string YourWriting { get; set; } = null!;
    }
}
