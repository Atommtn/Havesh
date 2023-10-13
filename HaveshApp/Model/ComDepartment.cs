using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComDepartment
    {
        public ComDepartment()
        {
            ComSkus = new HashSet<ComSku>();
            MultiBuyDiscounts = new HashSet<ComMultiBuyDiscount>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string DepartmentDisplayName { get; set; } = null!;
        public int? DepartmentDefaultTaxClassId { get; set; }
        public Guid DepartmentGuid { get; set; }
        public DateTime DepartmentLastModified { get; set; }
        public int? DepartmentSiteId { get; set; }

        public virtual ComTaxClass? DepartmentDefaultTaxClass { get; set; }
        public virtual CmsSite? DepartmentSite { get; set; }
        public virtual ICollection<ComSku> ComSkus { get; set; }

        public virtual ICollection<ComMultiBuyDiscount> MultiBuyDiscounts { get; set; }
    }
}
