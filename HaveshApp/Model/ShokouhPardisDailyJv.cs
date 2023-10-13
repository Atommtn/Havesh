using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ShokouhPardisDailyJv
    {
        public int DailyJvid { get; set; }
        public Guid DailyJvguid { get; set; }
        public DateTime DailyJvlastModified { get; set; }
        public int TermId { get; set; }
        public int StudentId { get; set; }
        public DateTime? CurrentDate { get; set; }
        public string? PaymentType { get; set; }
        public int Fee { get; set; }
        public int? BillNo { get; set; }
        public string? FeeFor { get; set; }
        public DateTime? DateOfSettle { get; set; }
        public string? Txcode { get; set; }
        public string? Description { get; set; }
        public int? PosCode { get; set; }
        public string? CardPostfix { get; set; }
        public int? JvFromSiteFk { get; set; }
        
        public int? TimeTableFk { get; set; }
        public bool? IsPreRegister { get; set; }
        
    }
}
