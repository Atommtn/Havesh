using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Havesh.Model.Data;
using Microsoft.EntityFrameworkCore;

namespace Havesh.Model.Model;

[Table("ShokouhPardis_LessonPlan")]
[Serializable]
[GenerateSerializer]
public partial class LessonPlan : BranchBaseModel
{

	[Id(0)]
	public int LevelFk { get; set; }
	[Id(1)]
	public int SessionNumber { get; set; }
	[Id(2)]
	public string? Title { get; set; }


}

public partial class LessonPlan
{
	[ForeignKey(nameof(LevelFk))]
	public ShokouhPardisLevelClass Level { get; set; }
	public List<LessonPlanSection> Sections { get; set; }
	public List<LessonPlanAttachment> LessonPlanAttachments { get; set; }
	public static LessonPlan CreateLessonPlan()
	{
		return new LessonPlan()
		{
		};
	}
}

[Serializable]
[GenerateSerializer]
[Table("ShokouhPardis_LessonPlanAttachments")]
public class LessonPlanAttachment
{
	[Id(0)]
	public int LessonPlanId { get; set; }
	

	[ForeignKey(nameof(LessonPlanId))]
	public LessonPlan LessonPlan { get; set; }

	[Id(1)]
	public int AttachmentId { get; set; }
	
	[ForeignKey(nameof(AttachmentId))]
	public ShokouhPardisMediaAttachment Attachment { get; set; }


	public static void Setup(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<LessonPlanAttachment>()
			.HasKey(x => new { x.LessonPlanId , x.AttachmentId} );
	}
}

[Serializable]
[GenerateSerializer]
[Table("ShokouhPardis_LessonPlanSectionType")]
public class LessonPlanSectionType : BranchBaseModel
{
	[Id(0)]
	public int Id { get; set; }
	[Id(1)]
	public string Title { get; set; }
}

[Table("ShokouhPardis_LessonPlanSection")]
[Serializable]
[GenerateSerializer]
public partial class LessonPlanSection : BranchBaseModel
{

	public int LessonPlanFk { get; set; }
	
	[ForeignKey(nameof(LessonPlanFk))]
	public LessonPlan LessonPlan { get; set; }

	public int Order { get; set; }
	public int SectionTypeFk { get; set; }
	
	[ForeignKey(nameof(SectionTypeFk))]
	public LessonPlanSectionType SectionType { get; set; }


	public string SectionTitle { get; set; }
	public string? Duration { get; set; }
	public string? SectionObjective { get; set; }

	public List<LessonPlanSectionItem> Items { get; set; }

}
public partial class LessonPlanSection
{

    [NotMapped] public bool ShowDetail { get; set; } = false;
}


[Table("ShokouhPardis_LessonPlanSectionItem")]
public class LessonPlanSectionItem : BranchBaseModel
{
	public int Id { get; set; }

	public int LessonPlanSectionFk { get; set; }
	
	[ForeignKey(nameof(LessonPlanSectionFk))]
	public LessonPlanSection Section { get; set; }
	public int Order { get; set; }
	public string SectionItemTitle { get; set; }

}

[Table("ShokouhPardis_MediaAttachment")]
public class ShokouhPardisMediaAttachment : BranchBaseModel
{
	public string? FileName { get; set; }

	[DataType("varbinary(max)")]
	public byte[]? FileData { get; set; }

	public string? Url { get; set; }
}
