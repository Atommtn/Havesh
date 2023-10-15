using Microsoft.AspNetCore.Authorization;

namespace HaveshApp.Admin.Authentication
{
    public abstract class AuthorizationPolicies
    {
        public static void AddAuthorizarionPolicies(IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                options
                    .AddPolicy(Permissions.FinancialActivityPermission, policy =>
                    {
                        policy.Requirements.Add(new PermissionRequirement(
                            FinancialActivityPermission.AddDailyJv,
                            FinancialActivityPermission.UpdateDailyJv,
                            FinancialActivityPermission.DeleteDailyJv));
                    });
            });

            services.AddSingleton<IAuthorizationHandler, RoleBasedPermissionHandler>();

        }
    }
}
