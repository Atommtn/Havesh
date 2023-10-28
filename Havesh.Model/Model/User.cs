using System.ComponentModel.DataAnnotations.Schema;
using Havesh.Model.Data;
using Olive;

namespace Havesh.Model.Model;

[Serializable]
public class BaseEntity
{

}

public class User : BaseEntity
{

	public int Id { get; set; }
	public bool? Gender { get; set; }
	public string UserName { get; set; }
	public string Password { get; set; }
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public string? Email { get; set; }
	public string? Phone { get; set; }
	public List<Role> Roles { get; } = new();
	public bool IsActive { get; set; }

	public string? BCode { get; set; }
	public int BranchFk { get; set; }

	[NotMapped] public string FullName => FirstName + " " + LastName;

	[ForeignKey(nameof(BranchFk))]
	public Branch Branch { get; set; }

	public override string ToString()
	{
		return $"{FirstName} {LastName}";
	}

	public string ToString(bool withGender,bool withUserName)
	{
		var s = ToString(withGender);
		if (withUserName)
			s += UserName.WithWrappers("[", "]");
		return s;

	}
	public string ToString(bool withGender)
	{
		var sex = "";
		if (withGender)
		{
			sex = Gender switch
			{
				true => "آقای",
				false => "خانم",
				_ => ""
			};
		}

		return $"{sex.WithWrappers(null," ")}{ToString()}";

	}
	public string ToString(string format)
	{
		return string.Format(format , FirstName , LastName , UserName , Id);
	}
}

public class Role : BaseEntity
{
	public int Id { get; set; }
	public string Name { get; set; }
	public List<User> Users { get; } = new();

	public List<Permission> Permissions { get; } = new();


	public bool HasPermission(string permission)
	{
		return Permissions.Any(x => x.Title.Equals(permission,StringComparison.OrdinalIgnoreCase));
	}
}


public class Permission : BaseEntity
{
	public int Id { get; set; }

	public bool Allow { get; set; }
	public string Title { get; set; }
	public List<Role> Roles { get; } = new();
        
}


public class AdvanceRegistration : BaseEntity
{
	public int Id { get; set; }
	public bool? Allow { get; set; }
	public string? Title { get; set; }
	public string? Code { get; set; }
	public string UserName { get; set; }

	public int BranchFk { get; set; }
        
	[ForeignKey(nameof(BranchFk))]
	public Branch Branch { get; set; }
	public DateTime DateTime { get; set; }

}