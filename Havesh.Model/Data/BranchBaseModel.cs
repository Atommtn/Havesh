using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;
using Orleans;

namespace Havesh.Model.Data;

[Table("AppBranch")]
public class Branch
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)] 
	public int Id { get; set; }

	public string Code { get; set; }
	public string Name { get; set; }
	public bool IsArchived { get; set; }
	
	public int? ParentBranchFk { get; set; }
	
	[ForeignKey(nameof(ParentBranchFk))]
	public Branch? ParentBranch { get; set; }

}

[Serializable]
[GenerateSerializer]
public class BranchBaseModel : BaseModel
{

	public string? BCode { get; set; }

	public int BranchFk { get; set; }

	[ForeignKey(nameof(BranchFk))]
	public Branch Branch { get; set; }

}

[Serializable]
[GenerateSerializer]
public class BaseModel : ICanBeSoftDeleted
{
	[Id(0)]
	public int Id { get; set; }

    [Id(1)]
    public Guid Guid { get; set; } = Guid.NewGuid();


    [Id(2)]
    public bool IsDeleted { get; set; }

	[Id(3)]
    public int CreatedByUserId { get; set; } = 4;
	
    /*
    [ForeignKey(nameof(CreatedByUserId))]
    public User CreatedBy { get; set; }
    */

    public DateTime CreatedWhen { get; set; } = DateTime.UtcNow;

    public int? ModifiedByUserId { get; set; } 

    /*
    [ForeignKey(nameof(ModifiedByUserId))]
    public User? ModifiedBy { get; set; }
    */

    public DateTime? ModifiedWhen { get; set; }

}

public interface ICanBeSoftDeleted
{
    public bool IsDeleted { get; set; }

}