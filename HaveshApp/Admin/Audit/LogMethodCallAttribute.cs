using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Filters;
using Serilog;
using ShokouhApp.Admin.Authentication;

namespace ShokouhApp.Admin.Audit
{
    public class LogMethodCallAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var userClaim = context.HttpContext.User.Claims.First(claim => claim.Type == ClaimTypes.Name);
            //var controllerName = context.Controller.GetType().Name;
            var methodName = context.ActionDescriptor.DisplayName;

            Log.Information("{User} Tried {MethodName}", userClaim.Value, methodName);
            base.OnActionExecuted(context);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {

            base.OnActionExecuting(context);
        }
    }
}
