using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ViewCmsResourceStringJoined
    {
        public int StringId { get; set; }
        public string StringKey { get; set; } = null!;
        public bool StringIsCustom { get; set; }
        public int? TranslationId { get; set; }
        public int? TranslationStringId { get; set; }
        public int? TranslationCultureId { get; set; }
        public string? TranslationText { get; set; }
        public int? CultureId { get; set; }
        public string? CultureName { get; set; }
        public string? CultureCode { get; set; }
        public Guid? CultureGuid { get; set; }
        public DateTime? CultureLastModified { get; set; }
    }
}
