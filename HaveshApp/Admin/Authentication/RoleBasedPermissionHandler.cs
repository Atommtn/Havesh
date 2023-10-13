using Microsoft.AspNetCore.Authorization;
using ShokouhApp.Admin.MemberShip.Model;
using ShokouhApp.Services;

namespace ShokouhApp.Admin.Authentication;

public class RoleBasedPermissionHandler : AuthorizationHandler<PermissionRequirement>
{
    DataProviderService _providerService = null!;
    List<Role> _roles = null!;
    private readonly IServiceProvider _serviceProvider;

    public RoleBasedPermissionHandler(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        InitRoles();

    }
    public void InitRoles()
    {
        using var scope = _serviceProvider.CreateScope();
        _providerService = scope.ServiceProvider.GetRequiredService<DataProviderService>();
        _roles = _providerService.GetRoles();

    }
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
    {
        if (context.User.Identity is { IsAuthenticated: false })
        {
            context.Fail();
            return Task.CompletedTask;
        }

        var roles = context.User.Claims
                    .Where(c => c.Type == "role")
                    .Select(c => _roles.First(x=>x.Name == c.Value) )
                    .ToList();

        if (roles.Any(x=>x.Name.Equals("Admin" , StringComparison.OrdinalIgnoreCase)) 
                    || roles.Any(role => requirement.RequiredPermissions.Any(role.HasPermission)))
            context.Succeed(requirement);
        else
            context.Fail();

        return Task.CompletedTask;
    }
}

public class PermissionRequirement : IAuthorizationRequirement
{
    public IEnumerable<string> RequiredPermissions { get; }

    public PermissionRequirement(params string[] requiredPermissions)
    {
        RequiredPermissions = requiredPermissions;
    }
}
