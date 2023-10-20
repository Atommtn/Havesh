using HaveshApp.Data;
using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ShokouhPardisTermClass : BranchBaseModel
	{
        public int TermClassId { get; set; }
        public Guid TermClassGuid { get; set; }
        public DateTime TermClassLastModified { get; set; }
        public string? TermName { get; set; }
        public int YearId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
