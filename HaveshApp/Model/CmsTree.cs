using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsTree
    {
        public CmsTree()
        {
            CmsDocumentAliases = new HashSet<CmsDocumentAlias>();
            CmsDocuments = new HashSet<CmsDocument>();
            CmsRelationshipLeftNodes = new HashSet<CmsRelationship>();
            CmsRelationshipRightNodes = new HashSet<CmsRelationship>();
            ComMultiBuyDiscountTrees = new HashSet<ComMultiBuyDiscountTree>();
            EventsAttendees = new HashSet<EventsAttendee>();
            InverseNodeLinkedNode = new HashSet<CmsTree>();
            InverseNodeOriginalNode = new HashSet<CmsTree>();
            InverseNodeParent = new HashSet<CmsTree>();
            PersonasPersonaNodes = new HashSet<PersonasPersonaNode>();
        }

        public int NodeId { get; set; }
        public string NodeAliasPath { get; set; } = null!;
        public string NodeName { get; set; } = null!;
        public string NodeAlias { get; set; } = null!;
        public int NodeClassId { get; set; }
        public int? NodeParentId { get; set; }
        public int NodeLevel { get; set; }
        public int? NodeAclid { get; set; }
        public int NodeSiteId { get; set; }
        public Guid NodeGuid { get; set; }
        public int? NodeOrder { get; set; }
        public bool? IsSecuredNode { get; set; }
        public int? NodeCacheMinutes { get; set; }
        public int? NodeSkuid { get; set; }
        public string? NodeDocType { get; set; }
        public string? NodeHeadTags { get; set; }
        public string? NodeBodyElementAttributes { get; set; }
        public string? NodeInheritPageLevels { get; set; }
        public int? RequiresSsl { get; set; }
        public int? NodeLinkedNodeId { get; set; }
        public int? NodeOwner { get; set; }
        public string? NodeCustomData { get; set; }
        public int? NodeGroupId { get; set; }
        public int? NodeLinkedNodeSiteId { get; set; }
        public int? NodeTemplateId { get; set; }
        public bool? NodeTemplateForAllCultures { get; set; }
        public bool? NodeInheritPageTemplate { get; set; }
        public bool? NodeAllowCacheInFileSystem { get; set; }
        public bool? NodeHasChildren { get; set; }
        public bool? NodeHasLinks { get; set; }
        public int? NodeOriginalNodeId { get; set; }
        public bool NodeIsContentOnly { get; set; }
        public bool NodeIsAclowner { get; set; }
        public string? NodeBodyScripts { get; set; }

        public virtual CmsAcl? NodeAcl { get; set; }
        public virtual CmsClass NodeClass { get; set; } = null!;
        public virtual CommunityGroup? NodeGroup { get; set; }
        public virtual CmsTree? NodeLinkedNode { get; set; }
        public virtual CmsSite? NodeLinkedNodeSite { get; set; }
        public virtual CmsTree? NodeOriginalNode { get; set; }
        public virtual CmsUser? NodeOwnerNavigation { get; set; }
        public virtual CmsTree? NodeParent { get; set; }
        public virtual CmsSite NodeSite { get; set; } = null!;
        public virtual ComSku? NodeSku { get; set; }
        public virtual CmsPageTemplate? NodeTemplate { get; set; }
        public virtual ICollection<CmsDocumentAlias> CmsDocumentAliases { get; set; }
        public virtual ICollection<CmsDocument> CmsDocuments { get; set; }
        public virtual ICollection<CmsRelationship> CmsRelationshipLeftNodes { get; set; }
        public virtual ICollection<CmsRelationship> CmsRelationshipRightNodes { get; set; }
        public virtual ICollection<ComMultiBuyDiscountTree> ComMultiBuyDiscountTrees { get; set; }
        public virtual ICollection<EventsAttendee> EventsAttendees { get; set; }
        public virtual ICollection<CmsTree> InverseNodeLinkedNode { get; set; }
        public virtual ICollection<CmsTree> InverseNodeOriginalNode { get; set; }
        public virtual ICollection<CmsTree> InverseNodeParent { get; set; }
        public virtual ICollection<PersonasPersonaNode> PersonasPersonaNodes { get; set; }
    }
}
