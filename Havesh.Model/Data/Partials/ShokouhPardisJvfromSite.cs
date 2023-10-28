
using System.ComponentModel.DataAnnotations.Schema;

namespace Havesh.Model.Model;

public partial class ShokouhPardisJvfromSite
{
	[ForeignKey(nameof(Model.ShokouhPardisJvfromSite.AttachmentFk))]
	public ShokouhPardisFileAttachment FileAttachment { get; set; }
}