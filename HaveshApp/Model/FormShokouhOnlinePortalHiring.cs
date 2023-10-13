using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class FormShokouhOnlinePortalHiring
    {
        public int HiringId { get; set; }
        public DateTime FormInserted { get; set; }
        public DateTime FormUpdated { get; set; }
        public string Name { get; set; } = null!;
        public string Family { get; set; } = null!;
        public string Sex { get; set; } = null!;
        public DateTime? DateOfB { get; set; }
        public string? MaritalStatus { get; set; }
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string CellPhone { get; set; } = null!;
        public string PresentAddress { get; set; } = null!;
        public string? Education { get; set; }
        public string? Experience { get; set; }
        public string? Cretification { get; set; }
        public string? ActivitiesList { get; set; }
        public string Photo { get; set; } = null!;
    }
}
