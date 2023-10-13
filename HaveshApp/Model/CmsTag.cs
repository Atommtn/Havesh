using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsTag
    {
        public CmsTag()
        {
            Documents = new HashSet<CmsDocument>();
        }

        public int TagId { get; set; }
        public string TagName { get; set; } = null!;
        public int TagCount { get; set; }
        public int TagGroupId { get; set; }
        public Guid TagGuid { get; set; }

        public virtual CmsTagGroup TagGroup { get; set; } = null!;

        public virtual ICollection<CmsDocument> Documents { get; set; }
    }
}
