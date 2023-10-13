using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComCollection
    {
        public ComCollection()
        {
            ComMultiBuyDiscountCollections = new HashSet<ComMultiBuyDiscountCollection>();
            ComSkus = new HashSet<ComSku>();
        }

        public int CollectionId { get; set; }
        public string CollectionDisplayName { get; set; } = null!;
        public string CollectionName { get; set; } = null!;
        public string? CollectionDescription { get; set; }
        public int CollectionSiteId { get; set; }
        public bool? CollectionEnabled { get; set; }
        public Guid CollectionGuid { get; set; }
        public DateTime CollectionLastModified { get; set; }

        public virtual CmsSite CollectionSite { get; set; } = null!;
        public virtual ICollection<ComMultiBuyDiscountCollection> ComMultiBuyDiscountCollections { get; set; }
        public virtual ICollection<ComSku> ComSkus { get; set; }
    }
}
