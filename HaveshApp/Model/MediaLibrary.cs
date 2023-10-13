using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class MediaLibrary
    {
        public MediaLibrary()
        {
            MediaFiles = new HashSet<MediaFile>();
            MediaLibraryRolePermissions = new HashSet<MediaLibraryRolePermission>();
        }

        public int LibraryId { get; set; }
        public string LibraryName { get; set; } = null!;
        public string LibraryDisplayName { get; set; } = null!;
        public string? LibraryDescription { get; set; }
        public string LibraryFolder { get; set; } = null!;
        public int? LibraryAccess { get; set; }
        public int? LibraryGroupId { get; set; }
        public int LibrarySiteId { get; set; }
        public Guid? LibraryGuid { get; set; }
        public DateTime? LibraryLastModified { get; set; }
        public string? LibraryTeaserPath { get; set; }
        public Guid? LibraryTeaserGuid { get; set; }

        public virtual CommunityGroup? LibraryGroup { get; set; }
        public virtual CmsSite LibrarySite { get; set; } = null!;
        public virtual ICollection<MediaFile> MediaFiles { get; set; }
        public virtual ICollection<MediaLibraryRolePermission> MediaLibraryRolePermissions { get; set; }
    }
}
