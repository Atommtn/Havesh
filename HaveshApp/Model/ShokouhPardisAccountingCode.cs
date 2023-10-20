using HaveshApp.Data;
using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ShokouhPardisAccountingCode : BranchBaseModel
	{
        public int AccountingCodeId { get; set; }
        public Guid AccountingCodeGuid { get; set; }
        public DateTime AccountingCodeLastModified { get; set; }
        public int? AccountingCodeParentId { get; set; }
        public string? Title { get; set; }
        public int? AccountType { get; set; }
        public string? Describtion { get; set; }
        public string? Code { get; set; }
        public int? SubjectRecFk { get; set; }
        public int? LastSq { get; set; }
    }
}
