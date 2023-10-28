using Havesh.Model.Data;

namespace Havesh.Model.Model;

public partial class ShokouhPardisFileAttachment : BranchBaseModel
{
	public int Id { get; set; }
	public Guid Guid { get; set; }
	public DateTime LastModified { get; set; }
	public string? FileTitle { get; set; }
	public byte[]? FileContent { get; set; }
	public string? Folder { get; set; }
	public string? DataUrl { get; set; }
	public string? FileName { get; set; }
	public string ContentType { get; set; }

}