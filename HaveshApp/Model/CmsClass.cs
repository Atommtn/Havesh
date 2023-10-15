using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsClass
    {
        public CmsClass()
        {
            CmsAlternativeFormFormClasses = new HashSet<CmsAlternativeForm>();
            CmsAlternativeFormFormCoupledClasses = new HashSet<CmsAlternativeForm>();
            CmsForms = new HashSet<CmsForm>();
            CmsPageTemplateScopes = new HashSet<CmsPageTemplateScope>();
            CmsPermissions = new HashSet<CmsPermission>();
            CmsQueries = new HashSet<CmsQuery>();
            CmsTransformations = new HashSet<CmsTransformation>();
            CmsTrees = new HashSet<CmsTree>();
            CmsVersionHistories = new HashSet<CmsVersionHistory>();
            CmsWorkflowScopes = new HashSet<CmsWorkflowScope>();
            ChildClasses = new HashSet<CmsClass>();
            ParentClasses = new HashSet<CmsClass>();
            Scopes = new HashSet<CmsDocumentTypeScope>();
            Sites = new HashSet<CmsSite>();
        }

        public int ClassId { get; set; }
        public string ClassDisplayName { get; set; } = null!;
        public string ClassName { get; set; } = null!;
        public bool ClassUsesVersioning { get; set; }
        public bool ClassIsDocumentType { get; set; }
        public bool ClassIsCoupledClass { get; set; }
        public string ClassXmlSchema { get; set; } = null!;
        public string ClassFormDefinition { get; set; } = null!;
        public string? ClassEditingPageUrl { get; set; }
        public string? ClassListPageUrl { get; set; }
        public string ClassNodeNameSource { get; set; } = null!;
        public string? ClassTableName { get; set; }
        public string? ClassViewPageUrl { get; set; }
        public string? ClassPreviewPageUrl { get; set; }
        public string? ClassFormLayout { get; set; }
        public string? ClassNewPageUrl { get; set; }
        public bool? ClassShowAsSystemTable { get; set; }
        public bool? ClassUsePublishFromTo { get; set; }
        public bool? ClassShowTemplateSelection { get; set; }
        public string? ClassSkumappings { get; set; }
        public bool? ClassIsMenuItemType { get; set; }
        public string? ClassNodeAliasSource { get; set; }
        public int? ClassDefaultPageTemplateId { get; set; }
        public DateTime ClassLastModified { get; set; }
        public Guid ClassGuid { get; set; }
        public bool? ClassCreateSku { get; set; }
        public bool? ClassIsProduct { get; set; }
        public bool ClassIsCustomTable { get; set; }
        public string? ClassShowColumns { get; set; }
        public string? ClassSearchTitleColumn { get; set; }
        public string? ClassSearchContentColumn { get; set; }
        public string? ClassSearchImageColumn { get; set; }
        public string? ClassSearchCreationDateColumn { get; set; }
        public string? ClassSearchSettings { get; set; }
        public int? ClassInheritsFromClassId { get; set; }
        public bool? ClassSearchEnabled { get; set; }
        public string? ClassSkudefaultDepartmentName { get; set; }
        public int? ClassSkudefaultDepartmentId { get; set; }
        public string? ClassContactMapping { get; set; }
        public bool? ClassContactOverwriteEnabled { get; set; }
        public string? ClassSkudefaultProductType { get; set; }
        public string? ClassConnectionString { get; set; }
        public bool? ClassIsProductSection { get; set; }
        public int? ClassPageTemplateCategoryId { get; set; }
        public string? ClassFormLayoutType { get; set; }
        public string? ClassVersionGuid { get; set; }
        public string? ClassDefaultObjectType { get; set; }
        public bool? ClassIsForm { get; set; }
        public int? ClassResourceId { get; set; }
        public string? ClassCustomizedColumns { get; set; }
        public string? ClassCodeGenerationSettings { get; set; }
        public string? ClassIconClass { get; set; }
        public bool? ClassIsContentOnly { get; set; }
        public string? ClassUrlpattern { get; set; }

        public virtual CmsPageTemplate? ClassDefaultPageTemplate { get; set; }
        public virtual CmsPageTemplateCategory? ClassPageTemplateCategory { get; set; }
        public virtual CmsResource? ClassResource { get; set; }
        public virtual ICollection<CmsAlternativeForm> CmsAlternativeFormFormClasses { get; set; }
        public virtual ICollection<CmsAlternativeForm> CmsAlternativeFormFormCoupledClasses { get; set; }
        public virtual ICollection<CmsForm> CmsForms { get; set; }
        public virtual ICollection<CmsPageTemplateScope> CmsPageTemplateScopes { get; set; }
        public virtual ICollection<CmsPermission> CmsPermissions { get; set; }
        public virtual ICollection<CmsQuery> CmsQueries { get; set; }
        public virtual ICollection<CmsTransformation> CmsTransformations { get; set; }
        public virtual ICollection<CmsTree> CmsTrees { get; set; }
        public virtual ICollection<CmsVersionHistory> CmsVersionHistories { get; set; }
        public virtual ICollection<CmsWorkflowScope> CmsWorkflowScopes { get; set; }

        public virtual ICollection<CmsClass> ChildClasses { get; set; }
        public virtual ICollection<CmsClass> ParentClasses { get; set; }
        public virtual ICollection<CmsDocumentTypeScope> Scopes { get; set; }
        public virtual ICollection<CmsSite> Sites { get; set; }
    }
}
