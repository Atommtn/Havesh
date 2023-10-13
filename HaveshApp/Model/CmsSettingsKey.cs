using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsSettingsKey
    {
        public int KeyId { get; set; }
        public string KeyName { get; set; } = null!;
        public string KeyDisplayName { get; set; } = null!;
        public string? KeyDescription { get; set; }
        public string? KeyValue { get; set; }
        public string KeyType { get; set; } = null!;
        public int? KeyCategoryId { get; set; }
        public int? SiteId { get; set; }
        public Guid KeyGuid { get; set; }
        public DateTime KeyLastModified { get; set; }
        public int? KeyOrder { get; set; }
        public string? KeyDefaultValue { get; set; }
        public string? KeyValidation { get; set; }
        public string? KeyEditingControlPath { get; set; }
        public bool? KeyIsGlobal { get; set; }
        public bool? KeyIsCustom { get; set; }
        public bool? KeyIsHidden { get; set; }
        public string? KeyFormControlSettings { get; set; }
        public string? KeyExplanationText { get; set; }

        public virtual CmsSettingsCategory? KeyCategory { get; set; }
        public virtual CmsSite? Site { get; set; }
    }
}
