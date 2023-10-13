using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class IntranetPortalDepartment
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string? DepartmentDescription { get; set; }
        public Guid? DepartmentAvatar { get; set; }
        public string? DepartmentSections { get; set; }
        public string? DepartmentRoles { get; set; }
    }
}
