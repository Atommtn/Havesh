
using System.ComponentModel.DataAnnotations.Schema;

namespace HaveshApp.Model
{
    public partial class ShokouhPardisJvfromSite
    {
        [ForeignKey(nameof(AttachmentFk))]
        public ShokouhPardisFileAttachment FileAttachment { get; set; }
    }
}
