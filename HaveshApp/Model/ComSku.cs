using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComSku
    {
        public ComSku()
        {
            CmsTrees = new HashSet<CmsTree>();
            ComMultiBuyDiscounts = new HashSet<ComMultiBuyDiscount>();
            ComOrderItems = new HashSet<ComOrderItem>();
            ComShoppingCartSkus = new HashSet<ComShoppingCartSku>();
            ComSkufiles = new HashSet<ComSkufile>();
            ComSkuoptionCategories = new HashSet<ComSkuoptionCategory>();
            ComVolumeDiscounts = new HashSet<ComVolumeDiscount>();
            ComWishlists = new HashSet<ComWishlist>();
            InverseSkuparentSku = new HashSet<ComSku>();
            Bundles = new HashSet<ComSku>();
            MultiBuyDiscounts = new HashSet<ComMultiBuyDiscount>();
            OptionSkus = new HashSet<ComSku>();
            OptionSkusNavigation = new HashSet<ComSku>();
            Skus = new HashSet<ComSku>();
            SkusNavigation = new HashSet<ComSku>();
            VariantSkus = new HashSet<ComSku>();
        }

        public int Skuid { get; set; }
        public string? Skunumber { get; set; }
        public string Skuname { get; set; } = null!;
        public string? Skudescription { get; set; }
        public decimal Skuprice { get; set; }
        public bool? Skuenabled { get; set; }
        public int? SkudepartmentId { get; set; }
        public int? SkumanufacturerId { get; set; }
        public int? SkuinternalStatusId { get; set; }
        public int? SkupublicStatusId { get; set; }
        public int? SkusupplierId { get; set; }
        public int? SkuavailableInDays { get; set; }
        public Guid Skuguid { get; set; }
        public string? SkuimagePath { get; set; }
        public double? Skuweight { get; set; }
        public double? Skuwidth { get; set; }
        public double? Skudepth { get; set; }
        public double? Skuheight { get; set; }
        public int? SkuavailableItems { get; set; }
        public bool? SkusellOnlyAvailable { get; set; }
        public string? SkucustomData { get; set; }
        public int? SkuoptionCategoryId { get; set; }
        public int? Skuorder { get; set; }
        public DateTime SkulastModified { get; set; }
        public DateTime? Skucreated { get; set; }
        public int? SkusiteId { get; set; }
        public bool? SkuneedsShipping { get; set; }
        public DateTime? SkuvalidUntil { get; set; }
        public string? SkuproductType { get; set; }
        public int? SkumaxItemsInOrder { get; set; }
        public string? Skuvalidity { get; set; }
        public int? SkuvalidFor { get; set; }
        public Guid? SkumembershipGuid { get; set; }
        public string? SkuconversionName { get; set; }
        public string? SkuconversionValue { get; set; }
        public string? SkubundleInventoryType { get; set; }
        public int? SkuminItemsInOrder { get; set; }
        public decimal? SkuretailPrice { get; set; }
        public int? SkuparentSkuid { get; set; }
        public string? SkushortDescription { get; set; }
        public int? SkueproductFilesCount { get; set; }
        public int? SkubundleItemsCount { get; set; }
        public DateTime? SkuinStoreFrom { get; set; }
        public int? SkureorderAt { get; set; }
        public string? SkutrackInventory { get; set; }
        public int? SkutaxClassId { get; set; }
        public int? SkubrandId { get; set; }
        public int? SkucollectionId { get; set; }

        public virtual ComBrand? Skubrand { get; set; }
        public virtual ComCollection? Skucollection { get; set; }
        public virtual ComDepartment? Skudepartment { get; set; }
        public virtual ComInternalStatus? SkuinternalStatus { get; set; }
        public virtual ComManufacturer? Skumanufacturer { get; set; }
        public virtual ComOptionCategory? SkuoptionCategory { get; set; }
        public virtual ComSku? SkuparentSku { get; set; }
        public virtual ComPublicStatus? SkupublicStatus { get; set; }
        public virtual CmsSite? Skusite { get; set; }
        public virtual ComSupplier? Skusupplier { get; set; }
        public virtual ComTaxClass? SkutaxClass { get; set; }
        public virtual ICollection<CmsTree> CmsTrees { get; set; }
        public virtual ICollection<ComMultiBuyDiscount> ComMultiBuyDiscounts { get; set; }
        public virtual ICollection<ComOrderItem> ComOrderItems { get; set; }
        public virtual ICollection<ComShoppingCartSku> ComShoppingCartSkus { get; set; }
        public virtual ICollection<ComSkufile> ComSkufiles { get; set; }
        public virtual ICollection<ComSkuoptionCategory> ComSkuoptionCategories { get; set; }
        public virtual ICollection<ComVolumeDiscount> ComVolumeDiscounts { get; set; }
        public virtual ICollection<ComWishlist> ComWishlists { get; set; }
        public virtual ICollection<ComSku> InverseSkuparentSku { get; set; }

        public virtual ICollection<ComSku> Bundles { get; set; }
        public virtual ICollection<ComMultiBuyDiscount> MultiBuyDiscounts { get; set; }
        public virtual ICollection<ComSku> OptionSkus { get; set; }
        public virtual ICollection<ComSku> OptionSkusNavigation { get; set; }
        public virtual ICollection<ComSku> Skus { get; set; }
        public virtual ICollection<ComSku> SkusNavigation { get; set; }
        public virtual ICollection<ComSku> VariantSkus { get; set; }
    }
}
