using System.ComponentModel.DataAnnotations.Schema;
using Havesh.Model.Data;
using Havesh.Model.Data.Dashboard;
using Olive;
using Orleans;

namespace Havesh.Model.Model;

[GenerateSerializer]
[Serializable]
public class User : BranchBaseModel
{
    [Id(1)]
    public bool? Gender { get; set; }
    [Id(2)]
    public string UserName { get; set; }
	[Id(3)]
    public string Password { get; set; }
	[Id(4)]
    public string? FirstName { get; set; }
	[Id(5)]
    public string? LastName { get; set; }
	[Id(6)]
    public string? Email { get; set; }
	[Id(7)]
    public string? Phone { get; set; }
    [Id(8)]
    public List<Role> Roles { get; } = new();
    [Id(9)]
    public bool IsActive { get; set; }

    [NotMapped] public string FullName => FirstName + " " + LastName;

    public override string ToString()
    {
        var s = $"{FirstName} {LastName}".Trim();
        return string.IsNullOrEmpty(s) ? UserName : s;
    }

    public string ToString(bool withGender, bool withUserName)
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

        return $"{sex.WithWrappers(null, " ")}{ToString()}";

    }
    public string ToString(string format)
    {
        return string.Format(format, FirstName, LastName, UserName, Id);
    }

    public override bool Equals(object? obj)
    {
        if (obj is User user)
            return Equals(user);
        return false;
    }

    private bool Equals(User other)
    {
        return Id == other.Id;
    }

    public override int GetHashCode()
    {
        return Id;
    }
}

[GenerateSerializer]
[Serializable]
public class Role : BranchBaseModel
{
	[Id(1)]
    public string Name { get; set; }
	[Id(2)]
    public List<User> Users { get; } = new();

    [Id(3)]
    public List<Permission> Permissions { get; } = new();

    public bool HasPermission(string permission)
    {
        return Permissions.Any(x => x.Title.Equals(permission, StringComparison.OrdinalIgnoreCase));
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    protected bool Equals(Role other)
    {
        return Id == other.Id;
    }

    public override int GetHashCode()
    {
        return Id;
    }

    public override string ToString()
    {

        return Name;
    }
}


[Serializable]
[GenerateSerializer]
public class Permission : BranchBaseModel
{

	[Id(1)]
    public bool Allow { get; set; }
	[Id(2)]
    public string Title { get; set; }
    public List<Role> Roles { get; } = new();

}


public class AdvanceRegistration : BranchBaseModel
{
    public bool? Allow { get; set; }
    public string? Title { get; set; }
    public string? Code { get; set; }
    public string UserName { get; set; }

    public DateTime DateTime { get; set; }

}