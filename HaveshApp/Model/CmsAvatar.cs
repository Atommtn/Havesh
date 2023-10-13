using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsAvatar
    {
        public CmsAvatar()
        {
            CmsUserSettings = new HashSet<CmsUserSetting>();
            CommunityGroups = new HashSet<CommunityGroup>();
        }

        public int AvatarId { get; set; }
        public string? AvatarName { get; set; }
        public string AvatarFileName { get; set; } = null!;
        public string AvatarFileExtension { get; set; } = null!;
        public byte[]? AvatarBinary { get; set; }
        public string AvatarType { get; set; } = null!;
        public bool AvatarIsCustom { get; set; }
        public Guid AvatarGuid { get; set; }
        public DateTime AvatarLastModified { get; set; }
        public string AvatarMimeType { get; set; } = null!;
        public int AvatarFileSize { get; set; }
        public int? AvatarImageHeight { get; set; }
        public int? AvatarImageWidth { get; set; }
        public bool? DefaultMaleUserAvatar { get; set; }
        public bool? DefaultFemaleUserAvatar { get; set; }
        public bool? DefaultGroupAvatar { get; set; }
        public bool? DefaultUserAvatar { get; set; }

        public virtual ICollection<CmsUserSetting> CmsUserSettings { get; set; }
        public virtual ICollection<CommunityGroup> CommunityGroups { get; set; }
    }
}
