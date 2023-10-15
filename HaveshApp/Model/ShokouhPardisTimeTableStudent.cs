using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ShokouhPardisTimeTableStudent
    {
        public int TimeTableStudentsId { get; set; }
        public Guid TimeTableStudentsGuid { get; set; }
        public DateTime TimeTableStudentsLastModified { get; set; }
        public int TimeTableId { get; set; }
        public int? StudentId { get; set; }
        public bool? IsPaymentComplete { get; set; }
        public int? StudentPercentDiscount { get; set; }
        public int? StudentAmountDiscount { get; set; }
        public bool? IsBookPaymentComplete { get; set; }
        public string? Description { get; set; }
    }
}
