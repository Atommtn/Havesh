namespace HaveshApp.Admin.MemberShip.Model
{
    public class User
    {

        public int Id { get; set; }
        public bool Gender { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public List<Role> Roles { get; } = new();
        public bool IsActive { get; set; }

        public string BCode { get; set; }
    }

    public class Role
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


    public class Permission
    {
            public int Id { get; set; }

        public bool Allow { get; set; }
        public string Title { get; set; }
        public List<Role> Roles { get; } = new();
        
    }
}
