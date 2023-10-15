using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class BadWordsWord
    {
        public BadWordsWord()
        {
            Cultures = new HashSet<CmsCulture>();
        }

        public int WordId { get; set; }
        public Guid WordGuid { get; set; }
        public DateTime WordLastModified { get; set; }
        public string WordExpression { get; set; } = null!;
        public string? WordReplacement { get; set; }
        public int? WordAction { get; set; }
        public bool WordIsGlobal { get; set; }
        public bool WordIsRegularExpression { get; set; }
        public bool? WordMatchWholeWord { get; set; }

        public virtual ICollection<CmsCulture> Cultures { get; set; }
    }
}
