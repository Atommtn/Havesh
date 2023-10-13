using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsPageTemplate
    {
        public CmsPageTemplate()
        {
            CmsClasses = new HashSet<CmsClass>();
            CmsDocuments = new HashSet<CmsDocument>();
            CmsPageTemplateScopes = new HashSet<CmsPageTemplateScope>();
            CmsTemplateDeviceLayouts = new HashSet<CmsTemplateDeviceLayout>();
            CmsTrees = new HashSet<CmsTree>();
            CmsUielements = new HashSet<CmsUielement>();
            OmMvtvariants = new HashSet<OmMvtvariant>();
            OmPersonalizationVariants = new HashSet<OmPersonalizationVariant>();
            Sites = new HashSet<CmsSite>();
        }

        public int PageTemplateId { get; set; }
        public string PageTemplateDisplayName { get; set; } = null!;
        public string PageTemplateCodeName { get; set; } = null!;
        public string? PageTemplateDescription { get; set; }
        public string? PageTemplateFile { get; set; }
        public int? PageTemplateCategoryId { get; set; }
        public int? PageTemplateLayoutId { get; set; }
        public string? PageTemplateWebParts { get; set; }
        public bool? PageTemplateIsReusable { get; set; }
        public bool? PageTemplateShowAsMasterTemplate { get; set; }
        public string? PageTemplateInheritPageLevels { get; set; }
        public string? PageTemplateLayout { get; set; }
        public string? PageTemplateVersionGuid { get; set; }
        public string? PageTemplateHeader { get; set; }
        public Guid PageTemplateGuid { get; set; }
        public DateTime PageTemplateLastModified { get; set; }
        public int? PageTemplateSiteId { get; set; }
        public bool? PageTemplateForAllPages { get; set; }
        public string PageTemplateType { get; set; } = null!;
        public string? PageTemplateLayoutType { get; set; }
        public string? PageTemplateCss { get; set; }
        public bool? PageTemplateIsAllowedForProductSection { get; set; }
        public bool? PageTemplateInheritParentHeader { get; set; }
        public bool? PageTemplateAllowInheritHeader { get; set; }
        public Guid? PageTemplateThumbnailGuid { get; set; }
        public bool? PageTemplateCloneAsAdHoc { get; set; }
        public Guid? PageTemplateNodeGuid { get; set; }
        public int? PageTemplateMasterPageTemplateId { get; set; }
        public string? PageTemplateProperties { get; set; }
        public bool? PageTemplateIsLayout { get; set; }
        public string? PageTemplateIconClass { get; set; }

        public virtual CmsPageTemplateCategory? PageTemplateCategory { get; set; }
        public virtual CmsLayout? PageTemplateLayoutNavigation { get; set; }
        public virtual CmsSite? PageTemplateSite { get; set; }
        public virtual ICollection<CmsClass> CmsClasses { get; set; }
        public virtual ICollection<CmsDocument> CmsDocuments { get; set; }
        public virtual ICollection<CmsPageTemplateScope> CmsPageTemplateScopes { get; set; }
        public virtual ICollection<CmsTemplateDeviceLayout> CmsTemplateDeviceLayouts { get; set; }
        public virtual ICollection<CmsTree> CmsTrees { get; set; }
        public virtual ICollection<CmsUielement> CmsUielements { get; set; }
        public virtual ICollection<OmMvtvariant> OmMvtvariants { get; set; }
        public virtual ICollection<OmPersonalizationVariant> OmPersonalizationVariants { get; set; }

        public virtual ICollection<CmsSite> Sites { get; set; }
    }
}
