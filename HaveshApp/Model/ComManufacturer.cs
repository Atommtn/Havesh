using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComManufacturer
    {
        public ComManufacturer()
        {
            ComSkus = new HashSet<ComSku>();
        }

        public int ManufacturerId { get; set; }
        public string ManufacturerDisplayName { get; set; } = null!;
        public string? ManufactureHomepage { get; set; }
        public bool? ManufacturerEnabled { get; set; }
        public Guid ManufacturerGuid { get; set; }
        public DateTime ManufacturerLastModified { get; set; }
        public int? ManufacturerSiteId { get; set; }
        public Guid? ManufacturerThumbnailGuid { get; set; }
        public string? ManufacturerDescription { get; set; }
        public string? ManufacturerName { get; set; }

        public virtual CmsSite? ManufacturerSite { get; set; }
        public virtual ICollection<ComSku> ComSkus { get; set; }
    }
}
