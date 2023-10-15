using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsResource
    {
        public CmsResource()
        {
            CmsClasses = new HashSet<CmsClass>();
            CmsFormUserControls = new HashSet<CmsFormUserControl>();
            CmsModuleLicenseKeys = new HashSet<CmsModuleLicenseKey>();
            CmsPermissions = new HashSet<CmsPermission>();
            CmsResourceLibraries = new HashSet<CmsResourceLibrary>();
            CmsScheduledTasks = new HashSet<CmsScheduledTask>();
            CmsSettingsCategories = new HashSet<CmsSettingsCategory>();
            CmsUielements = new HashSet<CmsUielement>();
            CmsWebParts = new HashSet<CmsWebPart>();
            CmsWorkflowActions = new HashSet<CmsWorkflowAction>();
            Sites = new HashSet<CmsSite>();
        }

        public int ResourceId { get; set; }
        public string ResourceDisplayName { get; set; } = null!;
        public string ResourceName { get; set; } = null!;
        public string? ResourceDescription { get; set; }
        public bool? ShowInDevelopment { get; set; }
        public string? ResourceUrl { get; set; }
        public Guid ResourceGuid { get; set; }
        public DateTime ResourceLastModified { get; set; }
        public bool? ResourceIsInDevelopment { get; set; }
        public bool? ResourceHasFiles { get; set; }
        public string? ResourceVersion { get; set; }
        public string? ResourceAuthor { get; set; }
        public string? ResourceInstallationState { get; set; }
        public string? ResourceInstalledVersion { get; set; }

        public virtual ICollection<CmsClass> CmsClasses { get; set; }
        public virtual ICollection<CmsFormUserControl> CmsFormUserControls { get; set; }
        public virtual ICollection<CmsModuleLicenseKey> CmsModuleLicenseKeys { get; set; }
        public virtual ICollection<CmsPermission> CmsPermissions { get; set; }
        public virtual ICollection<CmsResourceLibrary> CmsResourceLibraries { get; set; }
        public virtual ICollection<CmsScheduledTask> CmsScheduledTasks { get; set; }
        public virtual ICollection<CmsSettingsCategory> CmsSettingsCategories { get; set; }
        public virtual ICollection<CmsUielement> CmsUielements { get; set; }
        public virtual ICollection<CmsWebPart> CmsWebParts { get; set; }
        public virtual ICollection<CmsWorkflowAction> CmsWorkflowActions { get; set; }

        public virtual ICollection<CmsSite> Sites { get; set; }
    }
}
