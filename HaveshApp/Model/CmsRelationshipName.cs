using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsRelationshipName
    {
        public CmsRelationshipName()
        {
            CmsRelationships = new HashSet<CmsRelationship>();
            Sites = new HashSet<CmsSite>();
        }

        public int RelationshipNameId { get; set; }
        public string RelationshipDisplayName { get; set; } = null!;
        public string RelationshipName { get; set; } = null!;
        public string? RelationshipAllowedObjects { get; set; }
        public Guid RelationshipGuid { get; set; }
        public DateTime RelationshipLastModified { get; set; }
        public bool? RelationshipNameIsAdHoc { get; set; }

        public virtual ICollection<CmsRelationship> CmsRelationships { get; set; }

        public virtual ICollection<CmsSite> Sites { get; set; }
    }
}
