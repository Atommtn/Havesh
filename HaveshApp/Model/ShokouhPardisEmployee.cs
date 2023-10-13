using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ShokouhPardisEmployee
    {
        public int EmployeeId { get; set; }
        public Guid EmployeeGuid { get; set; }
        public DateTime EmployeeLastModified { get; set; }
        public string? Title { get; set; }
    }
}
