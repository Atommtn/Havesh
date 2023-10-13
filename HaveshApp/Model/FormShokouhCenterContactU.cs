using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class FormShokouhCenterContactU
    {
        public int ContactUsId { get; set; }
        public DateTime FormInserted { get; set; }
        public DateTime FormUpdated { get; set; }
        public string? Emailinput { get; set; }
        public string TextBoxControl { get; set; } = null!;
        public string TextBoxControl1 { get; set; } = null!;
        public string? HtmlAreaControl { get; set; }
        public string TextAreaControl { get; set; } = null!;
    }
}
