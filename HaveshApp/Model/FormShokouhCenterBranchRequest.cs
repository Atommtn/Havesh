using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class FormShokouhCenterBranchRequest
    {
        public int BranchRequestId { get; set; }
        public DateTime FormInserted { get; set; }
        public DateTime FormUpdated { get; set; }
        public string TextBoxControl { get; set; } = null!;
        public string TextBoxControl1 { get; set; } = null!;
        public DateTime? CalendarControl { get; set; }
        public DateTime? CalendarControl1 { get; set; }
        public string MultipleChoiceControl { get; set; } = null!;
        public string? DropDownListControl { get; set; }
        public string? TextBoxControl2 { get; set; }
        public string? TextBoxControl3 { get; set; }
        public string? TextAreaControl { get; set; }
        public string? TextAreaControl1 { get; set; }
        public string? TextBoxControl4 { get; set; }
        public string? TextBoxControl5 { get; set; }
        public string? TextBoxControl6 { get; set; }
        public string? TextBoxControl7 { get; set; }
        public string? Emailinput { get; set; }
        public string? TextAreaControl2 { get; set; }
        public string? TextAreaControl3 { get; set; }
    }
}
