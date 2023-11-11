using System.ComponentModel.DataAnnotations.Schema;
using Havesh.Model.Data;
using Havesh.Model.Data.Dashboard;
using Olive;

namespace Havesh.Model.Model;


public class User : BranchBaseModel
{

    public bool? Gender { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public List<Role> Roles { get; } = new();
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

public class Role : BranchBaseModel
{
    public string Name { get; set; }
    public List<User> Users { get; } = new();

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


public class Permission : BranchBaseModel
{

    public bool Allow { get; set; }
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