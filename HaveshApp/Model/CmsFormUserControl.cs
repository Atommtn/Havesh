using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsFormUserControl
    {
        public CmsFormUserControl()
        {
            InverseUserControlParent = new HashSet<CmsFormUserControl>();
        }

        public int UserControlId { get; set; }
        public string UserControlDisplayName { get; set; } = null!;
        public string UserControlCodeName { get; set; } = null!;
        public string UserControlFileName { get; set; } = null!;
        public bool UserControlForText { get; set; }
        public bool UserControlForLongText { get; set; }
        public bool UserControlForInteger { get; set; }
        public bool UserControlForDecimal { get; set; }
        public bool UserControlForDateTime { get; set; }
        public bool UserControlForBoolean { get; set; }
        public bool UserControlForFile { get; set; }
        public bool UserControlShowInBizForms { get; set; }
        public string UserControlDefaultDataType { get; set; } = null!;
        public int? UserControlDefaultDataTypeSize { get; set; }
        public bool? UserControlShowInDocumentTypes { get; set; }
        public bool? UserControlShowInSystemTables { get; set; }
        public bool? UserControlShowInWebParts { get; set; }
        public bool? UserControlShowInReports { get; set; }
        public Guid UserControlGuid { get; set; }
        public DateTime UserControlLastModified { get; set; }
        public bool UserControlForGuid { get; set; }
        public bool? UserControlShowInCustomTables { get; set; }
        public bool UserControlForVisibility { get; set; }
        public string? UserControlParameters { get; set; }
        public bool UserControlForDocAttachments { get; set; }
        public int? UserControlResourceId { get; set; }
        public int? UserControlType { get; set; }
        public int? UserControlParentId { get; set; }
        public string? UserControlDescription { get; set; }
        public Guid? UserControlThumbnailGuid { get; set; }
        public int? UserControlPriority { get; set; }
        public bool? UserControlIsSystem { get; set; }
        public bool UserControlForBinary { get; set; }
        public bool UserControlForDocRelationships { get; set; }
        public string? UserControlAssemblyName { get; set; }
        public string? UserControlClassName { get; set; }

        public virtual CmsFormUserControl? UserControlParent { get; set; }
        public virtual CmsResource? UserControlResource { get; set; }
        public virtual ICollection<CmsFormUserControl> InverseUserControlParent { get; set; }
    }
}
