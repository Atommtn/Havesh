using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ContentFaq
    {
        public int Faqid { get; set; }
        public string Faqquestion { get; set; } = null!;
        public string Faqanswer { get; set; } = null!;
    }
}
