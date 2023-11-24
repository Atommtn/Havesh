using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

[GenerateSerializer]
public partial class ShokouhPardisTimeTable : BranchBaseModel
{
	[Id(0)]
	public Guid TimeTableGuid { get; set; }
	[Id(1)]
	public DateTime TimeTableLastModified { get; set; }
	[Id(2)]
	public int TermId { get; set; }
	[Id(3)]
	public int TeacherId { get; set; }
	[Id(4)]
	public int ScheduleId { get; set; }
	[Id(5)]
	public string? Title { get; set; }
	[Id(6)]
	public string? Description { get; set; }
	[Id(7)]
	public int LevelId { get; set; }
	[Id(8)]
	public int ClassRoomId { get; set; }
	[Id(9)]
	public bool IsPrivate { get; set; }
}