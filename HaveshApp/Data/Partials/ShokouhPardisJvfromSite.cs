
using System.ComponentModel.DataAnnotations.Schema;

namespace ShokouhApp.Model
{
    public partial class ShokouhPardisJvfromSite
    {
        [ForeignKey(nameof(AttachmentFk))]
        public ShokouhPardisFileAttachment FileAttachment { get; set; }
    }
}
