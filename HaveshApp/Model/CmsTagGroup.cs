using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsTagGroup
    {
        public CmsTagGroup()
        {
            CmsDocuments = new HashSet<CmsDocument>();
            CmsTags = new HashSet<CmsTag>();
        }

        public int TagGroupId { get; set; }
        public string TagGroupDisplayName { get; set; } = null!;
        public string TagGroupName { get; set; } = null!;
        public string? TagGroupDescription { get; set; }
        public int TagGroupSiteId { get; set; }
        public bool TagGroupIsAdHoc { get; set; }
        public DateTime TagGroupLastModified { get; set; }
        public Guid TagGroupGuid { get; set; }

        public virtual CmsSite TagGroupSite { get; set; } = null!;
        public virtual ICollection<CmsDocument> CmsDocuments { get; set; }
        public virtual ICollection<CmsTag> CmsTags { get; set; }
    }
}
